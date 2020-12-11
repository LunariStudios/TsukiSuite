using System;

namespace Lunari.Tsuki.Graphs.Exceptions {
    public class EdgeOutOfRangeException<V, E> : Exception {
        public EdgeOutOfRangeException(
            int from,
            int to,
            Graph<V, E> graph
        ) : base($"Edge {from} -> {to} is out of range of graph {graph} (Has {graph.Size} vertices)") { }
        public EdgeOutOfRangeException(
            int from,
            int to,
            int totalEdges
        ) : base($"Edge {from} -> {to} is out of range of the graph (Has {totalEdges} edges)") { }
    }
}