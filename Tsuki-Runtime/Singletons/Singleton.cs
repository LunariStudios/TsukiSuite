using UnityEngine;

namespace Lunari.Tsuki.Singletons {
    public class Singleton<T> : MonoBehaviour where T : Singleton<T> {
        private static T instance;

        public static T Instance {
            get {
                return instance ? instance : (instance = FindObjectOfType<T>());
            }
        }
    }
}