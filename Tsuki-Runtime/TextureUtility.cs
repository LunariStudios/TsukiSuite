using UnityEngine;

namespace Lunari.Tsuki {
    public static class TextureUtility {
        public static readonly Texture2D WhiteTexture = PixelTexture(Color.white);
        public static readonly Texture2D BlackTexture = PixelTexture(Color.black);
        public static readonly Texture2D RedTexture = PixelTexture(Color.red);
        public static readonly Texture2D GreenTexture = PixelTexture(Color.green);
        public static readonly Texture2D BlueTexture = PixelTexture(Color.blue);
        public static readonly Texture2D CyanTexture = PixelTexture(Color.cyan);
        public static readonly Texture2D MagentaTexture = PixelTexture(Color.magenta);
        public static readonly Texture2D YellowTexture = PixelTexture(Color.yellow);
        public static readonly Texture2D GreyTexture = PixelTexture(Color.grey);

        /// <summary>
        /// Create a 1x1 texture of the provided color
        /// </summary>
        /// <param name="color">The color of the texture</param>
        /// <returns>A 1x1 texture of the provided color</returns>
        public static Texture2D PixelTexture(Color32 color) {
            return ColorTexture(color, 1, 1);
        }

        /// <summary>
        /// Creates a texture of the provided size and fills it with the provided color
        /// </summary>
        /// <param name="color">The color of the texture</param>
        /// <param name="width">The width of the texture</param>
        /// <param name="height">The height of the texture</param>
        /// <returns>A 1x1 texture of the provided color</returns>
        public static Texture2D ColorTexture(Color32 color, int width, int height) {
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