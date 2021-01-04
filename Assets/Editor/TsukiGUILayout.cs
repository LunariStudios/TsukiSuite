using System;
using System.Reflection;
using UnityEditor;
using UnityEngine;
namespace Lunari.Tsuki.Editor {
    public static class Editing {
        private static readonly MethodInfo GetIconMethod = typeof(EditorGUIUtility).GetMethod("FindTextureByType", BindingFlags.Static | BindingFlags.NonPublic);

        public static Texture FindUnityIcon(this Type type, string defaultIcon = Icons.Keys.processed_dll_script_icon_asset) {
            Texture tex = AssetPreview.GetMiniTypeThumbnail(type);
            if (tex == null) {
                tex = GetIconMethod.Invoke(null, new object[] {type}) as Texture;
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

    }
}