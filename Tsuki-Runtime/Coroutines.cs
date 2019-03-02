using System.Collections;
using UnityEngine;

namespace Lunari.Tsuki {
    public static class Coroutines {
        /// <summary>
        /// If the provided coroutine is not null, cancels that, and start a new coroutine, replacing the old one. 
        /// </summary>
        /// <param name="coroutine">The address of the old routine</param>
        /// <param name="owner">The <see cref="MonoBehaviour"/> the coroutine should be hosted on</param>
        /// <param name="newRoutine">The method to use for the new coroutine</param>
        public static void ReplaceCoroutine(ref Coroutine coroutine, MonoBehaviour owner, IEnumerator newRoutine) {
            coroutine.StopIfNotNull(owner);
            coroutine = owner.StartCoroutine(newRoutine);
        }

        public static void StopIfNotNull(this Coroutine coroutine, MonoBehaviour owner) {
            coroutine?.Stop(owner);
        }

        public static void Stop(this Coroutine coroutine, MonoBehaviour owner) {
            owner.StopCoroutine(coroutine);
        }
    }
}