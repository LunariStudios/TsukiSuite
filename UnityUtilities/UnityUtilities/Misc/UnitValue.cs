using System;
using UnityEngine;

namespace UnityUtilities.Misc {
    [Serializable]
    public struct UnitValue {
        public static readonly UnitValue Foward = new UnitValue(1);
        public static readonly UnitValue Zero = new UnitValue(0);
        public static readonly UnitValue Backward = new UnitValue(-1);

        private readonly sbyte value;

        private UnitValue(sbyte value) {
            this.value = value;
        }

        public static implicit operator UnitValue(int i) {
            if (i > 0) {
                return Foward;
            }

            return i < 0 ? Backward : Zero;
        }

        public static implicit operator UnitValue(float f) {
            if (f > 0) {
                return Foward;
            }

            return f < 0 ? Backward : Zero;
        }

        public static UnitValue FromFloat(float val, float limit = 0) {
            if (val > limit) {
                return Foward;
            }

            return val < -limit ? Backward : Zero;
        }

        public static implicit operator sbyte(UnitValue val) {
            return val.value;
        }
    }

    [Serializable]
    public struct Direction : IComparable<Direction>, IComparable {
        public static readonly Direction Up = new Direction(UnitValue.Zero, UnitValue.Foward);
        public static readonly Direction Down = new Direction(UnitValue.Zero, UnitValue.Backward);
        public static readonly Direction Left = new Direction(UnitValue.Backward, UnitValue.Zero);
        public static readonly Direction Right = new Direction(UnitValue.Foward, UnitValue.Zero);

        public static readonly Direction UpLeft = new Direction(UnitValue.Backward, UnitValue.Foward);
        public static readonly Direction UpRight = new Direction(UnitValue.Foward, UnitValue.Foward);
        public static readonly Direction DownLeft = new Direction(UnitValue.Backward, UnitValue.Backward);
        public static readonly Direction DownRight = new Direction(UnitValue.Foward, UnitValue.Backward);

        public static readonly Direction Zero = new Direction(UnitValue.Zero, UnitValue.Zero);

        public static readonly Direction[] AllNonZero = {
            Up, Down, Left, Right,
            UpLeft, UpRight, DownLeft, DownRight
        };

        public static readonly Direction[] All = LoadAll();

        private static Direction[] LoadAll() {
            var a = new Direction[9];
            Array.Copy(AllNonZero, a, 8);
            a[0] = Zero;
            return a;
        }

        public UnitValue X;
        public UnitValue Y;

        public int CompareTo(Direction other) {
            if (Y > other.Y) {
                return 1;
            }

            if (Y < other.Y) {
                return -1;
            }

            return ((int) X).CompareTo(other.X);
        }

        public int CompareTo(object obj) {
            if (ReferenceEquals(null, obj))
                return 1;
            if (!(obj is Direction))
                throw new ArgumentException("Object must be of type Direction");
            return CompareTo((Direction) obj);
        }

        public static bool operator ==(Direction left, Direction right) {
            return left.CompareTo(right) == 0;
        }

        public static bool operator !=(Direction left, Direction right) {
            return !(left == right);
        }

        public static bool operator <(Direction left, Direction right) {
            return left.CompareTo(right) < 0;
        }

        public static bool operator >(Direction left, Direction right) {
            return left.CompareTo(right) > 0;
        }

        public static bool operator <=(Direction left, Direction right) {
            return left.CompareTo(right) <= 0;
        }

        public static bool operator >=(Direction left, Direction right) {
            return left.CompareTo(right) >= 0;
        }

        public static Direction operator -(Direction d) {
            return new Direction(-d.X, -d.Y);
        }

        public bool Equals(Direction other) {
            return X.Equals(other.X) && Y.Equals(other.Y);
        }

        public override bool Equals(object obj) {
            if (ReferenceEquals(null, obj))
                return false;
            return obj is Direction && Equals((Direction) obj);
        }

        public override int GetHashCode() {
            unchecked {
                return (X.GetHashCode() * 397) ^ Y.GetHashCode();
            }
        }


        public float Angle {
            get {
                return Mathf.Acos(Mathf.Clamp(Vector2.Dot(Vector2.zero, this), -1f, 1f)) * 57.29578f;
            }
        }


        public override string ToString() {
            return string.Format("({0}, {1})", (int) X, (int) Y);
        }


        public static Direction GetDirection(float x, float y, float xLimit, float yLimit) {
            return new Direction(UnitValue.FromFloat(x, xLimit), UnitValue.FromFloat(y, yLimit));
        }

        public static Direction FromVector(Vector2 vector2) {
            return GetDirection(vector2.x, vector2.y);
        }

        private static Direction GetDirection(float x, float y) {
            if (y > 0) {
                if (x > 0) {
                    return UpRight;
                }

                return x < 0 ? UpLeft : Up;
            }

            if (y < 0) {
                if (x > 0) {
                    return DownRight;
                }

                return x < 0 ? DownLeft : Down;
            }

            if (x > 0) {
                return Right;
            }

            return x < 0 ? Left : Zero;
        }

        public static Direction FromVector(Vector2 vector2, float xLimit, float yLimit) {
            return GetDirection(vector2.x, vector2.y, xLimit, yLimit);
        }

        public Direction(UnitValue x, UnitValue y) {
            X = x;
            Y = y;
        }

        public static implicit operator Vector2(Direction dir) {
            return new Vector2(dir.X, dir.Y).normalized;
        }

        public static implicit operator Vector3(Direction dir) {
            return (Vector2) dir;
        }

        public static implicit operator Vector2Int(Direction dir) {
            return new Vector2Int(dir.X, dir.Y);
        }

        public static implicit operator Vector3Int(Direction dir) {
            return new Vector3Int(dir.X, dir.Y, 0);
        }

        public bool IsDiagonal() {
            return X != UnitValue.Zero && Y != UnitValue.Zero;
        }

        public bool IsZero() {
            return X == UnitValue.Zero && Y == UnitValue.Zero;
        }

        public static Direction FromX(float x) {
            if (x > 0) {
                return Right;
            }

            return x < 0 ? Left : Zero;
        }

        public static Direction FromX(int x) {
            if (x > 0) {
                return Right;
            }

            return x < 0 ? Left : Zero;
        }
    }
}