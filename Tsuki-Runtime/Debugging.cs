using Lunari.Tsuki.Misc;
using UnityEngine;

namespace Lunari.Tsuki {
    public delegate void GizmosAction();

    public interface IGizmosSchedulable {
        void ScheduleGizmos(GizmosAction action);
        void DescheduleGizmos(GizmosAction action);
    }

    public static class Debugging {
        public static void DrawWireBox2D(Vector2 center, Vector2 size) {
            var halfWidth = size.x / 2;
            var halfHeight = size.y / 2;
            var bottomLeft = new Vector2(center.x - halfWidth, center.y - halfHeight);
            var topLeft = new Vector2(center.x - halfWidth, center.y + halfHeight);
            var bottomRight = new Vector2(center.x + halfWidth, center.y - halfHeight);
            var topRight = new Vector2(center.x + halfWidth, center.y + halfHeight);
            Debug.DrawLine(bottomLeft, topLeft);
            Debug.DrawLine(topLeft, topRight);
            Debug.DrawLine(topRight, bottomRight);
            Debug.DrawLine(bottomRight, bottomLeft);
        }

        public static void DrawWireBox2D(Vector2 center, Vector2 size, Color color) {
            var halfWidth = size.x / 2;
            var halfHeight = size.y / 2;
            var bottomLeft = new Vector2(center.x - halfWidth, center.y - halfHeight);
            var topLeft = new Vector2(center.x - halfWidth, center.y + halfHeight);
            var bottomRight = new Vector2(center.x + halfWidth, center.y - halfHeight);
            var topRight = new Vector2(center.x + halfWidth, center.y + halfHeight);
            Debug.DrawLine(bottomLeft, topLeft, color);
            Debug.DrawLine(topLeft, topRight, color);
            Debug.DrawLine(topRight, bottomRight, color);
            Debug.DrawLine(bottomRight, bottomLeft, color);
        }


        public static void DrawBounds2D(Bounds2D bounds, Color color) {
            DrawWireBox2D(bounds.Center, bounds.Size, color);
        }

        public const uint DefaultWireCircleVertices = 24;

        public static void DrawWireCircle2D(Vector2 entityPos, float radius, Color color,
            uint vertices = DefaultWireCircleVertices) {
            var verts = new Vector2[DefaultWireCircleVertices];
            for (uint i = 0; i < DefaultWireCircleVertices; i++) {
                var pos = (float) i / DefaultWireCircleVertices * 6.283185F;
                var x = Mathf.Sin(pos) * radius;
                var y = Mathf.Cos(pos) * radius;
                var vert = entityPos;
                vert.x += x;
                vert.y += y;
                verts[i] = vert;
            }

            DrawArray(verts, color, true);
        }

        public static void DrawArray(Vector2[] path, Color color, bool close = false) {
            var max = path.Length - 1;
            for (var i = 0; i < max; i++) {
                var first = path[i];
                var second = path[i + 1];
                Debug.DrawLine(first, second, color);
            }

            if (close) {
                Debug.DrawLine(path[0], path[path.Length - 1], color);
            }
        }
    }

    public static class GizmosUtility {
        public static void DrawWireBox2D(Vector2 center, Vector2 size) {
            var halfWidth = size.x / 2;
            var halfHeight = size.y / 2;
            var bottomLeft = new Vector2(center.x - halfWidth, center.y - halfHeight);
            var topLeft = new Vector2(center.x - halfWidth, center.y + halfHeight);
            var bottomRight = new Vector2(center.x + halfWidth, center.y - halfHeight);
            var topRight = new Vector2(center.x + halfWidth, center.y + halfHeight);
            Gizmos.DrawLine(bottomLeft, topLeft);
            Gizmos.DrawLine(topLeft, topRight);
            Gizmos.DrawLine(topRight, bottomRight);
            Gizmos.DrawLine(bottomRight, bottomLeft);
        }

        public static void DrawWireBox2D(Vector2 center, Vector2 size, Color color) {
            var initColor = Gizmos.color;
            Gizmos.color = color;
            DrawWireBox2D(center, size);
            Gizmos.color = initColor;
        }


        public static void DrawBounds2D(Bounds2D bounds, Color color) {
            DrawWireBox2D(bounds.Center, bounds.Size, color);
        }

        public const uint DefaultWireCircleVertices = 24;

        public static void DrawWireCircle2D(Vector2 entityPos, float radius, Color color,
            uint vertices = DefaultWireCircleVertices) {
            var verts = new Vector2[DefaultWireCircleVertices];
            for (uint i = 0; i < DefaultWireCircleVertices; i++) {
                var pos = (float) i / DefaultWireCircleVertices * 6.283185F;
                var x = Mathf.Sin(pos) * radius;
                var y = Mathf.Cos(pos) * radius;
                var vert = entityPos;
                vert.x += x;
                vert.y += y;
                verts[i] = vert;
            }

            DrawArray(verts, color, true);
        }

        public static void DrawArray(Vector2[] path, Color color, bool close = false) {
            var initColor = Gizmos.color;
            Gizmos.color = color;
            var max = path.Length - 1;
            for (var i = 0; i < max; i++) {
                var first = path[i];
                var second = path[i + 1];
                Gizmos.DrawLine(first, second);
            }

            if (close) {
                Gizmos.DrawLine(path[0], path[path.Length - 1]);
            }

            Gizmos.color = initColor;
        }
    }
}