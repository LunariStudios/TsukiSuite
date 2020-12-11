using System;
using System.Collections.Generic;
using System.Linq;
using Lunari.Tsuki.Runtime;
using UnityEngine.Events;

namespace Lunari.Tsuki.Graphs {
    public static partial class Graphs {
        public delegate float Heuristics<V, E>(int index, int destination);

        public delegate bool AStarFilter<E>(int from, int to, E edge);

        public static float ZeroHeuristics(int index, int destination) => 0;

        /// <summary>
        /// Called when a vertex is discovered after checking a vertex's neighbors 
        /// </summary>
        public delegate void OnDiscoveredCallback<E>(int from, int to, E edge);

        /// <summary>
        /// 
        /// </summary>
        public delegate void OnSelectedCallback<E>(int from, int to, E edge);

        public delegate float WeightCalculator<E>(int from, int to, E edge);

        public struct AStarCallbacks<V, E> {
            public AStarFilter<E> EdgeFilter;
            public OnDiscoveredCallback<E> OnVisit;
            public OnSelectedCallback<E> OnSelected;
        }

        public static bool AStar<V, E>(
            this Graph<V, E> graph,
            int from,
            int to,
            Heuristics<V, E> heuristics,
            out GraphPath<V, E> path,
            AStarCallbacks<V, E> callbacks = default
        ) where E : IWeighted<float> {
            return graph.AStar(from, to, heuristics, (i, to1, edge) => edge.Weight, out path, callbacks);
        }

        public static bool AStar<V>(
            this Graph<V, int> graph,
            int from,
            int to,
            Heuristics<V, int> heuristics,
            out GraphPath<V, int> path,
            AStarCallbacks<V, int> callbacks = default
        ) {
            return graph.AStar(from, to, heuristics, (i, to1, edge) => edge, out path, callbacks);
        }

        public static bool AStar<V>(
            this Graph<V, float> graph,
            int from,
            int to,
            Heuristics<V, float> heuristics,
            out GraphPath<V, float> path,
            AStarCallbacks<V, float> callbacks = default
        ) {
            return graph.AStar(from, to, heuristics, (i, to1, edge) => edge, out path, callbacks);
        }


        public static bool AStar<V>(
            this Graph<V, double> graph,
            int from,
            int to,
            Heuristics<V, double> heuristics,
            out GraphPath<V, double> path,
            AStarCallbacks<V, double> callbacks = default
        ) {
            return graph.AStar(from, to, heuristics, (i, to1, edge) => (float) edge, out path, callbacks);
        }

        public static bool AStar<V, E>(
            this Graph<V, E> graph,
            int from,
            int to,
            Heuristics<V, E> heuristics,
            WeightCalculator<E> calculator,
            out GraphPath<V, E> path,
            AStarCallbacks<V, E> callbacks = default
        ) {
            var gScore = new Dictionary<int, float> {
                {from, 0}
            };
            var fScore = new Dictionary<int, float> {
                {from, heuristics(from, to)}
            };
            var open = new SortedSet<int>(Comparer<int>.Create((first, second) => {
                var a = fScore[first];
                var b = fScore[second];
                return a.CompareTo(b);
            })) {
                from
            };

            var history = new Dictionary<int, int>();
            while (!open.IsEmpty()) {
                var i = open.First();
                if (i == to) {
                    path = ReTrace(history, i, graph);
                    return true;
                }

                open.Remove(i);
                var edges = graph.EdgesFrom(i).ToArray();
                foreach (var (edge, neighborIndex) in edges) {
                    callbacks.OnVisit?.Invoke(i, neighborIndex, edge);
                    var found = callbacks.EdgeFilter?.Invoke(i, neighborIndex, edge);
                    if (!found.GetValueOrDefault(true)) {
                        continue;
                    }

                    var attempt = gScore[i] + calculator(i, neighborIndex, edge);
                    if (!gScore.ContainsKey(neighborIndex) || attempt < gScore[neighborIndex]) {
                        history[neighborIndex] = i;
                        gScore[neighborIndex] = attempt;
                        fScore[neighborIndex] = attempt + heuristics(neighborIndex, to);
                        callbacks.OnSelected?.Invoke(i, neighborIndex, edge);
                        if (!open.Contains(neighborIndex)) {
                            open.Add(neighborIndex);
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