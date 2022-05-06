using UnityEngine;
using UnityEngine.Events;
namespace Lunari.Tsuki {
    public static class GUIStyles {
        public static GUIStyle CopyWith(this  GUIStyle style, UnityAction<GUIStyle> action) {
            var other = new GUIStyle(style);
            action(other);
            return other;
        }
    }
}