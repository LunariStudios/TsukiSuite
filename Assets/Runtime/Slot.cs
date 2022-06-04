using System;
using UnityEngine.Events;
namespace Lunari.Tsuki {
    [Serializable]
    public class Slot<T> where T : class {
        private T value = default;
        private UnityEvent changed = new UnityEvent();

        public static implicit operator T(Slot<T> slot) => slot.value;

        public T Value {
            get => value;
            set {
                if (this.value != null && this.value.Equals(value)) {
                    return;
                }
                this.value = value;
                changed.Invoke();
            }
        }

        public Slot<T> OnChanged(UnityAction onChanged) {
            changed.AddListener(onChanged);
            return this;
        }

        public Slot<T> OnChanged(UnityAction<T> onChanged) {
            OnChanged(() =>
            {
                onChanged(value);
            });
            return this;
        }
        public Slot<T> OnChangedNotNull(UnityAction<T> onChanged) {
            OnChanged(v =>
            {
                if (v != null) {
                    onChanged(v);
                }
            });
            return this;
        }

        public Slot<T> Listen(UnityEvent unityEvent, UnityAction action) {
            unityEvent.AddListener(action);
            changed.AddSingleFireListener(() =>
            {
                unityEvent.RemoveListener(action);
            });
            return this;
        }
        public Slot<T> ListenAndInvoke(UnityEvent unityEvent, UnityAction action) {
            Listen(unityEvent, action);
            action();
            return this;
        }

        public Slot<T> Listen<A>(UnityEvent<A> unityEvent, UnityAction<A> action) {
            unityEvent.AddListener(action);
            changed.AddSingleFireListener(() =>
            {
                unityEvent.RemoveListener(action);
            });
            return this;
        }
        public Slot<T> ListenAndInvoke<A>(UnityEvent<A> unityEvent, UnityAction<A> action, A initialValue) {
            Listen(unityEvent, action);
            action(initialValue);
            return this;
        }

        public Slot<T> Listen<A, B>(UnityEvent<A, B> unityEvent, UnityAction<A, B> action) {
            unityEvent.AddListener(action);
            changed.AddSingleFireListener(() =>
            {
                unityEvent.RemoveListener(action);
            });
            return this;
        }
        public Slot<T> ListenAndInvoke<A, B>(UnityEvent<A, B> unityEvent, UnityAction<A, B> action, A first, B second) {
            Listen(unityEvent, action);
            action(first, second);
            return this;
        }

        public Slot<T> Listen<A, B, C>(UnityEvent<A, B, C> unityEvent, UnityAction<A, B, C> action) {
            unityEvent.AddListener(action);
            changed.AddSingleFireListener(() =>
            {
                unityEvent.RemoveListener(action);
            });
            return this;
        }
        public Slot<T> ListenAndInvoke<A, B, C>(UnityEvent<A, B, C> unityEvent, UnityAction<A, B, C> action, A first, B second, C third) {
            Listen(unityEvent, action);
            action(first, second, third);
            return this;
        }

        public Slot<T> Listen<A, B, C, D>(UnityEvent<A, B, C, D> unityEvent, UnityAction<A, B, C, D> action) {
            unityEvent.AddListener(action);
            changed.AddSingleFireListener(() =>
            {
                unityEvent.RemoveListener(action);
            });
            return this;
        }
        public Slot<T> ListenAndInvoke<A, B, C, D>(UnityEvent<A, B, C, D> unityEvent, UnityAction<A, B, C, D> action, A first, B second, C third, D fourth) {
            Listen(unityEvent, action);
            action(first, second, third, fourth);
            return this;
        }


        public void Clear() {
            Value = null;
        }
    }
    public static class Slots<T> where T : class {
        public static Slot<T> OnChanged(UnityAction onChanged) {
            var slot = new Slot<T>();
            slot.OnChanged(onChanged);
            return slot;
        }
        public static Slot<T> OnChanged(UnityAction<T> onChanged) {
            var slot = new Slot<T>();
            slot.OnChanged(onChanged);
            return slot;
        }

        public static Slot<T> OnChangedNotNull(UnityAction<T> onChanged) {
            var slot = new Slot<T>();
            slot.OnChangedNotNull(onChanged);
            return slot;
        }

        public static Slot<T> Listen(UnityEvent unityEvent, UnityAction action) {
            var slot = new Slot<T>();
            slot.Listen(unityEvent, action);
            return slot;
        }

        public static Slot<T> ListenAndInvoke(UnityEvent unityEvent, UnityAction action) {
            var slot = new Slot<T>();
            slot.ListenAndInvoke(unityEvent, action);
            return slot;
        }

        public static Slot<T> Listen<A>(UnityEvent<A> unityEvent, UnityAction<A> action) {
            var slot = new Slot<T>();
            slot.Listen(unityEvent, action);
            return slot;
        }

        public static Slot<T> ListenAndInvoke<A>(UnityEvent<A> unityEvent, UnityAction<A> action, A initialValue) {
            var slot = new Slot<T>();
            slot.ListenAndInvoke(unityEvent, action, initialValue);
            return slot;
        }

        public static Slot<T> Listen<A, B>(UnityEvent<A, B> unityEvent, UnityAction<A, B> action) {
            var slot = new Slot<T>();
            slot.Listen(unityEvent, action);
            return slot;
        }

        public static Slot<T> ListenAndInvoke<A, B>(UnityEvent<A, B> unityEvent, UnityAction<A, B> action, A first, B second) {
            var slot = new Slot<T>();
            slot.ListenAndInvoke(unityEvent, action, first, second);
            return slot;
        }

        public static Slot<T> Listen<A, B, C>(UnityEvent<A, B, C> unityEvent, UnityAction<A, B, C> action) {
            var slot = new Slot<T>();
            slot.Listen(unityEvent, action);
            return slot;
        }

        public static Slot<T> ListenAndInvoke<A, B, C>(UnityEvent<A, B, C> unityEvent, UnityAction<A, B, C> action, A first, B second, C third) {
            var slot = new Slot<T>();
            slot.ListenAndInvoke(unityEvent, action, first, second, third);
            return slot;
        }

        public static Slot<T> Listen<A, B, C, D>(UnityEvent<A, B, C, D> unityEvent, UnityAction<A, B, C, D> action) {
            var slot = new Slot<T>();
            slot.Listen(unityEvent, action);
            return slot;
        }

        public static Slot<T> ListenAndInvoke<A, B, C, D>(UnityEvent<A, B, C, D> unityEvent, UnityAction<A, B, C, D> action, A first, B second, C third, D fourth) {
            var slot = new Slot<T>();
            slot.ListenAndInvoke(unityEvent, action, first, second, third, fourth);
            return slot;
        }
    }
}