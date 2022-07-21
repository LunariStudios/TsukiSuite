using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Mono.Cecil;
using Mono.Cecil.Cil;
using Mono.Cecil.Rocks;
using Unity.CompilationPipeline.Common.Diagnostics;
using Unity.CompilationPipeline.Common.ILPostProcessing;
using UnityEngine;
namespace Lunari.Tsuki.CodeGen {
    internal static class CodeGenHelpers {
        public const string RuntimeAssemblyName = "Unity.Netcode.Runtime";

        public static readonly string UnityColor_FullName = typeof(Color).FullName;
        public static readonly string UnityColor32_FullName = typeof(Color32).FullName;
        public static readonly string UnityVector2_FullName = typeof(Vector2).FullName;
        public static readonly string UnityVector3_FullName = typeof(Vector3).FullName;
        public static readonly string UnityVector4_FullName = typeof(Vector4).FullName;
        public static readonly string UnityQuaternion_FullName = typeof(Quaternion).FullName;
        public static readonly string UnityRay_FullName = typeof(Ray).FullName;
        public static readonly string UnityRay2D_FullName = typeof(Ray2D).FullName;

        public static bool IsSubclassOf(this TypeDefinition typeDefinition, string classTypeFullName) {
            if (!typeDefinition.IsClass) return false;

            var baseTypeRef = typeDefinition.BaseType;
            while (baseTypeRef != null) {
                if (baseTypeRef.FullName == classTypeFullName) return true;

                try {
                    baseTypeRef = baseTypeRef.Resolve().BaseType;
                }
                catch {
                    return false;
                }
            }

            return false;
        }

        public static string FullNameWithGenericParameters(this TypeReference typeReference, GenericParameter[] contextGenericParameters, TypeReference[] contextGenericParameterTypes) {
            var name = typeReference.FullName;
            if (typeReference.HasGenericParameters) {
                name += "<";
                for (var i = 0; i < typeReference.Resolve().GenericParameters.Count; ++i) {
                    if (i != 0) name += ", ";

                    for (var j = 0; j < contextGenericParameters.Length; ++j)
                        if (typeReference.GenericParameters[i].FullName == contextGenericParameters[i].FullName) {
                            name += contextGenericParameterTypes[i].FullName;
                            break;
                        }
                }

                name += ">";
            }

            return name;
        }

        public static bool HasInterface(this TypeReference typeReference, string interfaceTypeFullName) {
            if (typeReference.IsArray) return false;

            try {
                var typeDef = typeReference.Resolve();
                var typeFaces = typeDef.Interfaces;
                return typeFaces.Any(iface => iface.InterfaceType.FullName == interfaceTypeFullName);
            }
            catch {
                return false;
            }
        }

        public static TypeReference GetEnumAsInt(this TypeReference typeReference) {
            if (typeReference.IsArray) return null;

            try {
                var typeDef = typeReference.Resolve();
                return typeDef.IsEnum ? typeDef.GetEnumUnderlyingType() : null;
            }
            catch {
                return null;
            }
        }

        public static void AddError(this List<DiagnosticMessage> diagnostics, string message) {
            diagnostics.AddError((SequencePoint) null, message);
        }

        public static void AddError(this List<DiagnosticMessage> diagnostics, MethodDefinition methodDefinition, string message) {
            diagnostics.AddError(methodDefinition.DebugInformation.SequencePoints.FirstOrDefault(), message);
        }

        public static void AddError(this List<DiagnosticMessage> diagnostics, SequencePoint sequencePoint, string message) {
            diagnostics.Add(new DiagnosticMessage {
                DiagnosticType = DiagnosticType.Error,
                File = sequencePoint?.Document.Url.Replace($"{Environment.CurrentDirectory}{Path.DirectorySeparatorChar}", ""),
                Line = sequencePoint?.StartLine ?? 0,
                Column = sequencePoint?.StartColumn ?? 0,
                MessageData = $" - {message}"
            });
        }

        public static void AddWarning(this List<DiagnosticMessage> diagnostics, string message) {
            diagnostics.AddWarning((SequencePoint) null, message);
        }

        public static void AddWarning(this List<DiagnosticMessage> diagnostics, MethodDefinition methodDefinition, string message) {
            diagnostics.AddWarning(methodDefinition.DebugInformation.SequencePoints.FirstOrDefault(), message);
        }

        public static void AddWarning(this List<DiagnosticMessage> diagnostics, SequencePoint sequencePoint, string message) {
            diagnostics.Add(new DiagnosticMessage {
                DiagnosticType = DiagnosticType.Warning,
                File = sequencePoint?.Document.Url.Replace($"{Environment.CurrentDirectory}{Path.DirectorySeparatorChar}", ""),
                Line = sequencePoint?.StartLine ?? 0,
                Column = sequencePoint?.StartColumn ?? 0,
                MessageData = $" - {message}"
            });
        }

        public static void RemoveRecursiveReferences(this ModuleDefinition moduleDefinition) {
            // Weird behavior from Cecil: When importing a reference to a specific implementation of a generic
            // method, it's importing the main module as a reference into itself. This causes Unity to have issues
            // when attempting to iterate the assemblies to discover unit tests, as it goes into infinite recursion
            // and eventually hits a stack overflow. I wasn't able to find any way to stop Cecil from importing the module
            // into itself, so at the end of it all, we're just going to go back and remove it again.
            var moduleName = moduleDefinition.Name;
            if (moduleName.EndsWith(".dll") || moduleName.EndsWith(".exe")) moduleName = moduleName.Substring(0, moduleName.Length - 4);

            foreach (var reference in moduleDefinition.AssemblyReferences) {
                var referenceName = reference.Name.Split(',')[0];
                if (referenceName.EndsWith(".dll") || referenceName.EndsWith(".exe")) referenceName = referenceName.Substring(0, referenceName.Length - 4);

                if (moduleName == referenceName)
                    try {
                        moduleDefinition.AssemblyReferences.Remove(reference);
                        break;
                    }
                    catch (Exception) {
                        //
                    }
            }
        }

        public static AssemblyDefinition AssemblyDefinitionFor(ICompiledAssembly compiledAssembly, out PostProcessorAssemblyResolver assemblyResolver) {
            assemblyResolver = new PostProcessorAssemblyResolver(compiledAssembly);
            var readerParameters = new ReaderParameters {
                SymbolStream = new MemoryStream(compiledAssembly.InMemoryAssembly.PdbData),
                SymbolReaderProvider = new PortablePdbReaderProvider(),
                AssemblyResolver = assemblyResolver,
                ReflectionImporterProvider = new PostProcessorReflectionImporterProvider(),
                ReadingMode = ReadingMode.Immediate
            };

            var assemblyDefinition = AssemblyDefinition.ReadAssembly(new MemoryStream(compiledAssembly.InMemoryAssembly.PeData), readerParameters);

            //apparently, it will happen that when we ask to resolve a type that lives inside Unity.Netcode.Runtime, and we
            //are also postprocessing Unity.Netcode.Runtime, type resolving will fail, because we do not actually try to resolve
            //inside the assembly we are processing. Let's make sure we do that, so that we can use postprocessor features inside
            //Unity.Netcode.Runtime itself as well.
            assemblyResolver.AddAssemblyDefinitionBeingOperatedOn(assemblyDefinition);

            return assemblyDefinition;
        }
    }
}