using System;
using UnityEngine;
using Object = UnityEngine.Object;

namespace Lunari.Tsuki.Misc {
    [Serializable]
    public class SerializableInterface<T> where T : class {
        public T Value {
            get => managed as T;
            set => managed = value as Object;
        }


        [SerializeField, HideInInspector]
        private Object managed;
    }
}