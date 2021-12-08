using System.Text;
using UnityEditor;
using UnityEngine;
namespace Lunari.Tsuki.Editor.Utilities {
    public static class GUIStyleExtraction {
        private static void PushIndent(this StringBuilder builder, int count = 1) {
            builder.Append(' ', 4 * count);
        }
        public static string ExtractGUIStyleCSharpSource(GUIStyle style) {
            var states = GetStyleStateNamePairs(style);
            var properties = new[] {
                (nameof(style.alignment), $"TextAnchor.{style.alignment}"),
                (nameof(style.border), ConstructBorder(style.border)),
                (nameof(style.clipping), $"TextClipping.{style.clipping}"),
                (nameof(style.contentOffset), $"new Vector2({style.contentOffset.x}, {style.contentOffset.y})"),
                (nameof(style.fixedHeight), $"{style.fixedHeight}F"),
                (nameof(style.fixedWidth), $"{style.fixedWidth}F"),
                (nameof(style.margin), ConstructBorder(style.margin)),
                (nameof(style.padding), ConstructBorder(style.padding)),
                (nameof(style.overflow), ConstructBorder(style.overflow)),
                (nameof(style.imagePosition), $"ImagePosition.{style.imagePosition}"),
                (nameof(style.font), GetLoaderFor(style.font)),
                (nameof(style.fontSize), style.fontSize.ToString()),
                (nameof(style.fontStyle), $"FontStyle.{style.fontStyle}"),
                (nameof(style.richText), style.richText.ToString().ToLower()),
                (nameof(style.wordWrap), style.wordWrap.ToString().ToLower()),
                (nameof(style.stretchHeight), style.stretchHeight.ToString().ToLower()),
                (nameof(style.stretchWidth), style.stretchWidth.ToString().ToLower())
            };

            var builder = new StringBuilder();
            builder.AppendLine($"new GUIStyle {{");

            string GetLoaderFor<T>(T obj) where T : UnityEngine.Object {
                if (obj == null) {
                    return "null";
                }
                return $"EditorResources.Load<{typeof(T).Name}>(\"{obj.name}\")";
            }

            foreach (var (propertyName, property) in properties) {
                builder.PushIndent();
                builder.AppendLine($"{propertyName} = {property},");

            }
            foreach (var (stateName, state) in states) {
                builder.PushIndent();
                builder.AppendLine($"{stateName} = new GUIStyleState {{");
                var stateTextColor = state.textColor;
                builder.PushIndent(2);
                builder.AppendLine($"textColor = new Color({stateTextColor.r}F, {stateTextColor.g}F, {stateTextColor.b}F, {stateTextColor.a}F),");
                if (state.background != null) {
                    builder.PushIndent(2);
                    builder.AppendLine($"background = {GetLoaderFor(state.background)},");
                }
                var scaled = state.scaledBackgrounds;
                if (scaled.Length > 0) {
                    builder.PushIndent(2);
                    builder.AppendLine("scaledBackgrounds = new Texture2D[] {");
                    foreach (var stateScaledBackground in scaled) {
                        builder.PushIndent(3);
                        builder.AppendLine(GetLoaderFor(stateScaledBackground));
                    }
                    builder.PushIndent(2);
                    builder.AppendLine($"}}");
                }
                builder.PushIndent(1);
                builder.AppendLine($"}},");
            }
            builder.AppendLine("}");
            var msg = builder.ToString();
            return msg;
        }
        public static (string, GUIStyleState)[] GetStyleStateNamePairs(GUIStyle style) {
            return new[] {
                (nameof(style.normal), style.normal),
                (nameof(style.onNormal), style.onNormal),
                (nameof(style.hover), style.hover),
                (nameof(style.onHover), style.onHover),
                (nameof(style.active), style.active),
                (nameof(style.onActive), style.onActive),
                (nameof(style.focused), style.focused),
                (nameof(style.onFocused), style.onFocused)
            };
        }
        private static string ConstructBorder(RectOffset styleBorder) {
            return $"new RectOffset({styleBorder.left}, {styleBorder.right}, {styleBorder.top}, {styleBorder.bottom})";
        }
    }
}