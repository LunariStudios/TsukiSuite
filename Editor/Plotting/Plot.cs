using System;
using UnityEditor;
using UnityEngine;
namespace Lunari.Tsuki.Editor.Plotting {
    public class Plot {
        private Vector3[] points;
        private float[] data;
        public Plot(float min = 0, float max = 1) {
            Min = min;
            Max = max;
        }

        public bool Enabled {
            get;
            set;
        } = true;

        public Color Color {
            get;
            set;
        }

        public float Thickness {
            get;
            set;
        } = 1;

        public float[] Data {
            get {
                return data;
            }
        }

        public float Min {
            get;
            set;
        } = 0;

        public float Max {
            get;
            set;
        } = 1;

        public void Resize(int size) {
            Array.Resize(ref data, size);
            Array.Resize(ref points, size);
        }
        public void Draw(Rect rect) {
            if (!Enabled) {
                return;
            }
            var count = data.Length;
            var sampleSize = rect.width / count;
            var i = 0;
            GUI.BeginClip(rect);
            var oldColor = Handles.color;
            Handles.color = Color;
            foreach (var value in data) {
                var relative = Mathf.Clamp01(Mathf.InverseLerp(Min, Max, value));
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
                Thickness,
                points
            );
            Handles.color = oldColor;
            GUI.EndClip();
        }
    }
}