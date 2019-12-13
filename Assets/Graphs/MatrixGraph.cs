using System;
using System.Collections.Generic;
using Lunari.Tsuki.Runtime;
using UnityEngine;

namespace Lunari.Tsuki.Graphs {
    [Serializable]
    public class MatrixGraph<V, E> : Graph<V, E> where E : class where V : class {
        [SerializeField]
        private List<V> vertices;

        [SerializeField]
        private List<E> edges;

        private static void AdjustContainer<T>(ref List<T> container, int expected, Func<int, T> creator) {
            var c = container.Count;
            if (c > expected) {
                //Shrink
                container.RemoveRange(expected, container.Count - expected);
            }

            if (c < expected) {
                //Expand
                for (var i = container.Count; i < expected; i++) {
                    container.Add(creator(i));
                }
            }
        }

        protected virtual V CreateEmptyVertex(int index) => null;

        protected virtual E CreateEmptyEdge(int index) => null;

        private void Adjust(int expected) {
            AdjustContainer(ref vertices, expected, CreateEmptyVertex);
            AdjustContainer(ref edges, expected * expected, CreateEmptyEdge);
        }

        private List<E> CreateEmptyEdgeList(int arg) {
            return new List<E>();
        }

        public override int AddVertex(V vertex) {
            var idx = vertices.Count;
            vertices.Add(vertex);
            return idx;
        }

        public override int IndexOf(V vertex) => vertices.IndexOf(vertex);

        public override V this[int index] {
            get { return vertices[index]; }
            set { vertices[index] = value; }
        }

        public override E this[int @from, int to] => edges[Indexing.IndexOf(from, to, Size)];

        public override void ClearVertices() {
            vertices.Clear();
        }

        public override void ClearEdges() {
            edges.Clear();
        }

        public  void Connect(int @from, int to, E edge) {
            edges[Indexing.IndexOf(from, to, Size)] = edge;
        }

        public override void Disconnect(int @from, int to) {
            var i = Indexing.IndexOf(from, to, Size);
            edges[i] = CreateEmptyEdge(i);
        }

        public override IEnumerable<Tuple<E, int>> EdgesFrom(int i) {
            for (var x = 0; x < Size; x++) {
                for (var y = 0; y < Size; y++) {
                    var idx = Indexing.IndexOf(x, y, Size);

                    var eIdx = Indexing.IndexOf(i, idx, Size);
                    var e = edges[eIdx];
                    if (e != null) {
                        yield return new Tuple<E, int>(e, eIdx);
                    }
                }
            }
        }

        public override IEnumerable<Tuple<E, int>> EdgesTo(int i) {
            for (var x = 0; x < Size; x++) {
                for (var y = 0; y < Size; y++) {
                    var idx = Indexing.IndexOf(x, y, Size);
                    var eIdx = Indexing.IndexOf(idx, i, Size);
                    var e = edges[eIdx];
                    if (e != null) {
                        yield return new Tuple<E, int>(e, eIdx);
                    }
                }
            }
        }

        public override void Clear() {
            ClearEdges();
            ClearVertices();
        }

        public override int Size {
            get { return vertices.Count; }
            set { Adjust(value); }
        }
    }
}