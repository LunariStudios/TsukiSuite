using Lunari.Tsuki.Misc;
using Lunari.Tsuki.Scopes;
using UnityEngine;
namespace Lunari.Tsuki {
    public static class Gizmos2 {
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
            using (new GizmosColorScope(color)) {
                DrawWireBox2D(center, size);
            }
        }

        public static void DrawBounds2D(Bounds2D bounds) {
            DrawWireBox2D(bounds.center, bounds.size);
        }

        public static void DrawBounds2D(Bounds2D bounds, Color color) {
            DrawWireBox2D(bounds.center, bounds.size, color);
        }


        public const uint DefaultWireCircleVertices = 24;

        public static void DrawWireCircle2D(Vector2 entityPos, float radius, Color color,
            uint vertices = DefaultWireCircleVertices) {
            var verts = new Vector2[DefaultWireCircleVertices];
            for (uint i = 0; i < vertices; i++) {
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
            using (new GizmosColorScope(color)) {
                DrawArray(path, close);
            }
        }

        public static void DrawArray(Vector2[] path, bool close = false) {
            var max = path.Length - 1;
            for (var i = 0; i < max; i++) {
                var first = path[i];
                var second = path[i + 1];
                Gizmos.DrawLine(first, second);
            }

            if (close) {
                Gizmos.DrawLine(path[0], path[path.Length - 1]);
            }
        }
    }
}