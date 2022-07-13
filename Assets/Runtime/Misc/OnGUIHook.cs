using System;
using UnityEngine;
using UnityEngine.Events;

namespace Lunari.Tsuki.Misc {
    public class OnGUIHook : MonoBehaviour {
        public UnityEvent onGUI = new UnityEvent();

        private void OnGUI() {
            onGUI.Invoke();
        }
    }
}