using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
namespace Lunari.Tsuki.Misc {
    public sealed class Tracker<T> where T : Object {
        private readonly List<T> objects = new List<T>();

        public Tracker(
            UnityEvent<T> awakeEvent,
            UnityEvent<T> destroyEvent
        ) {
            awakeEvent.AddListener(OnAwake);
            destroyEvent.AddListener(OnDestroy);
            objects.AddRange(Object.FindObjectsOfType<T>());
        }

        public IEnumerable<T> Objects => objects;

        private void OnDestroy(T arg0) {
            objects.Remove(arg0);
        }

        private void OnAwake(T arg0) {
            objects.Add(arg0);
        }
    }
}