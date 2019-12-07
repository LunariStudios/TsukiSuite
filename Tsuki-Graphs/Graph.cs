using System;
using System.Collections.Generic;

namespace Tsuki.Graphs {
    public abstract class Graph<V, E> {
        public abstract int AddVertex(V vertex);
        public abstract int IndexOf(V vertex);
        public abstract V this[int index] { get; set; }
        public abstract E this[int from, int to] { get; }
        public abstract void ClearVertices();
        public abstract void ClearEdges();
        public abstract void Disconnect(int from, int to);
        public abstract IEnumerable<Tuple<E, int>> EdgesFrom(int i);
        public abstract IEnumerable<Tuple<E, int>> EdgesTo(int i);
        public abstract void Clear();
        public abstract int Size { get; set; }


    }
}