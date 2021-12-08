using Lunari.Tsuki.Editor.Utilities;
using UnityEditor;
using UnityEngine;
namespace Lunari.Tsuki.Editor.Windows {
    public class GUIStyleInspector : EditorWindow {
        private GUIStyle style;
        private string csharpSource;
        private Vector2 scroll;
        public void SetStyle(GUIStyle newStyle) {
            style = newStyle;
            if (newStyle == null) {
                return;
            }
            csharpSource = GUIStyleExtraction.ExtractGUIStyleCSharpSource(newStyle);
        }
        private void OnProjectChange() {
            if (style != null) {
                csharpSource = GUIStyleExtraction.ExtractGUIStyleCSharpSource(style);
            }
        }
        private void OnGUI() {
            if (style == null) {
                return;
            }
            using (var scope = new EditorGUILayout.ScrollViewScope(scroll)) {
                EditorGUILayout.LabelField(style.name, Styles.BoldLabel);
                TsukiGUILayout.Table(
                    2,
                    GUIStyleExtraction.GetStyleStateNamePairs(style),
                    tuple => {
                        var (stateName, state) = tuple;
                        DrawStateInfo(stateName, state);
                        return true;
                    }
                );
                using (new EditorGUILayout.HorizontalScope()) {
                    EditorGUILayout.LabelField("Actions");
                    if (GUILayout.Button("Copy CSharp Source")) {
                        EditorGUIUtility.systemCopyBuffer = csharpSource;
                    }
                }
                EditorGUILayout.TextArea(csharpSource);
                scroll = scope.scrollPosition;
            }
        }
        private static void DrawStateInfo(string stateName, GUIStyleState state) {
            using (new EditorGUILayout.VerticalScope(Styles.box)) {
                EditorGUILayout.LabelField(stateName, Styles.BoldLabel);
                EditorGUILayout.ColorField("Text Color", state.textColor);
                if (state.background != null) {
                    DrawTextureInfo("Background", state.background);
                }
                var scaled = state.scaledBackgrounds;
                if (scaled != null && scaled.Length > 0) {
                    EditorGUILayout.LabelField("ScaledBackgrounds(Size: " + scaled.Length + ")");
                    using (new EditorGUI.IndentLevelScope()) {
                        for (var i = 0; i < scaled.Length; i++) {
                            var stateScaledBackground = scaled[i];
                            DrawTextureInfo($"ScaledBackgrounds[{i}]", stateScaledBackground);
                        }
                    }
                }
            }
        }
        private static void DrawTexture(string header, Texture2D t) {
            EditorGUILayout.ObjectField(
                header,
                t,
                typeof(Texture2D),
                false
            );
        }
        private static void DrawTextureInfo(string header, Texture2D texture) {
            using (new EditorGUILayout.HorizontalScope()) {
                using (new EditorGUILayout.VerticalScope()) {
                    EditorGUILayout.LabelField(header, texture.name);
                    using (new EditorGUI.IndentLevelScope()) {
                        var path = AssetDatabase.GetAssetPath(texture);
                        EditorGUILayout.LabelField("Path", path);
                        // DrawTexture("Resources", EditorResources.Load<Texture2D>(texture.name));
                        // DrawTexture("Resources", EditorResources.Load<Texture2D>($"{path}/{texture.name}"));

                    }
                }
                TsukiGUILayout.Texture(texture);

            }
          

        }
    }
}