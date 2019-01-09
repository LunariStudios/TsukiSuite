using System;
using UnityEngine;

namespace Lunari.Tsuki.Misc {
    [Serializable]
    public struct Bounds2D {
        [SerializeField]
        public Vector2 Center;

        [SerializeField]
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
            get {
                return Center - Size / 2f;
            }
            set {
                SetMinMax(value, Max);
            }
        }

        public Vector2 Max {
            get {
                return Center + Size / 2f;
            }
            set {
                SetMinMax(Min, value);
            }
        }

        public void SetMinMax(Vector2 min, Vector2 max) {
            Size = max - min;
            Center = min + Size / 2f;
        }

        public static implicit operator Bounds2D(Bounds bounds) {
            return new Bounds2D((Vector2) bounds.center, (Vector2) bounds.size);
        }

        public static implicit operator Bounds(Bounds2D b) {
            return new Bounds((Vector3) b.Center, (Vector3) b.Size);
        }

        public override string ToString() {
            return string.Format("Bounds2D(Center: {0}, Size: {1}, Min: {2}, Max: {3})", (object) Center, (object) Size, (object) Min, (object) Max);
        }

        public Vector2 BottomLeft {
            get {
                return Min;
            }
        }

        public Vector2 TopRight {
            get {
                return new Vector2(Min.x, Max.y);
            }
        }

        public Vector2 TopLeft {
            get {
                return Max;
            }
        }

        public Vector2 BottomRight {
            get {
                return new Vector2(Max.x, Min.y);
            }
        }
    }
}