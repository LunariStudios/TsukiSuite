namespace Tsuki.Graphs {
    public abstract class Graph<V, E> {
        public abstract int AddVertex(V vertex);
        public abstract V this[int index] { get; }
        public abstract void Connect(int from, int to, E edge);

        public void ConnectBoth(int one, int other, E edge) {
            Connect(one, other, edge);
            Connect(other, one, edge);
        }
    }
}