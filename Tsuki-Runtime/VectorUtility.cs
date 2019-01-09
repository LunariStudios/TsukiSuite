using UnityEngine;

namespace Lunari.Tsuki {
    public static class VectorUtility {
        public static string ToPrecisionString(this Vector2 vector) {
            return string.Format("({0}, {1})", vector.x, vector.y);
        }

        public static Vector2 Multiply(this Vector2 a, Vector2 b) {
            return new Vector2(a.x * b.x, a.y * b.y);
        }

        public static Vector2 ToFloat(this Vector2Int a) {
            return new Vector2(a.x, a.y);
        }

        public static Vector3Int ToVector3(this Vector2Int a, int z = 0) {
            return new Vector3Int(a.x, a.y, z);
        }

        public static Vector2Int ToVector2(this Vector3Int a) {
            return new Vector2Int(a.x, a.y);
        }
    }
}