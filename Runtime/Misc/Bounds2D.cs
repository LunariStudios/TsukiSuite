using System;
using UnityEngine;

namespace Lunari.Tsuki.Runtime.Misc {
    [Serializable]
    public struct Bounds2D {
        public Vector2 Center;

        public Vector2 Size;

        private Bounds2D(Vector2 center, Vector2 size) {
            Center = center;
            Size = size;
        }

        public void Expand(float amount) {
            Expand(new Vector2(amount, amount));
        }

        public void Expand(Vector2 amount) {
            Size += amount;
        }

        public Vector2 Min {
            get => Center - Size / 2f;
            set => SetMinMax(value, Max);
        }

        public Vector2 Max {
            get => Center + Size / 2f;
            set => SetMinMax(Min, value);
        }

        public void SetMinMax(Vector2 min, Vector2 max) {
            Size = max - min;
            Center = min + Size / 2f;
        }

        public static implicit operator Bounds2D(Bounds bounds) {
            return new Bounds2D(bounds.center, bounds.size);
        }

        public static implicit operator Bounds(Bounds2D b) {
            return new Bounds(b.Center, b.Size);
        }

        public override string ToString() {
            return $"Bounds2D(Center: {Center}, Size: {Size}, Min: {Min}, Max: {Max})";
        }

        public Vector2 BottomLeft => Min;

        public Vector2 TopRight => new Vector2(Min.x, Max.y);

        public Vector2 TopLeft => Max;

        public Vector2 BottomRight => new Vector2(Max.x, Min.y);
    }
}