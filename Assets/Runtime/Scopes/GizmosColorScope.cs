using System;
using UnityEngine;

namespace Lunari.Tsuki.Runtime.Scopes {
    public class GizmosColorScope : IDisposable {
        private Color fallback;

        public GizmosColorScope(Color newColor) {
            fallback = Gizmos.color;
            Gizmos.color = newColor;
        }

        public void Dispose() {
            Gizmos.color = fallback;
        }
    }
}