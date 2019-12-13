using UnityEngine;

namespace Lunari.Tsuki.Runtime.Singletons {
    /// <summary>
    /// Represents an object of which there is only one instance ever.
    /// Usually managers.
    /// <br/>
    /// Usage would be something among the lines of:
    /// <code>
    /// // Singleton declaration
    /// public class MySingleton : Singleton&lt;MySingleton&gt; {
    ///     public void DoMyThing() { }
    /// }
    /// // Usage
    /// MySingleton s = MySingleton.Instance;
    /// s.DoMyThing();
    /// </code>
    /// </summary>
    /// <typeparam name="T">The singleton's own type, as specified in the example.</typeparam>
    public class Singleton<T> : MonoBehaviour where T : Singleton<T> {
        private static T instance;

        /// <summary>
        /// The currently active instance of this singleton.
        /// <br/>
        /// If none is found, returns null.
        /// <br/>
        /// If you want an instance to be returned anyways, see <see cref="EnsuredInstance"/>.
        /// </summary>
        public static T Instance => instance ? instance : instance = FindObjectOfType<T>();
/*

        /// <summary>
        /// The currently active instance of this singleton.
        /// <br/>
        /// If no instance is currently active, creates a new GameObject and attaches a
        /// component of type <see cref="T"/> to it.
        /// <br/>
        /// If you do not want an instance to be created (maybe you need a singleton that you modified a couple of
        /// properties and placed on the scene), see <see cref="Instance"/>.
        /// </summary>
        public static T EnsuredInstance => Instance ? Instance : CreateSingleton();
*/

        private static T CreateSingleton() {
            return new GameObject() {
                name = $"Singleton ({typeof(T).Name})"
            }.AddComponent<T>();
        }
    }

    public class StaticSingleton<T> : MonoBehaviour where T : StaticSingleton<T> {
        private static T instance;

        /// <summary>
        /// The currently active instance of this singleton.
        /// <br/>
        /// If none is found, returns null.
        /// <br/>
        /// If you want an instance to be returned anyways, see <see cref="EnsuredInstance"/>.
        /// </summary>
        public static T Instance {
            get {
                if (instance == null) {
                    instance = FindObjectOfType<T>();
                }
                return instance ? instance : instance = CreateSingleton();
            }
        }
        private static T CreateSingleton() {
            return new GameObject() {
                name = $"Singleton ({typeof(T).Name})"
            }.AddComponent<T>();
        }
    }
}