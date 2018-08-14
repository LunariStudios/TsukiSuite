using System;
using System.Collections.Generic;
using System.Reflection;

namespace UnityUtilities {
    public static class TypeUtility {
        private static readonly List<Assembly> KnownAssemblies = new List<Assembly>();

        private static void Reload() {
            KnownAssemblies.Clear();
        }

        static TypeUtility() {
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

        public static IEnumerable<Type> GetAllTypesOf<T>() {
            var target = typeof(T);
            foreach (var assembly in KnownAssemblies) {
                foreach (var type in assembly.GetTypes()) {
                    if (target.IsAssignableFrom(type)) {
                        yield return type;
                    }
                }
            }
        }
    }
}