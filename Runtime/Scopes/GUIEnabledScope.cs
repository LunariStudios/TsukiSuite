using System;
using UnityEngine;
namespace Lunari.Tsuki.Scopes {
    public class GUIEnabledScope : IDisposable {
        private bool before;

        public GUIEnabledScope(bool enabled) {
            before = GUI.enabled;
            GUI.enabled = enabled;
        }

        public void Dispose() {
            GUI.enabled = before;
        } 
    }
}