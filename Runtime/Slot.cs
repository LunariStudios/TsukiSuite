using System;
using UnityEditor.UIElements;
using UnityEngine.Events;
#if ODIN_INSPECTOR
using Sirenix.OdinInspector;
#endif
namespace Lunari.Tsuki {
    [Serializable]
    public class Slot<T> where T : class {
        private T _value = default;

        public UnityEvent Changed { get; } = new UnityEvent();

        public static implicit operator T(Slot<T> slot) => slot._value;

#if ODIN_INSPECTOR
        [ShowInInspector]
#endif
        public T Value {
            get => _value;
            set {
                if (_value != null && _value.Equals(value)) {
                    return;
                }
                _value = value;
                Changed.Invoke();
            }
        }

        public Slot<T> OnChanged(UnityAction onChanged) {
            Changed.AddListener(onChanged);
            return this;
        }

        public Slot<T> OnChanged(UnityAction<T> onChanged) {
            OnChanged(() => {
                onChanged(_value);
            });
            return this;
        }
        public Slot<T> OnChanged(UnityAction<T, T> onChanged) {
            var last = Value;
            OnChanged(() => {
                onChanged(last, Value);
                last = Value;
            });
            return this;
        }
    }
}