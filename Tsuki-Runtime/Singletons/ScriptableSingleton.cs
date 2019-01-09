using UnityEngine;

namespace Lunari.Tsuki.Singletons {
    public abstract class ScriptableSingleton<T> : ScriptableObject where T : ScriptableObject {
        private static readonly string Path = typeof(T).Name;
        private static T instance;

        public static T Instance {
            get {
                return instance ? instance : (instance = Resources.Load<T>(Path));
            }
        }
    }
}