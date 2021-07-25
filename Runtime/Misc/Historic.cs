using UnityEngine;
using System;
#if ODIN_INSPECTOR
using Sirenix.OdinInspector;

#endif

namespace Lunari.Tsuki.Runtime.Misc {
    /// <summary>
    /// Container for a value that also stores the last set value;
    /// </summary>
    [Serializable]
    public class Historic<T> {
        [SerializeField, NonSerialized] protected T current;
        protected T last;
#if ODIN_INSPECTOR
        [ShowInInspector]
#endif
        public T Current {
            get => current;
            set {
                last = current;
                current = value;
            }
        }

        public static implicit operator T(Historic<T> value) {
            return value.current;
        }
    }

    [Serializable]
    public class BooleanHistoric : Historic<bool> {
        public bool JustActivated => current && !last;
        public bool JustDeactivated => !current && last;
    }

    public static class Historics {
        public static void CopyCurrentToLast<T>(this Historic<T> historic) {
            historic.Current = historic.Current;
        }
    }
}