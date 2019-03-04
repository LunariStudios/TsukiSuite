using System;
using UnityEngine;

namespace Lunari.Tsuki.Misc {
    [Serializable]
    public struct Direction : IComparable<Direction>, IComparable {
        public static readonly Direction Up = new Direction(UnitValue.Zero, UnitValue.One);
        public static readonly Direction Down = new Direction(UnitValue.Zero, UnitValue.MinusOne);
        public static readonly Direction Left = new Direction(UnitValue.MinusOne, UnitValue.Zero);
        public static readonly Direction Right = new Direction(UnitValue.One, UnitValue.Zero);

        public static readonly Direction UpLeft = new Direction(UnitValue.MinusOne, UnitValue.One);
        public static readonly Direction UpRight = new Direction(UnitValue.One, UnitValue.One);
        public static readonly Direction DownLeft = new Direction(UnitValue.MinusOne, UnitValue.MinusOne);
        public static readonly Direction DownRight = new Direction(UnitValue.One, UnitValue.MinusOne);

        public static Direction operator +(Direction lhs, Direction rhs) {
            return new Direction(lhs.x + rhs.x, lhs.y + rhs.y);
        }

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

        public int CompareTo(Direction other) {
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
            return new Direction(-d.x, -d.y);
        }

        public bool Equals(Direction other) {
            return x.Equals(other.x) && y.Equals(other.y);
        }

        public override bool Equals(object obj) {
            if (ReferenceEquals(null, obj))
                return false;
            return obj is Direction && Equals((Direction) obj);
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
            this.x = x;
            this.y = y;
        }

        public static implicit operator Vector2(Direction dir) {
            return new Vector2(dir.x, dir.y).normalized;
        }

        public static implicit operator Vector3(Direction dir) {
            return (Vector2) dir;
        }

        public static implicit operator Vector2Int(Direction dir) {
            return new Vector2Int(dir.x, dir.y);
        }

        public static implicit operator Vector3Int(Direction dir) {
            return new Vector3Int(dir.x, dir.y, 0);
        }

        public bool IsDiagonal() {
            return x != UnitValue.Zero && y != UnitValue.Zero;
        }

        public bool IsZero() {
            return x == UnitValue.Zero && y == UnitValue.Zero;
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