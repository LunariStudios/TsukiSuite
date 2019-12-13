using System;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

namespace Lunari.Tsuki.Graphs {
    public interface IAdjacencyEdge {
        int Destination { get; }
    }

    public interface IAdjacencyVertex<E> where E : IAdjacencyEdge {
        List<E> Neighbors { get; }
    }

    [Serializable]
    public abstract class ListGraph<V, E> : Graph<V, E> where V : IAdjacencyVertex<E> where E : IAdjacencyEdge {
        [SerializeField]
        private List<V> nodes = new List<V>();

        public override void ClearVertices() {
            nodes.Clear();
        }

        public override void ClearEdges() {
            foreach (var vertex in nodes) {
                vertex.Neighbors.Clear();
            }
        }

        public override int IndexOf(V vertex) {
            for (var i = 0; i < nodes.Count; i++) {
                if (ReferenceEquals(nodes[i], vertex)) {
                    return i;
                }
            }

            return -1;
        }

        public override int AddVertex(V vertex) {
            var size = nodes.Count;
            nodes.Add(vertex);
            return size;
        }

        public override V this[int index] {
            get => nodes[index];
            set => nodes[index] = value;
        }

        protected abstract V CreateEmptyVertex();

        public override E this[int @from, int to] {
            get {
                var v = nodes[from];
                foreach (var edge in v.Neighbors) {
                    if (edge.Destination == to) {
                        return edge;
                    }
                }

                return default;
            }
        }

        public void Connect(int vertex, E edge) {
            nodes[vertex].Neighbors.Add(edge);
        }

        public override void Disconnect(int @from, int to) {
            nodes[from].Neighbors.RemoveAll(edge => edge.Destination == to);
        }

        public override IEnumerable<Tuple<E, int>> EdgesFrom(int i) {
            var v = nodes[i];
            foreach (var edge in v.Neighbors) {
                yield return new Tuple<E, int>(edge, edge.Destination);
            }
        }

        public override IEnumerable<Tuple<E, int>> EdgesTo(int i) {
            return from vertex in nodes
                from edge in vertex.Neighbors.Where(edge => edge.Destination == i)
                select new Tuple<E, int>(edge, IndexOf(vertex));
        }

        public override void Clear() {
            nodes.Clear();
        }

        public override int Size {
            get => nodes.Count;
            set {
                if (Size > value) {
                    nodes.RemoveRange(value, nodes.Count - value);
                }

                if (Size < value) {
                    nodes.AddRange(
                        Enumerable.Repeat(
                            CreateEmptyVertex(),
                            value - Size
                        )
                    );
                }
            }
        }
    }
}