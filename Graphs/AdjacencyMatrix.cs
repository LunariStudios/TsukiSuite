using System;
using System.Collections.Generic;
using Lunari.Tsuki.Graphs.Exceptions;
using Lunari.Tsuki.Runtime;
using UnityEngine;

namespace Lunari.Tsuki.Graphs {
    [Serializable]
    public class AdjacencyMatrix<V, E> : Graph<V, E> {
        [SerializeField]
        private V[] vertices;

        [SerializeField]
        private E[] edges;


        public AdjacencyMatrix(int size) {
            vertices = new V[size];
            edges = new E[size * size];
        }

        private static void AdjustContainer<T>(ref List<T> container, int expected) {
            var c = container.Count;
            if (c > expected) {
                //Shrink
                container.RemoveRange(expected, container.Count - expected);
            }

            if (c < expected) {
                //Expand
                for (var i = container.Count; i < expected; i++) {
                    container.Add(default);
                }
            }
        }



        /// <exception cref="NotSupportedException"></exception>
        /// <seealso cref="this[int]"/>
        public override int AddVertex(V vertex) {
            throw new NotSupportedException("You cannot add vertices to an AdjacencyMatrix, maybe you're looking for 'AdjacencyMatrix<V, E>.this[int]'?");
        }

        public override int IndexOf(V vertex) => Array.IndexOf(vertices, vertex);

        public override V this[int index] {
            get => vertices[index];
            set => vertices[index] = value;
        }

        public override E this[int @from, int to] => edges[Indexing.IndexOf(from, to, Size)];

        public override void ClearVertices() {
            Array.Clear(vertices, 0, vertices.Length);
        }

        public override void ClearEdges() {
            Array.Clear(edges, 0, edges.Length);
        }

        private void CheckVertexBounds(int index) {
            if (IsOutOfBounds(index)) {
                throw new VertexOutOfRangeException<V, E>(index, this);
            }
        }

        private void CheckEdgeBounds(int from, int to) {
            CheckVertexBounds(from);
            CheckVertexBounds(to);
            var edgeIndex = Indexing.IndexOf(from, to, Size);
            if (edgeIndex >= edges.Length) {
                throw new EdgeOutOfRangeException<V, E>(from, to, edges.Length);
            }
        }

        public override void Connect(int @from, int to, E edge) {
#if UNITY_EDITOR
            CheckEdgeBounds(from, to);
#endif
            edges[Indexing.IndexOf(from, to, Size)] = edge;
        }

        public override bool IsOutOfBounds(int vertexIndex) {
            return vertexIndex >= vertices.Length || vertexIndex < 0;
        }

        public override void Disconnect(int @from, int to) {
            var i = Indexing.IndexOf(from, to, Size);
            edges[i] = default;
        }

        public override IEnumerable<Tuple<E, int>> EdgesFrom(int i) {
            var size = Size;
            for (var x = 0; x < size; x++) {
                for (var y = 0; y < size; y++) {
                    var idx = Indexing.IndexOf(x, y, Size);
                    var eIdx = Indexing.IndexOf(i, idx, Size);
                    if (IsOutOfEdgeBounds(eIdx)) {
                        continue;
                    }

                    var e = edges[eIdx];
                    if (e != null) {
                        yield return new Tuple<E, int>(e, eIdx);
                    }
                }
            }
        }

        public override IEnumerable<Tuple<E, int>> EdgesTo(int i) {
            var size = Size;
            for (var x = 0; x < size; x++) {
                for (var y = 0; y < size; y++) {
                    var idx = Indexing.IndexOf(x, y, Size);
                    var eIdx = Indexing.IndexOf(idx, i, Size);
                    if (IsOutOfEdgeBounds(eIdx)) {
                        continue;
                    }

                    var e = edges[eIdx];
                    if (e != null) {
                        yield return new Tuple<E, int>(e, eIdx);
                    }
                }
            }
        }

        private bool IsOutOfEdgeBounds(int eIdx) {
            return eIdx < 0 || eIdx >= edges.Length;
        }

        public override void Clear() {
            ClearEdges();
            ClearVertices();
        }

        public sealed override int Size {
            get => vertices.Length;
            set => throw new NotSupportedException("You cannot change the size of an AdjacencyMatrix");
        }
    }
}