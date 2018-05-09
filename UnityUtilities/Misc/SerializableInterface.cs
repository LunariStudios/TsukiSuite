using System;
using UnityEngine;
using Object = UnityEngine.Object;

namespace UnityUtilities.Misc {
    [Serializable]
    public class SerializableInterface<T> where T : class {
        public T Value {
            get {
                return Object as T;
            }
            set {
                Object = value as Object;
            }
        }


        [SerializeField, HideInInspector]
        private Object Object;
    }
}