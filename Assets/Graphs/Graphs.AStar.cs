using System;
using System.Collections.Generic;
using System.Linq;
using Lunari.Tsuki.Runtime;
using Unity.Jobs;

namespace Lunari.Tsuki.Graphs {
    public static partial class Graphs {

        public static bool AStarWithPlan<V, E>(
            this Graph<V, E> graph,
            int from,
            int to,
            Heuristics heuristics,
            WeightCalculator<E> weightCalculator,
            out GraphPlan<V, E> navigator,
            ExplorationCallbacks<V, E> callbacks = default
        ) {
            if (graph.AStar(from, to, heuristics, weightCalculator, out var path, callbacks)) {
                navigator = new GraphPlan<V, E>(path);
                return true;
            }

            navigator = default;
            return false;
        }


        public static bool AStar<V>(
            this Graph<V, int> graph,
            int from,
            int to,
            Heuristics heuristics,
            out GraphPath<V, int> path,
            ExplorationCallbacks<V, int> callbacks = default
        ) {
            return graph.AStar(from, to, heuristics, (i, to1, edge) => edge, out path, callbacks);
        }

        public static bool AStar<V>(
            this Graph<V, float> graph,
            int from,
            int to,
            Heuristics heuristics,
            out GraphPath<V, float> path,
            ExplorationCallbacks<V, float> callbacks = default
        ) {
            return graph.AStar(from, to, heuristics, (i, to1, edge) => edge, out path, callbacks);
        }


        public static bool AStar<V>(
            this Graph<V, double> graph,
            int from,
            int to,
            Heuristics heuristics,
            out GraphPath<V, double> path,
            ExplorationCallbacks<V, double> callbacks = default
        ) {
            return graph.AStar(from, to, heuristics, (i, to1, edge) => (float) edge, out path, callbacks);
        }

        public static bool AStar<V, E>(
            this Graph<V, E> graph,
            int from,
            int to,
            Heuristics heuristics,
            WeightCalculator<E> calculator,
            out GraphPath<V, E> path,
            ExplorationCallbacks<V, E> callbacks = default
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