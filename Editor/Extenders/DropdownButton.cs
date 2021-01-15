using UnityEditor;
using UnityEditor.IMGUI.Controls;
using UnityEngine;
namespace Lunari.Tsuki.Editor.Extenders {
    public class DropdownButton {
        private Rect lastRect;
        private readonly AdvancedDropdown dropdown;
        public DropdownButton(AdvancedDropdown dropdown) {
            this.dropdown = dropdown;
            
        }
        public void OnGUI() {
            var r = EditorGUILayout.DropdownButton(new GUIContent("Select Texture"), FocusType.Passive);
            if (Event.current.type == EventType.Repaint) {
                lastRect = GUILayoutUtility.GetLastRect();
            }

            if (r) {
                dropdown.Show(lastRect);
            }
        }
    }
}