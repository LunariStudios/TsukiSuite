using Lunari.Tsuki.Editor;
using UnityEngine;
namespace Lunari.Tsuki.Cheater {
    public class CheaterStyles {
        public static GUIStyle TextFieldInput = new GUIStyle(Styles.textarea) {

        };
        public static GUIStyle DefaultBackground = new GUIStyle {
            normal = new GUIStyleState {
                background = Textures.Pixel(new Color32(39, 39, 39, (byte) (255 * 0.75F))),
                textColor = Color.white
            }
        };
        public static GUIStyle CommandSuggestion = DefaultBackground.CopyWith(style => {

        });
        public static GUIStyle CommandSuggestionSelected = DefaultBackground.CopyWith(style => {
            style.normal = new GUIStyleState {
                background = Textures.Pixel(new Color32(39, 39, 39, 255)),
                textColor = Color.green
            };
        });

        public static GUIStyle CommandHeader = new GUIStyle(Styles.HeaderLabel);
    }
}