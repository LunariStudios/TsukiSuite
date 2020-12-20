using Lunari.Tsuki.Runtime;
using Lunari.Tsuki.Runtime.Misc;
using UnityEditor;
using UnityEngine;

namespace Lunari.Tsuki.Editor.Drawers {
    [CustomPropertyDrawer(typeof(Clock))]
    public class ClockDrawer : PropertyDrawer {
        private bool open = true;

        public override float GetPropertyHeight(SerializedProperty property, GUIContent label) {
            return Rectangles.GetHeight(open ? 3 : 1);
        }

        public override void OnGUI(Rect position, SerializedProperty property, GUIContent label) {
            var cooldown = property.FindPropertyRelative(nameof(Clock.cooldown));
            open = EditorGUI.Foldout(position.GetLine(0), open, label);
            if (!open) {
                return;
            }

            using (new EditorGUI.IndentLevelScope()) {
                EditorGUI.PropertyField(position.GetLine(1), cooldown);
                cooldown.floatValue =
                    1 / EditorGUI.FloatField(position.GetLine(2), "Tick Rate", 1 / cooldown.floatValue);
            }
        }
    }
}