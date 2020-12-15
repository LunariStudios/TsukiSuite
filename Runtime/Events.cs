using System;
using UnityEngine.Events;

namespace Lunari.Tsuki.Runtime {
    public static class Events {
        public static UnityAction AddListenerAndInvoke(this UnityEvent unityEvent, UnityAction action) {
            unityEvent.AddListener(action);
            action();
            return action;
        }

        public static UnityAction AddSingleFireListener(this UnityEvent unityEvent, UnityAction action) {
            void Callback() {
                action();
                unityEvent.RemoveListener(Callback);
            }

            unityEvent.AddListener(Callback);
            return action;
        }

        public static UnityAction<T> AddSingleFireListener<T>(this UnityEvent<T> unityEvent, UnityAction<T> action) {
            void Callback(T value) {
                action(value);
                unityEvent.RemoveListener(Callback);
            }

            unityEvent.AddListener(Callback);
            return action;
        }

        public static DisposableListener AddDisposableListener(
            this UnityEvent unityEvent,
            UnityAction action
        ) => new DisposableListener(unityEvent, action);

        public static DisposableListener AddDisposableListenerAndInvoke(
            this UnityEvent unityEvent,
            UnityAction action
        ) {
            var ev = unityEvent.AddDisposableListener(action);
            action();
            return ev;
        }

        public static DisposableListener<T> AddDisposableListener<T>(
            this UnityEvent<T> unityEvent,
            UnityAction<T> action
        ) => new DisposableListener<T>(unityEvent, action);
    }

    public abstract class BaseDisposableListener<E, A> : IDisposable where E : UnityEventBase {
        protected readonly E unityEvent;
        protected readonly A unityAction;
        protected A current;
        public readonly UnityEvent onDispose = new UnityEvent();

        protected BaseDisposableListener(E unityEvent, A unityAction) {
            this.unityEvent = unityEvent;
            this.unityAction = unityAction;
            FireMultiple();
        }

        public void Dispose() {
            TryRemove();
            onDispose.Invoke();
            onDispose.RemoveAllListeners();
        }

        private void TryRemove() {
            if (current != null) {
                Remove();
            }
        }

        protected abstract void Remove();

        public BaseDisposableListener<E, A> DisposeOn(UnityEvent other) {
            other.AddSingleFireListener(Dispose);
            onDispose.AddListener(() => other.RemoveListener(Dispose));
            return this;
        }


        public BaseDisposableListener<E, A> DisposeOn<T>(UnityEvent<T> other) {
            var listener = other.AddSingleFireListener(delegate { Dispose(); });
            onDispose.AddListener(() => other.RemoveListener(listener));
            return this;
        }

        public BaseDisposableListener<E, A> DisposeOnIf(UnityEvent other, Func<bool> predicate) {
            var listener = other.AddSingleFireListener(delegate {
                if (predicate()) {
                    Dispose();
                }
            });
            onDispose.AddListener(() => other.RemoveListener(listener));
            return this;
        }

        public BaseDisposableListener<E, A> FireOnce() {
            TryRemove();
            current = MakeFireOnce();
            return this;
        }

        public BaseDisposableListener<E, A> FireMultiple() {
            TryRemove();
            current = MakeFireNormally();
            return this;
        }

        protected abstract A MakeFireOnce();
        protected abstract A MakeFireNormally();

        public BaseDisposableListener<E, A> DisposeOnIf<T>(UnityEvent<T> other, Predicate<T> predicate) {
            var listener = other.AddSingleFireListener(delegate(T arg0) {
                if (predicate(arg0)) {
                    Dispose();
                }
            });
            onDispose.AddListener(() => other.RemoveListener(listener));
            return this;
        }

        public BaseDisposableListener<E, A> DisposeOn(params UnityEvent[] others) {
            foreach (var other in others) {
                DisposeOn(other);
            }

            return this;
        }

        public BaseDisposableListener<E, A> OnDispose(UnityAction action) {
            onDispose.AddListener(action);
            return this;
        }
    }

    public class DisposableListener : BaseDisposableListener<UnityEvent, UnityAction> {
        protected override void Remove() {
            unityEvent.RemoveListener(current);
        }

        protected override UnityAction MakeFireOnce() {
            return unityEvent.AddSingleFireListener(unityAction);
        }

        protected override UnityAction MakeFireNormally() {
            unityEvent.AddListener(unityAction);
            return unityAction;
        }

        public DisposableListener(
            UnityEvent unityEvent,
            UnityAction unityAction
        ) : base(unityEvent, unityAction) { }
    }

    public class DisposableListener<T> : BaseDisposableListener<UnityEvent<T>, UnityAction<T>> {
        protected override void Remove() {
            unityEvent.RemoveListener(current);
        }

        protected override UnityAction<T> MakeFireOnce() {
            return unityEvent.AddSingleFireListener(unityAction);
        }

        protected override UnityAction<T> MakeFireNormally() {
            unityEvent.AddListener(unityAction);
            return unityAction;
        }

        public DisposableListener(
            UnityEvent<T> unityEvent,
            UnityAction<T> unityAction
        ) : base(unityEvent, unityAction) { }
    }
}