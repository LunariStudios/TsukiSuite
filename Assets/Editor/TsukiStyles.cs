using UnityEngine;

namespace Lunari.Tsuki.Editor {
    public class TsukiStyles {
        public static readonly GUIStyle NoMargin = new GUIStyle {
            border = new RectOffset(),
            margin = new RectOffset(),
            stretchWidth = false
        };

    }
}