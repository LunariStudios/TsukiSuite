using System;
using System.Collections.Generic;
using System.Linq;
using Lunari.Tsuki.Runtime.Algorithm;

namespace Lunari.Tsuki.Graphs {
    /// <summary>
    /// Delegate which selects what the next vertex should explored, removes it from the deque and returns it.
    /// </summary>
    /// <seealso cref="Graphs.DepthFirst"/>
    /// <seealso cref="Graphs.BreadthFirst"/>
    public delegate int ExplorationStrategy(Deque<int> pending);

    public static partial class Graphs {
        public static int DepthFirst(Deque<int> pending) => pending.RemoveBack();

        public static int BreadthFirst(Deque<int> pending) => pending.RemoveFront();

        public static IEnumerable<Tuple<int, int>> Explore<V, E>(
            this Graph<V, E> graph,
            int from,
            ExplorationStrategy strategy
        ) {
            var visited = new HashSet<int>();
            var open = new Deque<int> {
                from
            };

            while (!open.IsEmpty) {
                var current = strategy(open);
                visited.Add(current);
                foreach (var (_, index) in graph.EdgesFrom(current)) {
                    yield return new Tuple<int, int>(current, index);
                    if (!visited.Contains(index)) {
                        open.Add(index);
                    }
                }
            }
        }

        public static IEnumerable<Tuple<int, int>> FindDepthsFrom<V, E>(
            this Graph<V, E> graph,
            int origin,
            ExplorationStrategy strategy
        ) {
            var result = new Dictionary<int, int> {
                [origin] = 0
            };
            foreach (var (from, to) in graph.Explore(origin, strategy)) {
                result[to] = result[from] + 1;
            }

            return result.Select(pair => new Tuple<int, int>(pair.Key, pair.Value));
        }
    }
}