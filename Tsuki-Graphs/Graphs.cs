using System;
using System.Collections.Generic;
using System.Linq;
using Lunari.Tsuki;
using UnityEngine.Events;

namespace Tsuki.Graphs {
    public sealed class GraphPath<V, E> {
        public GraphPath(Graph<V, E> graph, int[] indices) {
            Graph = graph;
            Indices = indices;
        }

        public int[] Indices { get; }

        public void Using(
            UnityAction<Graph<V, E>, int, int, E> block
        ) {
            for (var i = 0; i < Indices.Length - 1; i++) {
                var current = Indices[i];
                var next = Indices[i + 1];
                block(Graph, current, next, Graph[current, next]);
            }
        }

        public Graph<V, E> Graph { get; }

        public IEnumerable<V> Vertices => Indices.Select(index => Graph[index]);

        public IEnumerable<E> Edges {
            get {
                float sum = 0;
                for (var i = 0; i < Indices.Length - 1; i++) {
                    var current = Indices[i];
                    var next = Indices[i + 1];
                    yield return Graph[current, next];
                }
            }
        }
    }

    public static class Graphs {
        public delegate float Heuristics<V, E>(Graph<V, E> graph, int index, int destination);

        public struct AStarCallbacks<V, E> {
            public Func<Graph<V, E>, int, int, E, bool> edgeFilter;
            public UnityAction<Graph<V, E>, int, int, E> onVisit;
            public UnityAction<Graph<V, E>, int, int, E> onSelected;
        }

        public static bool AStar<V, E>(
            this Graph<V, E> graph,
            int from,
            int to,
            Heuristics<V, E> heuristics,
            out GraphPath<V, E> path,
            AStarCallbacks<V, E> callbacks = default
        ) where E : IWeighted<float> {
            var gScore = new Dictionary<int, float> {
                {from, 0}
            };
            var fScore = new Dictionary<int, float> {
                {from, heuristics(graph, from, to)}
            };
            var open = new List<int> {
                from
            };

            var history = new Dictionary<int, int>();
            while (!open.IsEmpty()) {
                var i = open.MinBy(candidate => fScore[candidate]);
                if (i == to) {
                    path = ReTrace(history, i, graph);
                    return true;
                }

                open.Remove(i);
                var edges = graph.EdgesFrom(i).ToArray();
                foreach (var t in edges) {
                    var edge = t.Item1;
                    var ni = t.Item2;
                    callbacks.onVisit?.Invoke(graph, i, ni, edge);
                    var found = callbacks.edgeFilter?.Invoke(graph, i, ni, edge);
                    if (!found.GetValueOrDefault(true)) {
                        continue;
                    }

                    var attempt = gScore[i] + edge.Weight;
                    if (!gScore.ContainsKey(ni) || attempt < gScore[ni]) {
                        history[ni] = i;
                        gScore[ni] = attempt;
                        fScore[ni] = attempt + heuristics(graph, ni, to);
                        callbacks.onSelected?.Invoke(graph, i, ni, edge);
                        if (!open.Contains(ni)) {
                            open.Add(ni);
                        }
                    }
                }
            }

            path = null;
            return false;
        }

        private static GraphPath<V, E> ReTrace<V, E>(
            IDictionary<int, int> history,
            int origin,
            Graph<V, E> graph
        ) {
            var indices = new List<int> {
                origin
            };
            var current = origin;
            while (history.ContainsKey(current)) {
                current = history[current];
                indices.Add(current);
            }

            indices.Reverse();

            return new GraphPath<V, E>(graph, indices.ToArray());
        }
    }
}