using UnityEditor;
using UnityEditor.IMGUI.Controls;
using UnityEngine;
namespace Lunari.Tsuki.Editor.Extenders {
    public class DropdownButton {
        private Rect lastRect;
        private readonly AdvancedDropdown dropdown;

        public GUIContent Label {
            get;
            set;
        }

        public DropdownButton(AdvancedDropdown dropdown, GUIContent label) {
            this.dropdown = dropdown;
            Label = label;

        }
        public void OnGUI() {
            var r = EditorGUILayout.DropdownButton(Label, FocusType.Passive);
            if (Event.current.type == EventType.Repaint) {
                lastRect = GUILayoutUtility.GetLastRect();
            }

            if (r) {
                dropdown.Show(lastRect);
            }
        }
    }
}