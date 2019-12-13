using UnityEngine;

namespace Lunari.Tsuki.Runtime {
    public static class Objects {
        /// <summary>
        /// Creates a copy of this object and places it at the specified <see cref="position"/>.
        /// <br/>
        /// The copy has no parent transform.
        /// <br/>
        /// Equivalent to <see cref="Object"/>.
        /// <see cref="Object.Instantiate(UnityEngine.Object,UnityEngine.Vector3,UnityEngine.Quaternion)"/>.
        /// </summary>
        /// <param name="obj">The object to clone.</param>
        /// <param name="position">The position to place the clone in.</param>
        /// <typeparam name="T">The type of the object to clone. Usually implicit.</typeparam>
        public static T Clone<T>(this T obj, Vector3 position) where T : Object {
            return Clone(obj, position, Quaternion.identity);
        }

        /// <summary>
        /// Creates a copy of this object, placing it at the specified <see cref="position"/> and <see cref="rotation"/>.
        /// <br/>
        /// The copy has no parent transform.
        /// <br/>
        /// Equivalent to <see cref="Object"/>.
        /// <see cref="Object.Instantiate(UnityEngine.Object,UnityEngine.Vector3,UnityEngine.Quaternion)"/>. 
        /// </summary>
        /// <param name="obj">The object to clone.</param>
        /// <param name="position">The position to place the clone in.</param>
        /// <param name="rotation">The rotation to orient the clone in.</param>
        /// <typeparam name="T">The type of the object to clone. Usually implicit.</typeparam>
        public static T Clone<T>(this T obj, Vector3 position, Quaternion rotation) where T : Object {
            return Object.Instantiate(obj, position, rotation);
        }

        /// <summary>
        /// Creates a copy of this object, placing it as a child of the specified <see cref="transform"/>.
        /// <br/>
        /// The copy has no parent transform.
        /// <br/>
        /// Equivalent to <see cref="Object"/>.<see cref="Object.Instantiate(UnityEngine.Object)"/>. 
        /// </summary>
        /// <param name="obj">The object to clone.</param>
        /// <param name="transform">The parent to set the clone to.</param>
        /// <typeparam name="T">The type of the object to clone. Usually implicit.</typeparam>
        public static T Clone<T>(this T obj, Transform transform) where T : Object {
            return Object.Instantiate(obj, transform);
        }

        /// <summary>
        /// Attempts to find an existing instance of a component of type <see cref="T"/> within this component's
        /// game object. If none is found, attaches a new component to the game object and returns it.
        /// </summary>
        /// <param name="obj">The component attached to the game object to search for.</param>
        /// <typeparam name="T">The type of the component to search for.</typeparam>
        /// <returns>The already existing or a newly created instance of <see cref="T"/>.</returns>
        public static T GetOrAddComponent<T>(this Component obj) where T : Component {
            return obj.gameObject.GetOrAddComponent<T>();
        }

        /// <summary>
        /// Attempts to find an existing instance of a component of type <see cref="T"/> within this 
        /// game object. If none is found, attaches a new component to the game object and returns it.
        /// </summary>
        /// <param name="obj">The game object to search for the component in.</param>
        /// <typeparam name="T">The type of the component to search for.</typeparam>
        /// <returns>The already existing or a newly created instance of <see cref="T"/>.</returns>
        public static T GetOrAddComponent<T>(this GameObject obj) where T : Component {
            var f = obj.GetComponent<T>();
            return f ? f : obj.AddComponent<T>();
        }

        /// <summary>
        /// Tests is this <see cref="obj"/> is a Unity <see cref="Object"/>, in which case, it also tests whether
        /// the corresponding native object is still active.
        /// </summary>
        /// <param name="obj">The object to test</param>
        /// <returns>False if this object is null as both a Unity native object and managed object, otherwise false</returns>
        public static bool IsNotNullUnityWise(this object obj) {
            return !obj.IsNullUnityWise();
        }

        /// <summary>
        /// Tests is this <see cref="obj"/> is a Unity <see cref="Object"/>, in which case, it also tests whether
        /// the corresponding native object is still active.
        /// </summary>
        /// <param name="obj">The object to test</param>
        /// <returns>True if this object is null as both a Unity native object and managed object, otherwise false</returns>
        public static bool IsNullUnityWise(this object obj) {
            switch (obj) {
                case null:
                    return true;
                case Object o:
                    // Check if native object is alive
                    return o == null;
                default:
                    return false;
            }
        }
    }
}