using System;
using System.Collections.Generic;
using System.Reflection;

namespace UnityUtilities {
    public static class TypeUtility {
        private static bool loaded = false;
        private static readonly List<Assembly> knownAssemblies = new List<Assembly>();

        public static IEnumerable<Type> GetAllTypes() {
            if (loaded) {
                LoadAssemblies();
            }

            foreach (var assembly in knownAssemblies) {
                foreach (var type in assembly.GetExportedTypes()) {
                    yield return type;
                }
            }
        }

        public static IEnumerable<Type> GetAllSubtypesOf<T>() {
            if (loaded) {
                LoadAssemblies();
            }

            var superClass = typeof(T);
            foreach (var type in GetAllTypes()) {
                if (type.IsSubclassOf(superClass)) {
                    yield return type;
                }
            }
        }

        public static IEnumerable<Assembly> KnownAssemblies {
            get {
                return knownAssemblies;
            }
        }

        private static void LoadAssemblies() {
            loaded = true;
            foreach (var assembly in AppDomain.CurrentDomain.GetAssemblies()) {
                RegisterAssembly(assembly);
            }

            AppDomain.CurrentDomain.AssemblyLoad += OnAssemblyLoaded;
        }

        private static void OnAssemblyLoaded(object sender, AssemblyLoadEventArgs args) {
            RegisterAssembly(args.LoadedAssembly);
        }

        private static void RegisterAssembly(Assembly assembly) {
            knownAssemblies.Add(assembly);
        }
    }
}