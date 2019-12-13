using UnityEngine;

namespace Lunari.Tsuki.Runtime.Singletons {
    /// <summary>
    /// <see cref="ScriptableObject"/> version of <see cref="Singleton{T}"/>
    /// <br/>
    /// Represents a <see cref="ScriptableObject"/> of which there is only one instance ever.
    /// Useful for config files or data that you want to access globally.
    /// <br/>
    /// 
    /// Usage would be something among the lines of:
    /// <code>
    /// // Singleton declaration
    /// public class MySingleton : ScriptableSingleton&lt;MySingleton&gt; {
    ///     public LayerMask EnemyMask;
    /// }
    /// // Usage
    /// MySingleton s = MySingleton.Instance;
    /// LayerMask toUse = s.EnemyMask;
    /// </code>
    /// </summary>
    /// <typeparam name="T">The singleton's own type, as specified in the example.</typeparam>
    public abstract class ScriptableSingleton<T> : ScriptableObject where T : ScriptableObject {
        /// <summary>
        /// The path on which a instance of this singleton is searched for
        /// </summary>
        public static readonly string Path = typeof(T).Name;

        private static T instance;

        /// <summary>
        /// The found instance of this singleton.
        /// <br/>
        /// If none is found, returns null.
        /// <br/>
        /// Unlike <see cref="Singleton{T}"/>, there is no way to ensure a <see cref="ScriptableSingleton{T}"/> to be
        /// returned, as we cannot store it using <see cref="Resources"/>.
        /// </summary>
        public static T Instance => instance ? instance : instance = Resources.Load<T>(Path);
    }
}