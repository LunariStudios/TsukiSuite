using UnityEngine;

namespace Lunari.Tsuki.Singletons {
    public abstract class Manager<TSelf> : MonoBehaviour where TSelf : Manager<TSelf> {

        private static string ManagerName = typeof(TSelf).Name;
        protected static void LoadManager() {
            var legibleName = typeof(TSelf).GetLegibleName();
            Debug.Log($"{legibleName} Loading manager");
            var prefab = Resources.Load<TSelf>(ManagerName);
            Instance = prefab.Clone();
            Instance.name = $"{legibleName} (Manager)";
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