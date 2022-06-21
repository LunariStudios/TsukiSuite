using System;
using Lunari.Tsuki.Scopes;
using UnityEditor;
using UnityEngine;
namespace Lunari.Tsuki.Editor.Plotting {
    public class SplitPlotter : PlotterBase {
        private Plot left, right;
        public SplitPlotter(Plot left, Plot right) {
            this.left = left;
            this.right = right;
        }

        public string LeftTitle {
            get;
            set;
        }

        public string RightTitle {
            get;
            set;
        }

        private void DrawLimits(
            Rect rect,
            string title,
            Plot plot,
            GUIStyle style
        ) {
            if (!plot.Enabled) {
                return;
            }
            float lineHeight = EditorGUIUtility.singleLineHeight + 2;
            var current = rect.SetHeight(lineHeight);
            var minContent = new GUIContent($"Min: {plot.Min}");
            var maxContent = new GUIContent($"Max: {plot.Max}");
            if (!title.IsNullOrEmpty()) {
                GUI.Label(current, title, style);
                current = current.AddY(lineHeight);
            }
            GUI.Label(current, minContent, style);
            current = current.AddY(lineHeight);
            GUI.Label(current, maxContent, style);
        }

        public override void Plot(float height) {
            var rect = GetPlotRect(height);
            /*if (left.Enabled || right.Enabled) {
                GUI.Box(rect, GUIContent.none);
            }*/
            left.Draw(rect);
            right.Draw(rect);
            const float limitsSize = 128;
            var leftRect = rect.AlignLeft(limitsSize);
            var rightRect = rect.AlignRight(limitsSize);
            DrawLimits(leftRect, LeftTitle, left, Styles.label);
            DrawLimits(rightRect, RightTitle, right, Styles.RightAlignedLabel);
        }
    }
}