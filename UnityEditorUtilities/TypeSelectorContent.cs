using System;
using System.Collections.Generic;
using System.Linq;
using UnityEditor;
using UnityEngine;

namespace UnityUtilities.Editor {
    public class TypeSelectorContent<T> : PopupWindowContent {
        public const string DefaultNoElementsFoundMessage = "No items found :(";
        private readonly Action<Type> onTypeSelected;
        private readonly IList<Type> types;
        private readonly Func<float> widthCalculator;
        private readonly string noElementsFoundMessage;

        public TypeSelectorContent(Func<float> widthCalculator, Action<Type> onTypeSelected,
            string noElementsFoundMessage = DefaultNoElementsFoundMessage) {
            this.onTypeSelected = onTypeSelected;
            this.widthCalculator = widthCalculator;
            this.noElementsFoundMessage = noElementsFoundMessage;
            types = TypeUtility.GetAllTypesOf<T>().ToList();
        }

        public override Vector2 GetWindowSize() {
            var width = widthCalculator();
            float height;
            if (types.IsEmpty()) {
                height = EditorGUIUtility.singleLineHeight;
            } else {
                height = types.Count * EditorGUIUtility.singleLineHeight;
            }

            return new Vector2(width, height);
        }

        public override void OnGUI(Rect rect) {
            if (types.IsEmpty()) {
                EditorGUILayout.LabelField(noElementsFoundMessage, EditorStyles.boldLabel);
                return;
            }

            foreach (var type in types) {
                DrawType(type);
            }
        }

        private void DrawType(Type type) {
            if (GUILayout.Button(type.Name)) {
                onTypeSelected(type);
            }
        }
    }
}