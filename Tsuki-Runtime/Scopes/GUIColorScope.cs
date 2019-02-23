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

        public GUIColorScope(Color red, ColorTarget target = ColorTarget.Normal) {
            this.target = target;
            switch (target) {
                case ColorTarget.Normal:
                    color = GUI.color;
                    GUI.color = red;
                    break;
                case ColorTarget.Content:
                    color = GUI.contentColor;
                    GUI.contentColor = red;
                    break;
                case ColorTarget.Background:
                    color = GUI.backgroundColor;
                    GUI.backgroundColor = red;
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