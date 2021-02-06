using System;
using System.Collections.Generic;

#if ODIN_INSPECTOR
using Sirenix.OdinInspector;
#endif

namespace Lunari.Tsuki.Runtime.Stacking {
    [Serializable]
    public class Modifier<T> {
        public T value;
    }
    [Serializable]
    public abstract class Stackable<T> {
        public T baseValue;

        public abstract T Value {
            get;
        }
#if ODIN_INSPECTOR
        [ShowInInspector, ReadOnly]
#endif
        protected List<Modifier<T>> modifiers;
        public Modifier<T> AddModifier(T value) {
            modifiers ??= new List<Modifier<T>>();

            var handle = new Modifier<T> {
                value = value
            };
            modifiers.Add(handle);
            return handle;
        }

        public void RemoveModifier(Modifier<T> handle) {
            modifiers?.Remove(handle);
        }
    }
}