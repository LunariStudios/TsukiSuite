using System;
using Lunari.Tsuki.Editor.Utilities;
using UnityEditor;
using UnityEngine;
using UnityEngine.Events;
namespace Lunari.Tsuki.Editor.Extenders {
    public delegate void RectModifier(ref Rect rect);
    public sealed class TypeSelectorButton<T> {
        private Rect lastRect;
        private readonly TypeSelectorDropdown<T> selector;
        private readonly ModularContent<GUIContent> guiContent;
        public event RectModifier RectCalculated;

        public TypeSelectorButton(
            ModularContent<GUIContent> guiContent,
            TypeSelectorDropdown<T>.OnSelectedCallback onTypeSelected,
            TypeSelectorDropdown<T>.PathSelector groupSelector = null,
            Predicate<Type> typeFilter = null
        ) {
            this.guiContent = guiContent;
            selector = new TypeSelectorDropdown<T>(onTypeSelected, groupSelector, typeFilter);
        }

        public void OnInspectorGUI() {
            var r = EditorGUILayout.DropdownButton(guiContent.Content, FocusType.Passive);
            if (Event.current.type == EventType.Repaint) {
                lastRect = GUILayoutUtility.GetLastRect();
                RectCalculated?.Invoke(ref lastRect);
            }

            if (r) {
                selector.Show(lastRect);
            }
        }
    }
}