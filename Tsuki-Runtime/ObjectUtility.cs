using UnityEngine;

namespace Lunari.Tsuki {
    public static class ObjectUtility {
        public static T Clone<T>(this T obj, Vector3 transform) where T : Object {
            return Clone(obj, transform, Quaternion.identity);
        }

        public static T Clone<T>(this T obj, Vector3 transform, Quaternion rotation) where T : Object {
            return Object.Instantiate(obj, transform, rotation);
        }

        public static T Clone<T>(this T obj, Transform transform) where T : Object {
            return Object.Instantiate(obj, transform);
        }

        public static T GetOrAddComponent<T>(this Component obj) where T : Component {
            return obj.gameObject.GetOrAddComponent<T>();
        }

        public static T GetOrAddComponent<T>(this GameObject obj) where T : Component {
            var f = obj.GetComponent<T>();
            return f ? f : obj.AddComponent<T>();
        }

        public static bool IsNotNullUnityWise(this object obj) {
            return !obj.IsNullUnityWise();
        }

        public static bool IsNullUnityWise(this object obj) {
            if (obj == null) {
                return true;
            }

            if (obj is Object o) {
                // Check if native object is alive
                return o == null;
            }

            return false;
        }
    }
}