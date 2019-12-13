using UnityEngine;

namespace Lunari.Tsuki.Runtime {
    public static class Textures {
        public static readonly Texture2D WhiteTexture = Pixel(UnityEngine.Color.white);
        public static readonly Texture2D BlackTexture = Pixel(UnityEngine.Color.black);
        public static readonly Texture2D RedTexture = Pixel(UnityEngine.Color.red);
        public static readonly Texture2D GreenTexture = Pixel(UnityEngine.Color.green);
        public static readonly Texture2D BlueTexture = Pixel(UnityEngine.Color.blue);
        public static readonly Texture2D CyanTexture = Pixel(UnityEngine.Color.cyan);
        public static readonly Texture2D MagentaTexture = Pixel(UnityEngine.Color.magenta);
        public static readonly Texture2D YellowTexture = Pixel(UnityEngine.Color.yellow);
        public static readonly Texture2D GreyTexture = Pixel(UnityEngine.Color.grey);

        /// <summary>
        /// Create a 1x1 texture of the provided color
        /// </summary>
        /// <param name="color">The color of the texture</param>
        /// <returns>A 1x1 texture of the provided color</returns>
        public static Texture2D Pixel(Color32 color) {
            return Color(color, 1, 1);
        }

        /// <summary>
        /// Creates a texture of the provided size and fills it with the provided color
        /// </summary>
        /// <param name="color">The color of the texture</param>
        /// <param name="width">The width of the texture</param>
        /// <param name="height">The height of the texture</param>
        /// <returns>A 1x1 texture of the provided color</returns>
        public static Texture2D Color(Color32 color, int width, int height) {
            var texture2D = new Texture2D(width, height);
            var pixels = new Color32[width * height];
            for (var i = 0; i < pixels.Length; i++) {
                pixels[i] = color;
            }

            texture2D.SetPixels32(pixels);
            texture2D.Apply();
            return texture2D;
        }
    }
}