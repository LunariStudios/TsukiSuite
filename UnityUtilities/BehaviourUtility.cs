using UnityEngine;

namespace UnityUtilities {
    public static class BehaviourUtility {
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
    }
}