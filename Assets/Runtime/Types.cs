using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;

namespace Lunari.Tsuki.Runtime {
    public static class Types {
        public static T GetCustomAttribute<T>(this Type type, bool inherit = false) where T : Attribute {
            var attr = type.GetCustomAttributes(inherit);
            foreach (var o in attr) {
                if (o is T attribute) {
                    return attribute;
                }
            }

            return null;
        }

        public static IEnumerable<T> GetCustomAttributes<T>(this Type type, bool inherit = false) where T : Attribute {
            var attr = type.GetCustomAttributes(inherit);
            foreach (var o in attr) {
                if (o is T attribute) {
                    yield return attribute;
                }
            }
        }

        public static readonly Dictionary<string, string> Wrapped2Primitive = new Dictionary<string, string> {
            {"Single", "float"},
            {"Double", "double"},
            {"SByte", "sbyte"},
            {"Int16", "short"},
            {"Int32", "int"},
            {"Int64", "long"},
            {"Byte", "byte"},
            {"UInt16", "ushort"},
            {"UInt32", "uint"},
            {"UInt64", "ulong"},
            {"Decimal", "decimal"},
            {"String", "string"},
            {"Char", "char"},
            {"Boolean", "bool"},
            {"Single[]", "float[]"},
            {"Double[]", "double[]"},
            {"SByte[]", "sbyte[]"},
            {"Int16[]", "short[]"},
            {"Int32[]", "int[]"},
            {"Int64[]", "long[]"},
            {"Byte[]", "byte[]"},
            {"UInt16[]", "ushort[]"},
            {"UInt32[]", "uint[]"},
            {"UInt64[]", "ulong[]"},
            {"Decimal[]", "decimal[]"},
            {"String[]", "string[]"},
            {"Char[]", "char[]"},
            {"Boolean[]", "bool[]"},
        };

        private static string CheckPrimitive(this Type type) {
            var typeName = type.Name;

            if (Wrapped2Primitive.TryGetValue(typeName, out var altTypeName)) {
                typeName = altTypeName;
            }

            return typeName;
        }

        public static bool InheritsFrom(this Type type, Type baseType) {
            if (baseType.IsAssignableFrom(type)) {
                return true;
            }

            if (type.IsInterface && baseType.IsInterface == false) {
                return false;
            }

            if (baseType.IsInterface) {
                return type.GetInterfaces().Any(tt => baseType == tt);
            }

            var t = type;
            while (t != null) {
                if (t == baseType) {
                    return true;
                }

                if (baseType.IsGenericTypeDefinition && t.IsGenericType && t.GetGenericTypeDefinition() == baseType) {
                    return true;
                }

                t = t.BaseType;
            }

            return false;
        }

        public static string GetLegibleName(this Type type) {
            if (type.IsArray) {
                var rank = type.GetArrayRank();
                return type.GetElementType().GetLegibleName() + (rank == 1 ? "[]" : "[,]");
            }

            if (type.InheritsFrom(typeof(Nullable<>))) {
                return type.GetGenericArguments()[0].GetLegibleName() + "?";
            }

            if (type.IsByRef) {
                return "ref " + type.GetElementType().GetLegibleName();
            }

            if (type.IsGenericParameter || !type.IsGenericType) {
                return CheckPrimitive(type);
            }

            var builder = new StringBuilder();
            var name = type.Name;
            var index = name.IndexOf("`", StringComparison.Ordinal);

            builder.Append(index != -1 ? name.Substring(0, index) : name);

            builder.Append('<');
            var args = type.GetGenericArguments();

            for (var i = 0; i < args.Length; i++) {
                var arg = args[i];

                if (i != 0) {
                    builder.Append(", ");
                }

                builder.Append(GetLegibleName(arg));
            }

            builder.Append('>');
            return builder.ToString();
        }

        private static readonly List<Assembly> KnownAssemblies = new List<Assembly>();

        private static void Reload() {
            KnownAssemblies.Clear();
        }

        static Types() {
            LoadAssemblies();
            AppDomain.CurrentDomain.AssemblyLoad += OnAssemblyLoaded;
        }

        private static void LoadAssemblies() {
            Reload();
            foreach (var assembly in AppDomain.CurrentDomain.GetAssemblies()) {
                RegisterAssembly(assembly);
            }
        }

        private static void OnAssemblyLoaded(object sender, AssemblyLoadEventArgs args) {
            RegisterAssembly(args.LoadedAssembly);
        }

        private static void RegisterAssembly(Assembly assembly) {
            KnownAssemblies.Add(assembly);
        }

        public static IEnumerable<Type> GetAllTypesOf<T>(bool excludeSelf = true) {
            return GetAllTypesOf(typeof(T), excludeSelf);
        }

        public static IEnumerable<Type> GetAllTypesOf(Type target, bool excludeSelf = true) {
            foreach (var assembly in KnownAssemblies) {
                foreach (var type in assembly.GetTypes()) {
                    if (excludeSelf && type == target) {
                        continue;
                    }

                    if (target.IsAssignableFrom(type)) {
                        yield return type;
                    }
                }
            }
        }
    }
}