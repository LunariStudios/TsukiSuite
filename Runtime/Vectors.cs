using System;
using Lunari.Tsuki.Misc;
using UnityEngine;
namespace Lunari.Tsuki {
    public static class Vectors {
        /// <summary>
        /// Returns a string with all the decimal plates of this <see cref="vector"/> components. 
        /// </summary>
        public static string ToPrecisionString(this Vector2 vector) {
            return $"({vector.x}, {vector.y})";
        }

        /// <summary>
        /// Returns a string with all the decimal plates of this <see cref="vector"/> components. 
        /// </summary>
        public static string ToPrecisionString(this Vector3 vector) {
            return $"({vector.x}, {vector.y}, {vector.z})";
        }

        /// <summary>
        /// Returns a new vector where the components (x and y) of the vectors are multiplied by each other, like so:
        /// <code>return new Vector2(a.x * b.x, a.y * b.y)</code>
        /// </summary>
        public static Vector2 MultiplyComponents(this Vector2 a, Vector2 b) {
            return new Vector2(a.x * b.x, a.y * b.y);
        }

        /// <summary>
        /// Returns a new vector where the components (x and y) of the vectors are multiplied by each other, like so:
        /// <code>return new Vector3(a.x * b.x, a.y * b.y, a.z * b.z);</code>
        /// </summary>
        public static Vector3 MultiplyComponents(this Vector3 a, Vector3 b) {
            return new Vector3(a.x * b.x, a.y * b.y, a.z * b.z);
        }

        /// <summary>
        /// Converts this vector to it's float counterpart, like so:
        /// <code>return new Vector2(a.x, a.y)</code>
        /// </summary>
        public static Vector2 ToFloat(this Vector2Int a) {
            return new Vector2(a.x, a.y);
        }

        /// <summary>
        /// Converts this vector to it's float counterpart, like so:
        /// <code>return new Vector3(a.x, a.y, a.z)</code>
        /// </summary>
        public static Vector3 ToFloat(this Vector3Int a) {
            return new Vector3(a.x, a.y, a.z);
        }

        /// <summary>
        /// Adds a third component to this vector, converting it to a <see cref="Vector3Int"/>.
        /// </summary>
        /// <param name="z">The value of the new component, defaults to 0.</param>
        public static Vector3Int ToVector3(this Vector2Int a, int z = 0) {
            return new Vector3Int(a.x, a.y, z);
        }

        /// <summary>
        /// Removes a component from this vector, converting it to a <see cref="Vector2Int"/>.
        /// </summary>
        /// <param name="excludedAxis">The components which will be excluded from the new
        /// vector, defaults to <see cref="Axis.Z"/>.</param>
        public static Vector2Int ToVector2(this Vector3Int a, Axis excludedAxis = Axis.Z) {
            int first, second;
            switch (excludedAxis) {
                case Axis.X:
                    first = a.y;
                    second = a.z;
                    break;
                case Axis.Y:
                    first = a.x;
                    second = a.z;
                    break;
                case Axis.Z:
                    first = a.x;
                    second = a.y;
                    break;
                default:
                    throw new ArgumentOutOfRangeException(nameof(excludedAxis), excludedAxis, null);
            }

            return new Vector2Int(first, second);
        }
    }
}