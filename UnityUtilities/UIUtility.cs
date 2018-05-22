using UnityEngine.UI;

namespace UnityUtilities {
    public static class UIUtility {
        public static void SetAlpha(this Graphic graphic, float alpha) {
            var c = graphic.color;
            c.a = alpha;
            graphic.color = c;
        }

        public static void SetRed(this Graphic graphic, float red) {
            var c = graphic.color;
            c.r = red;
            graphic.color = c;
        }

        public static void SetGreen(this Graphic graphic, float green) {
            var c = graphic.color;
            c.g = green;
            graphic.color = c;
        }

        public static void SetBlue(this Graphic graphic, float blue) {
            var c = graphic.color;
            c.b = blue;
            graphic.color = c;
        }

        public static void SetHue(this Graphic graphic, float hue) {
            var c = graphic.color;
            ColorUtility.SetHue(ref c, hue);
            graphic.color = c;
        }

        public static void SetSaturation(this Graphic graphic, float saturation) {
            var c = graphic.color;
            ColorUtility.SetSaturation(ref c, saturation);
            graphic.color = c;
        }

        public static void SetBrightness(this Graphic graphic, float brightness) {
            var c = graphic.color;
            ColorUtility.SetBrightness(ref c, brightness);
            graphic.color = c;
        }
    }
}