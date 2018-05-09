using System;
using UnityEngine;

namespace UnityUtilities.Misc {
    [Serializable]
    public struct Bounds2D {
        [SerializeField]
        public Vector2 Center;

        [SerializeField]
        public Vector2 Size;

        private Bounds2D(Vector2 center, Vector2 size) {
            this.Center = center;
            this.Size = size;
        }

        public void Expand(float amount) {
            this.Expand(new Vector2(amount, amount));
        }

        public void Expand(Vector2 amount) {
            this.Size += amount;
        }

        public Vector2 Min {
            get {
                return this.Center - this.Size / 2f;
            }
            set {
                this.SetMinMax(value, this.Max);
            }
        }

        public Vector2 Max {
            get {
                return this.Center + this.Size / 2f;
            }
            set {
                this.SetMinMax(this.Min, value);
            }
        }

        public void SetMinMax(Vector2 min, Vector2 max) {
            this.Size = max - min;
            this.Center = min + this.Size / 2f;
        }

        public static implicit operator Bounds2D(Bounds bounds) {
            return new Bounds2D((Vector2) bounds.center, (Vector2) bounds.size);
        }

        public static implicit operator Bounds(Bounds2D b) {
            return new Bounds((Vector3) b.Center, (Vector3) b.Size);
        }

        public override string ToString() {
            return string.Format("Bounds2D(Center: {0}, Size: {1}, Min: {2}, Max: {3})", (object) this.Center, (object) this.Size, (object) this.Min, (object) this.Max);
        }

        public Vector2 BottomLeft {
            get {
                return this.Min;
            }
        }

        public Vector2 TopRight {
            get {
                return new Vector2(this.Min.x, this.Max.y);
            }
        }

        public Vector2 TopLeft {
            get {
                return this.Max;
            }
        }

        public Vector2 BottomRight {
            get {
                return new Vector2(this.Max.x, this.Min.y);
            }
        }
    }
}