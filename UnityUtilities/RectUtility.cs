using UnityEngine;

namespace UnityUtilities {
    public static class RectUtility {
        public const float DefaultLineHeight = 16;

        public static Rect GetLine(this Rect rect, uint lineIndex, float lineHeight = DefaultLineHeight) {
            var r = rect;
            r.height = lineHeight;
            r.y += lineIndex * lineHeight;
            return r;
        }

        public static Rect GetColumn(this Rect rect, uint columnIndex, float columnWidth) {
            var r = rect;
            r.width = columnWidth;
            r.x += columnIndex * columnWidth;
            return r;
        }
    }
}