using System;
using UnityEditor;
using UnityEngine;
using Object = UnityEngine.Object;

namespace Lunari.Tsuki.Misc {
    public abstract class SerializableInterface {
        public abstract Object GetObject();
        public abstract void SetObject(Object value);
    }
    [Serializable]
    public class SerializableInterface<T> : SerializableInterface where T : class {
        public T Value {
            get => managed as T;
            set => managed = value as Object;
        }

        public override Object GetObject() {
            return managed;
        }
        public override void SetObject(Object value) {
            Value = value as T;
        }

        [SerializeField, HideInInspector]
        private Object managed;
    }
   
}