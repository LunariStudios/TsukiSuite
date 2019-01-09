using System;
using System.Diagnostics.CodeAnalysis;
using UnityEngine;

namespace Lunari.Tsuki {
    [Serializable]
    public struct ColorHSV {
        public bool Equals(ColorHSV other) {
            return Mathf.Approximately(h, other.h) && Mathf.Approximately(s, other.s) &&
                   Mathf.Approximately(v, other.v) && Mathf.Approximately(a, other.a);
        }

        public override bool Equals(object obj) {
            if (ReferenceEquals(null, obj)) return false;
            return obj is ColorHSV && Equals((ColorHSV) obj);
        }

        [SuppressMessage("ReSharper", "NonReadonlyMemberInGetHashCode")]
        public override int GetHashCode() {
            unchecked {
                var hashCode = h.GetHashCode();
                hashCode = (hashCode * 397) ^ s.GetHashCode();
                hashCode = (hashCode * 397) ^ v.GetHashCode();
                hashCode = (hashCode * 397) ^ a.GetHashCode();
                return hashCode;
            }
        }
    
        public static readonly ColorHSV Red = Color.red;
        public static readonly ColorHSV Green = Color.green;
        public static readonly ColorHSV Blue = Color.blue;
        public static readonly ColorHSV White = Color.white;
        public static readonly ColorHSV Black = Color.black;
        public static readonly ColorHSV Yellow = Color.yellow;
        public static readonly ColorHSV Cyan = Color.cyan;
        public static readonly ColorHSV Magenta = Color.magenta;
        public static readonly ColorHSV Gray = Color.gray;
        public static readonly ColorHSV Grey = Color.grey;
        public static readonly ColorHSV Clear = Color.clear;

        [SerializeField]
        private float h;

        [SerializeField]
        private float s;

        [SerializeField]
        private float v;

        [SerializeField]
        private float a;

        public ColorHSV(float h, float s, float v) : this(h, s, v, 1) { }

        public ColorHSV(float h, float s, float v, float a) {
            this.h = h;
            this.s = s;
            this.v = v;
            this.a = a;
        }

        public float H {
            get {
                return h;
            }
            set {
                h = value;
            }
        }

        public float S {
            get {
                return s;
            }
            set {
                s = value;
            }
        }

        public float V {
            get {
                return v;
            }
            set {
                v = value;
            }
        }

        public float A {
            get {
                return a;
            }
            set {
                a = value;
            }
        }

        public static ColorHSV operator +(ColorHSV a, ColorHSV v) {
            return new ColorHSV(a.h + v.h, a.s + v.s, a.v + v.v, a.a + v.a);
        }

        public static ColorHSV operator -(ColorHSV a, ColorHSV v) {
            return new ColorHSV(a.h - v.h, a.s - v.s, a.v - v.v, a.a - v.a);
        }

        public static ColorHSV operator *(ColorHSV a, ColorHSV v) {
            return new ColorHSV(a.h * v.h, a.s * v.s, a.v * v.v, a.a * v.a);
        }

        public static ColorHSV operator *(ColorHSV a, float v) {
            return new ColorHSV(a.h * v, a.s * v, a.v * v, a.a * v);
        }

        public static ColorHSV operator *(float v, ColorHSV a) {
            return new ColorHSV(a.h * v, a.s * v, a.v * v, a.a * v);
        }

        public static ColorHSV operator /(ColorHSV a, float v) {
            return new ColorHSV(a.h / v, a.s / v, a.v / v, a.a / v);
        }

        public static bool operator ==(ColorHSV lhs, ColorHSV rhs) {
            return (Vector4) lhs == (Vector4) rhs;
        }

        public static bool operator !=(ColorHSV lhs, ColorHSV rhs) {
            return !(lhs == rhs);
        }

        public static ColorHSV Lerp(ColorHSV a, ColorHSV b, float t) {
            t = Mathf.Clamp01(t);
            return LerpUnclamped(a, b, t);
        }

        public static ColorHSV LerpUnclamped(ColorHSV a, ColorHSV v, float t) {
            return new ColorHSV(a.h + (v.h - a.h) * t, a.s + (v.s - a.s) * t, a.v + (v.v - a.v) * t,
                a.a + (v.a - a.a) * t);
        }

        public string ToString(string format) {
            return string.Format("HSVA({0}, {1}, {2}, {3})", h, s, v, a);
        }

        public static implicit operator Vector4(ColorHSV c) {
            return new Vector4(c.h, c.s, c.v, c.a);
        }

        public static implicit operator ColorHSV(Vector4 v) {
            return new ColorHSV(v.x, v.y, v.z, v.w);
        }

        public static implicit operator Color(ColorHSV colorHsv) {
            return Color.HSVToRGB(colorHsv.h, colorHsv.s, colorHsv.v);
        }

        public static implicit operator ColorHSV(Color colorHsv) {
            float h, s, v;
            Color.RGBToHSV(colorHsv, out h, out s, out v);
            return new ColorHSV(h, s, v);
        }
    }
}