using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using UnityEditor;
using UnityEngine;
namespace Lunari.Tsuki.Editor {
    public static class IconsGenerator {
        public const string IconsPath = "Assets/Editor/Icons.cs";
        public static IEnumerable<string> GetAllIcons() {
            var editorAssetBundle = GetEditorAssetBundle();
            var iconsPath = GetIconsPath();
            return EnumerateIcons(editorAssetBundle, iconsPath);
        }

        [MenuItem("Tools/Tsuki/Generate GUI Icons")]
        private static void Generate() {
            var assetNames = GetAllIcons().ToArray();
            var str = new StringBuilder();
            str.AppendLine("#if UNITY_EDITOR")
                .AppendLine("using UnityEditor;")
                .AppendLine("using UnityEngine;")
                .AppendLine()
                .AppendLine("// ReSharper disable UnusedMember.Global")
                .AppendLine("// ReSharper disable InconsistentNaming")
                .AppendLine()
                .AppendLine("namespace Lunari.Tsuki.Editor {")
                .AppendLine("public static class Icons {");
            var pathToField = new Dictionary<string, string>();
            for (var i = 0; i < assetNames.Length; i++) {
                var name = assetNames[i];

                pathToField[name] = name
                    .Replace("icons/", string.Empty)
                    .Replace(".png", string.Empty)
                    .Replace("@", "_")
                    .Replace(' ', '_')
                    .Replace('-', '_')
                    .Replace('.', '_')
                    .Replace('/', '_');
            }
            foreach (var pair in pathToField) {
                var name = pair.Key;

                var fieldName = pair.Value;
                str.AppendLine($"public static Texture {fieldName} => Content.{fieldName}.image;");
            }

            str.AppendLine("public static class Keys {");

            foreach (var pair in pathToField) {
                var name = pair.Key;
                var fieldName = pair.Value;
                str.AppendLine($"public const string {fieldName} = \"{name}\";");
            }
            str.AppendLine("}");
            str.AppendLine("public static class Content {");
            foreach (var pair in pathToField) {
                var fieldName = pair.Value;
                str.AppendLine($"public static GUIContent {fieldName} => EditorGUIUtility.IconContent(Keys.{fieldName});");
            }

            str.AppendLine("}");
            str.AppendLine("public static class ContentWithText {");
            foreach (var pair in pathToField) {
                var fieldName = pair.Value;
                str.AppendLine($"public static GUIContent {fieldName}(string text) => EditorGUIUtility.IconContent(Keys.{fieldName}, text);");
            }

            str.AppendLine("}");
            str.AppendLine("}");
            str.AppendLine("}");
            str.AppendLine("#endif");

            var finalPath = Path.GetFullPath(IconsPath);
            Debug.Log($"Generated to {finalPath}");
            File.WriteAllText(finalPath, str.ToString());
        }

        private static IEnumerable<string> EnumerateIcons(AssetBundle editorAssetBundle, string iconsPath) {
            foreach (var assetName in editorAssetBundle.GetAllAssetNames()) {
                if (assetName.StartsWith(iconsPath, StringComparison.OrdinalIgnoreCase) == false) {
                    continue;
                }
                if (assetName.EndsWith(".png", StringComparison.OrdinalIgnoreCase) == false &&
                    assetName.EndsWith(".asset", StringComparison.OrdinalIgnoreCase) == false) {
                    continue;
                }

                yield return assetName;
            }
        }

        private static AssetBundle GetEditorAssetBundle() {
            var editorGUIUtility = typeof(EditorGUIUtility);
            var getEditorAssetBundle = editorGUIUtility.GetMethod(
                "GetEditorAssetBundle",
                BindingFlags.NonPublic | BindingFlags.Static);

            return (AssetBundle)getEditorAssetBundle.Invoke(null, new object[] { });
        }

        private static string GetIconsPath() {
            return UnityEditor.Experimental.EditorResources.iconsPath;

        }
    }
}