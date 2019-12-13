using System;
using System.Collections.Generic;

namespace Tsuki.Graphs {
    /// <summary>
    /// A simple Graph can be either directed or bidirected. We don't have different classes for directed or
    /// bidirected graphs.
    /// <br/>
    /// It's subclasses must implement different algorithms that supply the functionality of the methods,
    /// described here, notably, using either adjacency matrices (<see cref="MatrixGraph{V,E}"/>) or
    /// adjacency lists (<see cref="ListGraph{V,E}"/>).
    /// <br/>
    /// This class does not include an abstract 'Connect' method as subclasses may have very different ways of
    /// storing edges. If you are looking for such method, look into subclasses of <see cref="Graph{V,E}"/>.
    /// </summary>
    /// <seealso cref="MatrixGraph{V,E}"/>
    /// <seealso cref="ListGraph{V,E}"/>
    /// <typeparam name="V">The type used as vertices.</typeparam>
    /// <typeparam name="E">The type used as edges.</typeparam>
    public abstract class Graph<V, E> {
        /// <summary>
        /// Adds the given vertex to this graph as a disconnected vertex.
        /// </summary>
        /// <returns>The index this vertex holds, which must be used in other methods such as <see cref="Disconnect"/>,
        /// <see cref="EdgesFrom"/>, <see cref="EdgesTo"/>, etc.</returns>
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
        /// <see cref="EdgesFrom"/>, <see cref="EdgesTo"/>, etc.
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

        public abstract void ClearVertices();
        public abstract void ClearEdges();
        public abstract void Disconnect(int from, int to);

        /// <summary>
        /// Returns
        /// </summary>
        public abstract IEnumerable<Tuple<E, int>> EdgesFrom(int i);

        public abstract IEnumerable<Tuple<E, int>> EdgesTo(int i);
        public abstract void Clear();
        public abstract int Size { get; set; }
    }
}