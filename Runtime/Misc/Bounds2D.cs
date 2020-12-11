using System;
using UnityEngine;

namespace Lunari.Tsuki.Runtime.Misc {
    [Serializable]
    public struct Bounds2D {
        public Vector2 center;

        public Vector2 size;

        private Bounds2D(Vector2 center, Vector2 size) {
            this.center = center;
            this.size = size;
        }

        public void Expand(float amount) {
            Expand(new Vector2(amount, amount));
        }

        public void Expand(Vector2 amount) {
            size += amount;
        }

        public Vector2 Min {
            get => center - size / 2f;
            set => SetMinMax(value, Max);
        }

        public Vector2 Max {
            get => center + size / 2f;
            set => SetMinMax(Min, value);
        }

        public void SetMinMax(Vector2 min, Vector2 max) {
            size = max - min;
            center = min + size / 2f;
        }

        public static implicit operator Bounds2D(Bounds bounds) {
            return new Bounds2D(bounds.center, bounds.size);
        }

        public static implicit operator Bounds(Bounds2D b) {
            return new Bounds(b.center, b.size);
        }

        public override string ToString() {
            return $"Bounds2D(Center: {center}, Size: {size}, Min: {Min}, Max: {Max})";
        }

        public Vector2 BottomLeft => Min;

        public Vector2 TopRight => new Vector2(Min.x, Max.y);

        public Vector2 TopLeft => Max;

        public Vector2 BottomRight => new Vector2(Max.x, Min.y);
    }
}