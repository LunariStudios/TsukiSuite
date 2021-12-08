using System;
using System.Collections.Generic;
using System.Reflection;
using UnityEditor;
using UnityEngine;

namespace Lunari.Tsuki.Editor {
    public static class Editing {
        private static readonly MethodInfo GetIconMethod = typeof(EditorGUIUtility).GetMethod("FindTextureByType", BindingFlags.Static | BindingFlags.NonPublic);

        public static Texture FindUnityIcon(this Type type, string defaultIcon = Icons.Keys.processed_dll_script_icon_asset) {
            Texture tex = AssetPreview.GetMiniTypeThumbnail(type);
            if (tex == null) {
                tex = GetIconMethod.Invoke(null, new object[] { type }) as Texture;
            }
            if (tex == null) {
                tex = EditorGUIUtility.IconContent(defaultIcon).image;
            }
            return tex;
        }
    }
    public static class TsukiGUILayout {

        public static void Icon(Texture texture, float size) {
            var rect = EditorGUILayout.GetControlRect(false, size, GUILayout.Width(size));
            GUI.DrawTexture(rect, texture);
        }

        public static void Texture(Texture texture) {
            Texture(texture, new Vector2(texture.width, texture.height));
        }
        public static void Texture(Texture texture, Vector2 textureSize) {
            var rect = EditorGUILayout.GetControlRect(false, GUILayout.Width(textureSize.x), GUILayout.Height(textureSize.y));
            GUI.DrawTexture(rect, texture);
        }
        public static void Table<T>(int numColumns, IEnumerable<T> elements, Func<T, bool> drawer) {
            var index = 0;
            EditorGUILayout.BeginHorizontal();
            foreach (var o in elements) {

                if (!drawer(o)) {
                    continue;
                }
                if (++index == numColumns) {
                    index = 0;
                    EditorGUILayout.EndHorizontal();
                    EditorGUILayout.BeginHorizontal();
                }

            }
            EditorGUILayout.EndHorizontal();
        }
        public static bool Foldout(bool shown, GUIContent label, GUIStyle value) {
            const float foldoutHeight = 24;
            var rect = GUILayoutUtility.GetRect(0, float.MaxValue, foldoutHeight, foldoutHeight);
            if (Event.current.type == EventType.Repaint) {
                var labelRect = rect.AddXMin(16);
                GUI.Label(labelRect, label);
                
                value.Draw(rect, false, true, true, true);
            }

            if (Event.current.type == EventType.MouseDown) {
                if (rect.Contains(Event.current.mousePosition)) {
                    return !shown;
                }
            }
            return shown;
        }
    }
}