using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using Lunari.Tsuki.Singletons;
using Mono.Cecil;
using Mono.Cecil.Cil;
using Mono.Cecil.Rocks;
using Unity.CompilationPipeline.Common.Diagnostics;
using Unity.CompilationPipeline.Common.ILPostProcessing;
using UnityEngine;
using MethodAttributes = Mono.Cecil.MethodAttributes;
namespace Lunari.Tsuki.CodeGen {
    public class ManagerPostProcessor : ILPostProcessor {

        private readonly List<DiagnosticMessage> _diagnostics = new List<DiagnosticMessage>();
        private MethodReference _initializeOnLoadAttributeCtor;
        private TypeReference _runtimeInitializeLoadType;
        private FieldDefinition _runtimeInitializeLoadAfterAssemblies;
        private TypeDefinition _managerType;
        private MethodDefinition _managerLoadMethod;
        public override ILPostProcessor GetInstance() {
            return new ManagerPostProcessor();
        }
        public override bool WillProcess(ICompiledAssembly compiledAssembly) {
            return compiledAssembly.References.Any(reference => reference.Contains("Tsuki.Runtime.dll"));
        }
        public override ILPostProcessResult Process(ICompiledAssembly compiledAssembly) {
            _diagnostics.Clear();
            LogErr(
                $"Logs/{compiledAssembly.Name}.refs.txt",
                compiledAssembly.References
            );

            var assemblyDefinition = CodeGenHelpers.AssemblyDefinitionFor(compiledAssembly, out var resolver);

            try {
                if (assemblyDefinition == null) {
                    _diagnostics.AddError($"Unable to find assembly definition for {compiledAssembly.Name}");
                    return null;
                }
                if (!FindReferences(assemblyDefinition, resolver)) {
                    _diagnostics.AddError($"Unable to find all required references for {compiledAssembly.Name}: {assemblyDefinition.Name}");
                } else {

                    var managers = assemblyDefinition.MainModule
                        .GetTypes()
                        .Where(t => {
                            var isSubclassOf = t.IsSubclassOf(typeof(Manager<>).FullName);
                            _diagnostics.AddWarning($"{t.FullName} @ {isSubclassOf}");
                            return isSubclassOf;
                        });
                    foreach (var definition in managers) {
                        ProcessManager(definition, compiledAssembly, assemblyDefinition);
                    }
                }

            }
            catch (Exception e) {
                LogErr(
                    $"Logs/{compiledAssembly.Name}.err.log",
                    new[] {
                        e.Message,
                        e.StackTrace,
                        e.Source,
                        e.InnerException?.ToString() ?? "no inner exception"
                    }
                );
            }
            // write

            if (assemblyDefinition == null) {
                return new ILPostProcessResult(compiledAssembly.InMemoryAssembly, _diagnostics);
            }
            var pe = new MemoryStream();
            var pdb = new MemoryStream();

            var writerParameters = new WriterParameters {
                SymbolWriterProvider = new PortablePdbWriterProvider(),
                SymbolStream = pdb,
                WriteSymbols = true
            };
            assemblyDefinition.Write(pe, writerParameters);
            return new ILPostProcessResult(new InMemoryAssembly(pe.ToArray(), pdb.ToArray()), _diagnostics);
        }
        private void LogErr(string path, string[] content) {

            var p = Path.GetFullPath(path);

            File.WriteAllLines(p,
                content
            );
            _diagnostics.AddError(
                $"Exception while post-processing managers, view log @ '{p}'"
            );
        }
        private bool FindReferences(AssemblyDefinition assemblyDefinition, PostProcessorAssemblyResolver postProcessorAssemblyResolver) {

            var mainModule = assemblyDefinition.MainModule;
            var unityAsm=postProcessorAssemblyResolver.Resolve(new AssemblyNameReference("UnityEngine", new Version()));
            var runtimeInitializeOnLoadMethodAttribute = mainModule.GetType("UnityEngine", "RuntimeInitializeOnLoadMethodAttribute");
            if (runtimeInitializeOnLoadMethodAttribute == null) {
                _diagnostics.AddError($"Unable to find UnityEngine.RuntimeInitializeOnLoadMethodAttribute for assembly {assemblyDefinition.Name}");
                return false;
            }
            var runtimeInitializeLoadType = mainModule.GetType("UnityEngine", "RuntimeInitializeLoadType ");
            if (runtimeInitializeLoadType == null) {
                _diagnostics.AddError($"Unable to find UnityEngine.RuntimeInitializeLoadType for assembly {assemblyDefinition.Name}");
                return false;
            }
            _runtimeInitializeLoadType = mainModule.ImportReference(runtimeInitializeLoadType);
            if (_runtimeInitializeLoadType == null) {
                return false;
            }
            //_runtimeInitializeLoadAfterAssemblies = runtimeInitializeLoadType.Fields.FirstOrDefault(x => x.Name == "AfterAssembliesLoaded");
            if (_runtimeInitializeLoadAfterAssemblies == null) {
                return false;
            }
            //_initializeOnLoadAttributeCtor = mainModule.ImportReference(
            //    runtimeInitializeOnLoadMethodAttribute.GetConstructors().FirstOrDefault(x => x.Name == ".ctor" && x.HasParameters)
            //);
            if (_initializeOnLoadAttributeCtor == null) {
                return false;
            }
            //_managerType = mainModule.GetType(typeof(Manager<>).FullName);
            if (_managerType == null) {
                return false;
            }
            //_managerLoadMethod = _managerType.Methods.FirstOrDefault(definition => definition.Name == "LoadManager" && !definition.HasParameters);
            if (_managerLoadMethod == null) {
                return false;
            }
            return true;
        }
        private void ProcessManager(TypeDefinition typeDefinition, ICompiledAssembly compiledAssemblyDefines, AssemblyDefinition assemblyDefinition) {
            var definition = new MethodDefinition(
                $"Init{typeDefinition.Name}",
                MethodAttributes.Static | MethodAttributes.Public,
                typeDefinition.Module.TypeSystem.Void
            );

            var attribute = new CustomAttribute(_initializeOnLoadAttributeCtor);
            attribute.ConstructorArguments.Add(new CustomAttributeArgument(_runtimeInitializeLoadType, _runtimeInitializeLoadAfterAssemblies.Constant));
            definition.CustomAttributes.Add(attribute);
            definition.Body.GetILProcessor().Emit(OpCodes.Call, _managerLoadMethod);
            typeDefinition.Methods.Add(definition);
            _diagnostics.AddWarning($"Added method {definition} to {typeDefinition}");
        }
    }
}