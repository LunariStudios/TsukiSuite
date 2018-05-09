using System.Collections;
using UnityEngine;

namespace UnityUtilities {
    public static class CoroutineUtility {
        public static void ReplaceCoroutine(ref Coroutine coroutine, MonoBehaviour owner, IEnumerator newRoutine) {
            coroutine.StopIfNotNull(owner);
            coroutine = owner.StartCoroutine(newRoutine);
        }

        public static void StopIfNotNull(this Coroutine coroutine, MonoBehaviour owner) {
            if (coroutine != null) {
                coroutine.Stop(owner);
            }
        }

        public static void Stop(this Coroutine coroutine, MonoBehaviour owner) {
            owner.StopCoroutine(coroutine);
        }
    }
}