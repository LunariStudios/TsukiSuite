using System;
using System.Collections.Generic;

namespace Lunari.Tsuki.Graphs {
    /// <summary>
    /// A simple Graph can be either directed or bidirected. We don't have different classes for directed or
    /// bidirected graphs.
    /// <br/>
    /// It's subclasses must implement different algorithms that supply the functionality of the methods,
    /// described here, notably, using either adjacency matrices (<see cref="AdjacencyMatrix{V,E}"/>) or
    /// adjacency lists (<see cref="AdjacencyList{V,E}"/>).
    /// <br/>
    /// This class does not include an abstract 'Connect' method as subclasses may have very different ways of
    /// storing edges. If you are looking for such method, look into subclasses of <see cref="Graph{V,E}"/>.
    /// </summary>
    /// <seealso cref="AdjacencyMatrix{V,E}"/>
    /// <seealso cref="AdjacencyList{V,E}"/>
    /// <typeparam name="V">The type used as vertices.</typeparam>
    /// <typeparam name="E">The type used as edges.</typeparam>
    public abstract class Graph<V, E> {
        /// <summary>
        /// Adds the given vertex to this graph as a disconnected vertex.
        /// </summary>
        /// <returns>The index this vertex holds, which must be used in other methods such as <see cref="Disconnect"/>,
        /// <see cref="Connect"/>, <see cref="EdgesFrom"/>, <see cref="EdgesTo"/>, etc.</returns>
        /// <remarks>
        /// The index of the vertex can also be obtained with <see cref="IndexOf"/>, however, it is much more
        /// expensive, so if you plan on manipulating this vertex right after adding it, remember to use the returned value instead of
        /// calling <see cref="IndexOf"/>.
        /// </remarks>
        public abstract int AddVertex(V vertex);

        /// <summary>scp
        /// Returns the index used to reference the provided vertex.
        /// <br/>
        /// The index is mostly used in methods like <see cref="Disconnect"/>,
        /// <see cref="Connect"/>, <see cref="EdgesFrom"/>, <see cref="EdgesTo"/>, etc.
        /// </summary>
        /// <remarks>
        /// Performance may differ between subclasses, but will most likely be <code>O(n)</code>.
        /// </remarks>
        public abstract int IndexOf(V vertex);

        /// <summary>
        /// Returns or sets the vertex referenced by the provided index.
        /// </summary>
        public abstract V this[int index] { get; set; }

        /// <summary>
        /// Returns the edge that connects 'from' to 'to'. 
        /// </summary>
        public abstract E this[int from, int to] { get; }

        /// <summary>
        /// Removes all vertices from this graph.
        /// </summary>
        public abstract void ClearVertices();

        /// <summary>
        /// Removes all edges from this graph.
        /// </summary>
        public abstract void ClearEdges();

        public abstract void Disconnect(int from, int to);

        public abstract void Connect(int from, int to, E edge);
        public abstract bool IsOutOfBounds(int vertexIndex);

        /// <summary>
        /// Each tuple contain
        /// </summary>
        public abstract IEnumerable<Tuple<E, int>> EdgesFrom(int i);

        public abstract IEnumerable<Tuple<E, int>> EdgesTo(int i);

        /// <summary>
        /// Removes all vertices and edges from this graph.
        /// </summary>
        public abstract void Clear();

        public abstract int Size { get; set; }
    }
}