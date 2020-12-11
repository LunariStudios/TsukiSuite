using System;

namespace Lunari.Tsuki.Graphs.Exceptions {
    public class VertexOutOfRangeException<V, E> : Exception {
        public VertexOutOfRangeException(
            int index,
            Graph<V, E> graph
        ) : base($"Vertex {index} is out of range of graph {graph} (Has {graph.Size} vertices)") { }
    }
}