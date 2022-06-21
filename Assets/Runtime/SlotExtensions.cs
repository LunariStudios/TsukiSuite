using UnityEditor.UIElements;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UIElements;
namespace Lunari.Tsuki {
    public static class SlotExtensions {
        public static Slot<T> WhenNotNull<T>(this Slot<T> slot, UnityAction<T> block) where T : class {
            slot.OnChanged(v => {
                if (v != null) {
                    block(v);
                }
            });
            var current = slot.Value;
            if (current != null) {
                block(current);
            }
            return slot;
        }
        public static Slot<T> WhenNull<T>(this Slot<T> slot, UnityAction block) where T : class {
            slot.OnChanged(v => {
                if (v == null) {
                    block();
                }
            });
            if (slot.Value == null) {
                block();
            }
            return slot;
        }

        public static Slot<T> OnValueRemoved<T>(this Slot<T> slot, UnityAction<T> onChanged) where T : class {
            var last = slot.Value;
            slot.OnChanged(v => {
                if (last != null) {
                    onChanged(last);
                }
                last = v;
            });
            return slot;
        }
        public static Slot<T> WhenNull<T>(this Slot<T> slot, UnityAction<T> onChanged) where T : class {
            var last = slot.Value;
            slot.WhenNull(() => {
                onChanged(last);
                last = slot.Value;
            });
            return slot;
        }


        public static Slot<T> Listen<T>(this Slot<T> slot, UnityEvent unityEvent, UnityAction action) where T : class {
            unityEvent.AddListener(action);
            slot.Changed.AddSingleFireListener(() => {
                unityEvent.RemoveListener(action);
            });
            return slot;
        }
        public static Slot<T> ListenAndInvoke<T>(this Slot<T> slot, UnityEvent unityEvent, UnityAction action) where T : class {
            slot.Listen(unityEvent, action);
            action();
            return slot;
        }

        public static Slot<T> Listen<T, A>(this Slot<T> slot, UnityEvent<A> unityEvent, UnityAction<A> action) where T : class {
            unityEvent.AddListener(action);
            slot.Changed.AddSingleFireListener(() => {
                unityEvent.RemoveListener(action);
            });
            return slot;
        }
        public static Slot<T> ListenAndInvoke<T, A>(this Slot<T> slot, UnityEvent<A> unityEvent, UnityAction<A> action, A initialValue) where T : class {
            slot.Listen(unityEvent, action);
            action(initialValue);
            return slot;
        }

        public static Slot<T> Listen<T, A, B>(this Slot<T> slot, UnityEvent<A, B> unityEvent, UnityAction<A, B> action) where T : class {
            unityEvent.AddListener(action);
            slot.Changed.AddSingleFireListener(() => {
                unityEvent.RemoveListener(action);
            });
            return slot;
        }
        public static Slot<T> ListenAndInvoke<T, A, B>(this Slot<T> slot, UnityEvent<A, B> unityEvent, UnityAction<A, B> action, A first, B second) where T : class {
            slot.Listen(unityEvent, action);
            action(first, second);
            return slot;
        }

        public static Slot<T> Listen<T, A, B, C>(this Slot<T> slot, UnityEvent<A, B, C> unityEvent, UnityAction<A, B, C> action) where T : class {
            unityEvent.AddListener(action);
            slot.Changed.AddSingleFireListener(() => {
                unityEvent.RemoveListener(action);
            });
            return slot;
        }
        public static Slot<T> ListenAndInvoke<T, A, B, C>(this Slot<T> slot, UnityEvent<A, B, C> unityEvent, UnityAction<A, B, C> action, A first, B second, C third) where T : class {
            slot.Listen(unityEvent, action);
            action(first, second, third);
            return slot;
        }

        public static Slot<T> Listen<T, A, B, C, D>(this Slot<T> slot, UnityEvent<A, B, C, D> unityEvent, UnityAction<A, B, C, D> action) where T : class {
            unityEvent.AddListener(action);
            slot.Changed.AddSingleFireListener(() => {
                unityEvent.RemoveListener(action);
            });
            return slot;
        }
        public static Slot<T> ListenAndInvoke<T, A, B, C, D>(this Slot<T> slot, UnityEvent<A, B, C, D> unityEvent, UnityAction<A, B, C, D> action, A first, B second, C third, D fourth) where T : class {
            slot.Listen(unityEvent, action);
            action(first, second, third, fourth);
            return slot;
        }


        public static void Clear<T>(this Slot<T> slot) where T : class {
            slot.Value = null;
        }
        public static Slot<T> SyncWith<T>(this Slot<T> slot, ObjectField field) where T : Behaviour {
            slot.OnChanged(() => {
                if (field.value != slot.Value) {
                    field.value = slot.Value;
                }
            });
            field.RegisterValueChangedCallback(evt => {
                if (field.value != slot.Value) {
                    slot.Value = evt.newValue as T;
                }
            });
            return slot;
        }
    }
}