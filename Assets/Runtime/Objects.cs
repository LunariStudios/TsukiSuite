using UnityEngine;
namespace Lunari.Tsuki {
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
        public static T Clone<T>(this T obj) where T : Object {
            return Object.Instantiate(obj);
        }

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
        /// game object's children.
        /// <br/>
        /// If a valid component is found, this method returns true and sets the value of the <see cref="component"/>
        /// parameter to it, otherwise, false is returned and component is set to null.
        /// </summary>
        /// <param name="obj">The game object to search for the component in.</param>
        /// <param name="component">Where the found component will be written back to</param>
        /// <typeparam name="T">The type of the component to search for.</typeparam>
        public static bool TryGetComponentInChildren<T>(this Component obj, out T component) where T : Component {
            return (component = obj.GetComponentInChildren<T>()) != null;
        }

        /// <summary>
        /// Attempts to find an existing instance of a component of type <see cref="T"/> within this 
        /// game object's children.
        /// <br/>
        /// If a valid component is found, this method returns true and sets the value of the <see cref="component"/>
        /// parameter to it, otherwise, false is returned and component is set to null.
        /// </summary>
        /// <param name="obj">The game object to search for the component in.</param>
        /// <param name="component">Where the found component will be written back to</param>
        /// <typeparam name="T">The type of the component to search for.</typeparam>
        public static bool TryGetComponentInParent<T>(this Component obj, out T component) where T : Component {
            return (component = obj.GetComponentInParent<T>()) != null;
        }
    }
}