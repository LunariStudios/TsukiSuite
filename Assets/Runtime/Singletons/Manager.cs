using System;
using UnityEngine;
namespace Lunari.Tsuki.Singletons {
    public abstract class Manager<TSelf> : MonoBehaviour where TSelf : Manager<TSelf> {

        private static string ManagerName = typeof(TSelf).Name;
        protected static void LoadManager() {
            Debug.Log($"Loading manager {typeof(TSelf).GetLegibleName()}");
            Instance = Resources.Load<TSelf>(ManagerName);
            if (Instance != null) {
                DontDestroyOnLoad(Instance.gameObject);
            }
        }

        public static TSelf Instance {
            get;
            private set;
        }
#if UNITY_EDITOR
        private void OnValidate() {
            gameObject.name = ManagerName;
        }
#endif
    }
}