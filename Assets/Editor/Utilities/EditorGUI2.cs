using UnityEditor;
namespace Lunari.Tsuki.Editor.Utilities {
    public static class EditorGUI2 {
        public static readonly float fullSingleLineHeight = GetHeight(1);
        public static float GetHeight(int numLines) {
            var height = (EditorGUIUtility.singleLineHeight + EditorGUIUtility.standardVerticalSpacing) * numLines;
            return height;
        }
    }
}