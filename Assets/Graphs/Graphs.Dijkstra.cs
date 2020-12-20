namespace Lunari.Tsuki.Graphs {
    public static partial class Graphs {
        public static bool Dijkstra<V, E>(
            this Graph<V, E> graph,
            int from,
            int to,
            WeightCalculator<E> calculator,
            out GraphPath<V, E> path,
            ExplorationCallbacks<V, E> callbacks = default
        ) {
            return graph.AStar(from, to, ZeroHeuristics, calculator, out path, callbacks);
        }


        public static bool DijkstraWithPlan<V, E>(
            this Graph<V, E> graph,
            int from,
            int to,
            WeightCalculator<E> calculator,
            out GraphPlan<V, E> path,
            ExplorationCallbacks<V, E> callbacks = default
        ) {
            return graph.AStarWithPlan(from, to, ZeroHeuristics, calculator, out path, callbacks);
        }
    }
}