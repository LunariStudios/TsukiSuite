using System;
using UnityEngine;
namespace Lunari.Tsuki.Misc {
    [Serializable]
    public struct Direction2D : IComparable<Direction2D>, IComparable {
        public static readonly Direction2D Up = new Direction2D(UnitValue.Zero, UnitValue.One);
        public static readonly Direction2D Down = new Direction2D(UnitValue.Zero, UnitValue.MinusOne);
        public static readonly Direction2D Left = new Direction2D(UnitValue.MinusOne, UnitValue.Zero);
        public static readonly Direction2D Right = new Direction2D(UnitValue.One, UnitValue.Zero);

        public static readonly Direction2D UpLeft = new Direction2D(UnitValue.MinusOne, UnitValue.One);
        public static readonly Direction2D UpRight = new Direction2D(UnitValue.One, UnitValue.One);
        public static readonly Direction2D DownLeft = new Direction2D(UnitValue.MinusOne, UnitValue.MinusOne);
        public static readonly Direction2D DownRight = new Direction2D(UnitValue.One, UnitValue.MinusOne);

        public static Direction2D operator +(Direction2D lhs, Direction2D rhs) {
            return new Direction2D(lhs.x + rhs.x, lhs.y + rhs.y);
        }

        public static readonly Direction2D Zero = new Direction2D(UnitValue.Zero, UnitValue.Zero);

        public static readonly Direction2D[] AllNonZero = {
            Up, Down, Left, Right,
            UpLeft, UpRight, DownLeft, DownRight
        };

        public static readonly Direction2D[] All = LoadAll();

        private static Direction2D[] LoadAll() {
            var a = new Direction2D[9];
            Array.Copy(AllNonZero, a, 8);
            a[0] = Zero;
            return a;
        }

        [SerializeField] private UnitValue x;

        [SerializeField] private UnitValue y;

        public UnitValue X {
            get => x;
            set => x = value;
        }

        public UnitValue Y {
            get => y;
            set => y = value;
        }

        public int CompareTo(Direction2D other) {
            if (y > other.y) {
                return 1;
            }

            if (y < other.y) {
                return -1;
            }

            return ((int) x).CompareTo(other.x);
        }

        public int CompareTo(object obj) {
            if (ReferenceEquals(null, obj))
                return 1;
            if (!(obj is Direction2D))
                throw new ArgumentException("Object must be of type Direction");
            return CompareTo((Direction2D) obj);
        }

        public static bool operator ==(Direction2D left, Direction2D right) {
            return left.CompareTo(right) == 0;
        }

        public static bool operator !=(Direction2D left, Direction2D right) {
            return !(left == right);
        }

        public static bool operator <(Direction2D left, Direction2D right) {
            return left.CompareTo(right) < 0;
        }

        public static bool operator >(Direction2D left, Direction2D right) {
            return left.CompareTo(right) > 0;
        }

        public static bool operator <=(Direction2D left, Direction2D right) {
            return left.CompareTo(right) <= 0;
        }

        public static bool operator >=(Direction2D left, Direction2D right) {
            return left.CompareTo(right) >= 0;
        }

        public static Direction2D operator -(Direction2D d) {
            return new Direction2D(-d.x, -d.y);
        }

        public bool Equals(Direction2D other) {
            return x.Equals(other.x) && y.Equals(other.y);
        }

        public override bool Equals(object obj) {
            if (ReferenceEquals(null, obj))
                return false;
            return obj is Direction2D && Equals((Direction2D) obj);
        }

        public override int GetHashCode() {
            unchecked {
                return (x.GetHashCode() * 397) ^ y.GetHashCode();
            }
        }


        public float Angle => Mathf.Acos(Mathf.Clamp(Vector2.Dot(Vector2.zero, this), -1f, 1f)) * 57.29578f;


        public override string ToString() {
            return $"({(int) x}, {(int) y})";
        }


        public static Direction2D GetDirection(float x, float y, float xLimit, float yLimit) {
            return new Direction2D(UnitValue.FromFloat(x, xLimit), UnitValue.FromFloat(y, yLimit));
        }

        public static Direction2D FromVector(Vector2 vector2) {
            return GetDirection(vector2.x, vector2.y);
        }

        private static Direction2D GetDirection(float x, float y) {
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

        public static Direction2D FromVector(Vector2 vector2, float xLimit, float yLimit) {
            return GetDirection(vector2.x, vector2.y, xLimit, yLimit);
        }

        public Direction2D(UnitValue x, UnitValue y) {
            this.x = x;
            this.y = y;
        }

        public static implicit operator Vector2(Direction2D dir) {
            return new Vector2(dir.x, dir.y).normalized;
        }

        public static implicit operator Vector3(Direction2D dir) {
            return (Vector2) dir;
        }

        public static implicit operator Vector2Int(Direction2D dir) {
            return new Vector2Int(dir.x, dir.y);
        }

        public static implicit operator Vector3Int(Direction2D dir) {
            return new Vector3Int(dir.x, dir.y, 0);
        }

        public bool IsDiagonal() {
            return x != UnitValue.Zero && y != UnitValue.Zero;
        }

        public bool IsZero() {
            return x == UnitValue.Zero && y == UnitValue.Zero;
        }

        public static Direction2D FromX(float x) {
            if (x > 0) {
                return Right;
            }

            return x < 0 ? Left : Zero;
        }

        public static Direction2D FromX(int x) {
            if (x > 0) {
                return Right;
            }

            return x < 0 ? Left : Zero;
        }
    }
}