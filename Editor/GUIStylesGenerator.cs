using System.IO;
using System.Text;
using UnityEditor;
using UnityEngine;

namespace Lunari.Tsuki.Editor {
    public class GUIStylesGenerator {
        public const string GUIStylesPath = "Assets/Editor/GUIStyles.cs";

        private static void AddSkinText(StringBuilder builder, string key, EditorSkin skin) {
            builder.Append("public static GUIStyle ");
            builder.Append(key);
            builder.Append("_");
            builder.Append(skin.ToString());
            builder.Append(" => Get(");
            builder.Append(key);
            builder.Append(", EditorSkin.");
            builder.Append(skin);
            builder.Append(");");
            builder.AppendLine();
        }

        [MenuItem("Tsuki/Generate GUI Styles")]
        public static void Generate() {
            var str = new StringBuilder();
            str.AppendLine("#if UNITY_EDITOR")
                .AppendLine("using UnityEditor;")
                .AppendLine("using UnityEngine;")
                .AppendLine()
                .AppendLine("// ReSharper disable UnusedMember.Global")
                .AppendLine("// ReSharper disable InconsistentNaming")
                .AppendLine()
                .AppendLine("namespace Lunari.Tsuki.Editor {")
                .AppendLine("public static class GUIStyles {")
                .AppendLine("public static GUIStyle Get(string key, EditorSkin skin = EditorSkin.Inspector) {")
                .AppendLine("return EditorGUIUtility.GetBuiltinSkin(skin).FindStyle(key);")
                .AppendLine("}");
            foreach (var o in EditorGUIUtility.GetBuiltinSkin(EditorSkin.Inspector)) {
                var style = (GUIStyle) o;
                str.Append("public const string ");
                var fieldName = style.name.Replace(' ', '_').Replace('.', '_');
                str.Append(fieldName);
                str.Append(" = ");
                str.Append('"');
                str.Append(style.name);
                str.Append('"');
                str.AppendLine(";");
                AddSkinText(str, fieldName, EditorSkin.Game);
                AddSkinText(str, fieldName, EditorSkin.Inspector);
                AddSkinText(str, fieldName, EditorSkin.Scene);
            }

            str.AppendLine("}");
            str.AppendLine("}");
            str.AppendLine("#endif");
            var finalPath = Path.GetFullPath(GUIStylesPath);
            Debug.Log($"Generated to {finalPath}");
            File.WriteAllText(finalPath, str.ToString());
        }
    }
}