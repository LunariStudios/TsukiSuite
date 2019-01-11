using Lunari.Tsuki.Misc;
using UnityEngine;
using UnityEngine.Events;

namespace Lunari.Tsuki {
    public static class GameObjectUtility {
        public static Tuple<GameObject, T> CreateGameObjectWith<T>(UnityAction<T> initializer = null)
            where T : Component {
            return CreateGameObjectWith("GameObject (" + typeof(T).Name + ")", initializer);
        }

        public static Tuple<GameObject, T> CreateGameObjectWith<T>(string name, UnityAction<T> initializer = null)
            where T : Component {
            var obj = new GameObject();
            var comp = obj.AddComponent<T>();
            initializer?.Invoke(comp);

            return new Tuple<GameObject, T>(obj, comp);
        }

        public static Triple<GameObject, A, B> CreateGameObjectWith<A, B>(UnityAction<A, B> initializer = null)
            where A : Component where B : Component {
            return CreateGameObjectWith("GameObject (" + typeof(A).Name + ", " + typeof(B).Namespace + ")", initializer);
        }

        public static Triple<GameObject, A, B> CreateGameObjectWith
            <A, B>(string name, UnityAction<A, B> initializer = null)
            where A : Component where B : Component {
            var obj = new GameObject();
            var compA = obj.AddComponent<A>();
            var compB = obj.AddComponent<B>();
            if (initializer != null) {
                initializer(compA, compB);
            }

            return new Triple<GameObject, A, B>(obj, compA, compB);
        }
    }
}