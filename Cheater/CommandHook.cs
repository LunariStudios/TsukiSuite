using System;
using UnityEngine;
namespace Lunari.Tsuki.Cheater {
    public class CommandHook : MonoBehaviour {
        private CommandWindow window;
        private void OnGUI() {
            window?.OnGUI();
        }

        public void Setup(CommandWindow commandWindow) {
            window = commandWindow;
        }
    }
}