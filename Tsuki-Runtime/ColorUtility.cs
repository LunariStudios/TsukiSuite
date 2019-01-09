using UnityEngine;

namespace Lunari.Tsuki {
    public static class ColorUtility {
        public static Color Random(float alpha = 1) {
            return new Color(
                UnityEngine.Random.value,
                UnityEngine.Random.value,
                UnityEngine.Random.value,
                alpha
            );
        }

        /// <summary>
        /// Copies this color, and return a new color with the modified brightness set to <see cref="brightness"/>
        /// </summary>
        /// <param name="color">The color to copy from</param>
        /// <param name="brightness">The new brightness</param>
        /// <returns></returns>
        public static Color SetBrightness(this Color color, float brightness) {
            var c = color;
            SetBrightness(ref c, brightness);
            return c;
        }

        /// <summary>
        /// Copies this color, and return a new color with the modified saturation set to <see cref="saturation"/>
        /// </summary>
        /// <param name="color">The color to copy from</param>
        /// <param name="saturation">The new saturation</param>
        /// <returns></returns>
        public static Color SetSaturation(this Color color, float saturation) {
            var c = color;
            SetSaturation(ref c, saturation);
            return c;
        }

        /// <summary>
        /// Copies this color, and return a new color with the modified hue set to <see cref="hue"/>
        /// </summary>
        /// <param name="color">The color to copy from</param>
        /// <param name="hue">The new hue</param>
        /// <returns></returns>
        public static Color SetHue(this Color color, float hue) {
            var c = color;
            SetHue(ref c, hue);
            return c;
        }

        /// <summary>
        /// Modifies the brightness value of color, without creating a copy.
        /// </summary>
        /// <param name="color">The color instance to modify</param>
        /// <param name="brightness">The new brightness</param>
        public static void SetBrightness(ref Color color, float brightness) {
            float h, s, v;
            Color.RGBToHSV(color, out h, out s, out v);
            color = Color.HSVToRGB(h, s, brightness);
        }

        /// <summary>
        /// Modifies the saturation value of color, without creating a copy.
        /// </summary>
        /// <param name="color">The color instance to modify</param>
        /// <param name="saturation">The new saturation</param>
        public static void SetSaturation(ref Color color, float saturation) {
            float h, s, v;
            Color.RGBToHSV(color, out h, out s, out v);
            color = Color.HSVToRGB(h, saturation, v);
        }

        /// <summary>
        /// Modifies the hue value of color, without creating a copy.
        /// </summary>
        /// <param name="color">The color instance to modify</param>
        /// <param name="hue">The new hue</param>
        public static void SetHue(ref Color color, float hue) {
            float h, s, v;
            Color.RGBToHSV(color, out h, out s, out v);
            color = Color.HSVToRGB(hue, s, v);
        }
    }
}