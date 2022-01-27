using System;
using Lunari.Tsuki.Algorithm;
using UnityEditor;
using UnityEngine;
namespace Lunari.Tsuki.Editor {
    public class Plotter {
        private Vector3[] points;
        private void ResizeBuffer(int size) {
            if (points != null) {
                if (points.Length == size) {
                    return;
                }
                var newBuf = new Vector3[size];
                Array.Copy(points, newBuf, Math.Min(points.Length, size));
                points = newBuf;
            } else {
                points = new Vector3[size];
            }

        }
        public void Plot(
            RingBuffer<float> timeline,
            float min,
            float max,
            float height,
            Color color
        ) {
            var rect = GUILayoutUtility.GetRect(0, float.MaxValue,
                height, height,
                Styles.box
            );
            Plot(rect, timeline, min, max, color);
        }
        public void Plot(Rect rect, RingBuffer<float> timeline, float min, float max, Color color) {
            var count = timeline.Count;
            ResizeBuffer(count);
            var sampleSize = rect.width / count;
            var i = 0;
            GUI.Box(rect, GUIContent.none);

            var minRect = rect
                .SetHeight(EditorGUIUtility.singleLineHeight);
            var maxRect = minRect
                .AddY(EditorGUIUtility.singleLineHeight + 8);
            GUI.Label(minRect, $"Min: {min}");
            GUI.Label(maxRect, $"Max: {max}");

            GUI.BeginClip(rect);
            var oldColor = Handles.color;
            Handles.DrawLine(
                new Vector2(0, rect.height),
                new Vector2(rect.width, rect.height)
            );
            Handles.DrawLine(
                new Vector2(0, 1),
                new Vector2(rect.width, 1)
            );
            Handles.color = color;

            foreach (var value in timeline) {
                var relative = Mathf.Clamp01(Mathf.InverseLerp(min, max, value));
                var x = i * sampleSize;
                var yOffset = rect.height * relative;
                var y = rect.height - yOffset;

                points[i] = new Vector3 {
                    x = x,
                    y = y,
                    z = 0
                };
                i++;
            }
            Handles.DrawAAPolyLine(
                Texture2D.whiteTexture,
                2,
                points
            );
            Handles.color = oldColor;
            GUI.EndClip();
        }
    }
}