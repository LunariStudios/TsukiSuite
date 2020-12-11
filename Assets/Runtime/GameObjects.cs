﻿using System;
using UnityEngine;
using UnityEngine.Events;

namespace Lunari.Tsuki.Runtime {
    public static class GameObjects {
        /// <summary>
        /// Creates a new <see cref="GameObject"/> with the specified component.
        /// </summary>
        /// <param name="initializer">If not null, this <see cref="UnityAction{T}"/> is
        /// executed upon the created component.</param>
        /// <typeparam name="T">The type of the component to attach to the <see cref="GameObject"/>.</typeparam>
        /// <returns>A tuple with the created <see cref="GameObject"/> and component of type <see cref="T"/>.</returns>
        /// <example>
        /// <code>
        /// Tuple&lt;GameObject, Animator&gt; tuple = GameObjects.CreateWith&lt;Animator&gt;();
        /// GameObject createdObj = tuple.First;
        /// Animator createdAnimator = tuple.Second;
        /// </code>
        /// </example>
        public static Tuple<GameObject, T> CreateWith<T>(
            UnityAction<T> initializer = null
        ) where T : Component {
            return CreateWith($"GameObject ({typeof(T).Name})", initializer);
        }

        /// <summary>
        /// Creates a new <see cref="GameObject"/> with the specified name and component.
        /// </summary>
        /// <param name="name">The name of the <see cref="GameObject"/>.</param>
        /// <param name="initializer">If not null, this <see cref="UnityAction{T}"/> is
        /// executed upon the created component.</param>
        /// <typeparam name="T">The type of the component to attach to the <see cref="GameObject"/>.</typeparam>
        /// <returns>A tuple with the created <see cref="GameObject"/> and component of type <see cref="T"/>.</returns>
        /// <example>
        /// <code>
        /// Tuple&lt;GameObject, Animator&gt; tuple = GameObjects.CreateWith&lt;Animator&gt;("My custom name!");
        /// GameObject createdObj = tuple.First;
        /// Animator createdAnimator = tuple.Second;
        /// </code>
        /// </example>
        public static Tuple<GameObject, T> CreateWith<T>(
            string name,
            UnityAction<T> initializer = null
        ) where T : Component {
            var obj = new GameObject(name);
            var comp = obj.AddComponent<T>();
            initializer?.Invoke(comp);

            return new Tuple<GameObject, T>(obj, comp);
        }

        /// <summary>
        /// Creates a new <see cref="GameObject"/> with the specified components.
        /// </summary>
        /// <param name="initializer">If not null, this <see cref="UnityAction{T}"/> is
        /// executed upon the created component.</param>
        /// <typeparam name="A">The type of the first component to attach to the <see cref="GameObject"/>.</typeparam>
        /// <typeparam name="B">The type of the second component to attach to the <see cref="GameObject"/>.</typeparam>
        /// <returns>A tuple with the created <see cref="GameObject"/> and components.</returns>
        /// <example>
        /// <code>
        /// Tuple&lt;GameObject, Animator, CharacterController&gt; tuple = GameObjects.CreateWith&lt;Animator, CharacterController&gt;();
        /// GameObject createdObj = tuple.First;
        /// Animator createdAnimator = tuple.Second;
        /// CharacterController controller = tuple.Third;
        /// </code>
        /// </example>
        public static Tuple<GameObject, A, B> CreateWith<A, B>(
            UnityAction<A, B> initializer = null
        ) where A : Component where B : Component {
            return CreateWith($"GameObject ({typeof(A).Name}, {typeof(B).Name})", initializer);
        }

        /// <summary>
        /// Creates a new <see cref="GameObject"/> with the specified components and name.
        /// </summary>
        /// <param name="name">The name of the <see cref="GameObject"/>.</param>
        /// <param name="initializer">If not null, this <see cref="UnityAction{T}"/> is
        /// executed upon the created component.</param>
        /// <typeparam name="A">The type of the first component to attach to the <see cref="GameObject"/>.</typeparam>
        /// <typeparam name="B">The type of the second component to attach to the <see cref="GameObject"/>.</typeparam>
        /// <returns>A tuple with the created <see cref="GameObject"/> and components.</returns>
        /// <example>
        /// <code>
        /// Tuple&lt;GameObject, Animator, CharacterController&gt; tuple = GameObjects.CreateWith&lt;Animator, CharacterController&gt;();
        /// GameObject createdObj = tuple.First;
        /// Animator createdAnimator = tuple.Second;
        /// CharacterController controller = tuple.Third;
        /// </code>
        /// </example>
        public static Tuple<GameObject, A, B> CreateWith<A, B>(
            string name,
            UnityAction<A, B> initializer = null
        ) where A : Component where B : Component {
            var obj = new GameObject(name);
            var compA = obj.AddComponent<A>();
            var compB = obj.AddComponent<B>();
            initializer?.Invoke(compA, compB);

            return new Tuple<GameObject, A, B>(obj, compA, compB);
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
        /// Attempts to find an existing instance of a component of type <see cref="T"/> within this 
        /// game object's children.
        /// <br/>
        /// If a valid component is found, this method returns true and sets the value of the <see cref="component"/>
        /// parameter to it, otherwise, false is returned and component is set to null.
        /// </summary>
        /// <param name="obj">The game object to search for the component in.</param>
        /// <param name="component">Where the found component will be written back to</param>
        /// <typeparam name="T">The type of the component to search for.</typeparam>
        public static bool TryGetComponentInChildren<T>(this GameObject obj, out T component) where T : Component {
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
        public static bool TryGetComponentInParent<T>(this GameObject obj, out T component) where T : Component {
            return (component = obj.GetComponentInParent<T>()) != null;
        }
    }
}