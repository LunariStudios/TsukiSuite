using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using UnityEditor;
using UnityEngine;

namespace Lunari.Tsuki.Editor {
    public static class StylesGenerator {
        public const string StylesPath = "Assets/Editor/Styles.cs";

        private static void AddSkinText(StringBuilder builder, string key, EditorSkin skin) {
            builder.Append("public static GUIStyle ");
            builder.Append(key);
            builder.Append(" => Styles.Get(Keys.");
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
                .AppendLine("public static class Styles {")
                .AppendLine("public static GUIStyle Get(string key, EditorSkin skin = EditorSkin.Inspector) {")
                .AppendLine("return EditorGUIUtility.GetBuiltinSkin(skin).FindStyle(key);")
                .AppendLine("}");
            var fieldNameToKey = new Dictionary<string, string>();
            var guiSkins = EditorGUIUtility.GetBuiltinSkin(EditorSkin.Inspector);
            foreach (var o in guiSkins) {
                var style = (GUIStyle)o;
                var fieldName = style.name.Replace(' ', '_').Replace('.', '_');
                fieldNameToKey[fieldName] = style.name;
            }
            foreach (var pair in fieldNameToKey) {
                str.Append("public static GUIStyle ");
                str.Append(pair.Key);
                str.Append(" => ");
                str.Append("Keys.");
                str.Append(pair.Key);
                str.AppendLine(";");
            }
            str.AppendLine("public static class Keys {");
            foreach (var pair in fieldNameToKey){
                str.Append("public const string ");
                str.Append(pair.Key);
                str.Append(" = ");
                str.Append('"');
                str.Append(pair.Value);
                str.Append('"');
                str.AppendLine(";");
            }
            str.AppendLine("}");
            foreach (var editorSkin in new[] {
                EditorSkin.Game, EditorSkin.Inspector, EditorSkin.Scene
            }) {
                str.AppendLine($"public static class {editorSkin} {{");
                foreach (var o in fieldNameToKey) {
                    AddSkinText(str, o.Key, editorSkin);
                }
                str.AppendLine("}");
            }

            str.AppendLine("}");
            str.AppendLine("}");
            str.AppendLine("#endif");
            var finalPath = Path.GetFullPath(StylesPath);
            Debug.Log($"Generated to {finalPath}");
            File.WriteAllText(finalPath, str.ToString());
        }
    }
}