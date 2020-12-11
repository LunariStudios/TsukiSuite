using System;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

namespace Lunari.Tsuki.Runtime {
    [Serializable]
    public class SerializableDictionary<K, V> : Dictionary<K, V>, ISerializationCallbackReceiver {
        [SerializeField, HideInInspector]
        private List<K> keys;

        [SerializeField, HideInInspector]
        private List<V> values;

        public void OnBeforeSerialize() {
            Copy(Keys, ref keys);
            Copy(Values, ref values);
            // Free memory
            Clear();
        }

        private void Copy<T>(IEnumerable<T> from, ref List<T> to) {
            var collection = from.ToArray();
            if (to == null) {
                to = new List<T>(collection.Length);
            }
            else {
                to.Clear();
                to.Capacity = collection.Length;
            }

            to.AddRange(collection);
        }

        public void OnAfterDeserialize() {
            for (var i = 0; i < keys.Count; i++) {
                this[keys[i]] = values[i];
            }
            // Free memory
            keys.Clear();
            values.Clear();
        }
    }
}