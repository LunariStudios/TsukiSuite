using UnityEngine.UI;

namespace UnityUtilities {
    public static class UIUtility {
        public static void SetAlpha(this Graphic graphic, float alpha) {
            var c = graphic.color;
            c.a = alpha;
            graphic.color = c;
        }
    }
}