using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using Lunari.Tsuki.Graphs.Exceptions;
using Lunari.Tsuki.Runtime;
using Lunari.Tsuki.Runtime.Exceptions;
using UnityEngine;

namespace Lunari.Tsuki.Graphs {
    [Serializable]
    public class AdjacencyList<V, E> : Graph<V, E> {
        [Serializable]
        public class EdgeDestinationDictionary : SerializableDictionary<int, E> { }

        [Serializable]
        public class Node {
            public V vertex;

            // Use a dictionary for fast lookup
            public EdgeDestinationDictionary outputs;
        }

        [SerializeField]
        private List<Node> nodes = new List<Node>();

        public override void ClearVertices() {
            nodes.Clear();
        }

        public override void ClearEdges() {
            foreach (var vertex in nodes) {
                vertex.outputs?.Clear();
            }
        }

        public override int IndexOf(V vertex) {
            for (var i = 0; i < nodes.Count; i++) {
                if (AreEquals(nodes[i].vertex, vertex)) {
                    return i;
                }
            }

            return -1;
        }

        protected virtual bool AreEquals(V first, V second) {
            return ReferenceEquals(first, second);
        }

        public override int AddVertex(V vertex) {
            var size = nodes.Count;
            nodes.Add(new Node {
                vertex = vertex,
                outputs = new EdgeDestinationDictionary()
            });
            return size;
        }

        public override V this[int index] {
            get => nodes[index].vertex;
            set => nodes[index].vertex = value;
        }


        public override E this[int @from, int to] {
            get {
                var v = nodes[from];
                if (v.outputs.TryGetValue(to, out var edge)) {
                    return edge;
                }

                return default;
            }
        }

        private void CheckVertexBounds(int index) {
            if (IsOutOfBounds(index)) {
                throw new VertexOutOfRangeException<V, E>(index, this);
            }
        }

        private void CheckEdgeBounds(int from, int to) {
            CheckVertexBounds(from);
            CheckVertexBounds(to);
        }

        private Node GetNodeSafely(int index) {
            CheckVertexBounds(index);
            var node = nodes[index];
            if (node.outputs == null) {
                throw new WTFException(
                    $"A node should never have a null 'outputs' dictionary ({index})"
                );
            }

            return node;
        }

        
        private Node GetNodeSafely(int from, int to) {
            CheckEdgeBounds(from, to);

            var node = nodes[from];
            if (node.outputs == null) {
                throw new WTFException(
                    $"A node should never have a null 'outputs' dictionary ({from} -> {to})"
                );
            }

            return node;
        }

        public override void Connect(int from, int to, E edge) {
#if UNITY_EDITOR
            GetNodeSafely(from, to).outputs[to] = edge;
#else
            nodes[from].outputs[to] = edge;
#endif
        }

        public override bool IsOutOfBounds(int vertexIndex) {
            return vertexIndex >= Size || vertexIndex < 0;
        }

        public override void Disconnect(int from, int to) {
#if UNITY_EDITOR
            GetNodeSafely(from, to).outputs.Remove(to);
#else
            nodes[from].outputs.Remove(to);
#endif
        }

        public override IEnumerable<Tuple<E, int>> EdgesFrom(int i) {
            var v = GetNodeSafely(i);
            foreach (var edge in v.outputs) {
                yield return new Tuple<E, int>(edge.Value, edge.Key);
            }
        }

        /// <summary>
        /// Note, this implementation is stupidly slow.
        /// </summary>
        [SuppressMessage("ReSharper", "ForeachCanBePartlyConvertedToQueryUsingAnotherGetEnumerator")]
        [SuppressMessage("ReSharper", "ForeachCanBeConvertedToQueryUsingAnotherGetEnumerator")]
        public override IEnumerable<Tuple<E, int>> EdgesTo(int i) {
            foreach (var vertex in nodes) {
                foreach (var pair in vertex.outputs) {
                    if (pair.Key == i) {
                        yield return new Tuple<E, int>(pair.Value, pair.Key);
                    }
                }
            }
        }

        public override void Clear() {
            nodes.Clear();
        }

        public override int Size {
            get => nodes.Count;
            set {
                var size = Size;
                if (size > value) {
                    nodes.RemoveRange(value, nodes.Count - value);
                }

                if (size < value) {
                    var toAdd = value - size;
                    nodes.Capacity += toAdd;
                    for (var i = 0; i < toAdd; i++) {
                        nodes.Add(new Node {
                            outputs = new EdgeDestinationDictionary(),
                            vertex = default
                        });
                    }
                }
            }
        }
    }
}