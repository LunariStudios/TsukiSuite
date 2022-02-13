using System;
using UnityEngine;
namespace Lunari.Tsuki.Scopes {
    public class GUIColorScope : IDisposable {
        public enum ColorTarget {
            Normal,
            Content,
            Background
        }

        private readonly Color color;
        private readonly ColorTarget target;

        public GUIColorScope(
            bool condition,
            Color color,
            ColorTarget target = ColorTarget.Normal
        ) : this(condition ? color : GUI.color, target) {
        }

        public GUIColorScope(Color color, ColorTarget target = ColorTarget.Normal) {
            this.target = target;
            switch (target) {
                case ColorTarget.Normal:
                    this.color = GUI.color;
                    GUI.color = color;
                    break;
                case ColorTarget.Content:
                    this.color = GUI.contentColor;
                    GUI.contentColor = color;
                    break;
                case ColorTarget.Background:
                    this.color = GUI.backgroundColor;
                    GUI.backgroundColor = color;
                    break;
                default:
                    throw new ArgumentOutOfRangeException(nameof(target), target, null);
            }
        }

        public void Dispose() {
            switch (target) {
                case ColorTarget.Normal:
                    GUI.color = color;
                    break;
                case ColorTarget.Content:
                    GUI.contentColor = color;
                    break;
                case ColorTarget.Background:
                    GUI.backgroundColor = color;
                    break;
                default:
                    throw new ArgumentOutOfRangeException(nameof(target), target, null);
            }
        }
    }
}