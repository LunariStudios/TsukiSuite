using System;
using System.Collections.Generic;
using System.Linq;
using Lunari.Tsuki.Runtime;
using UnityEngine.Events;

namespace Lunari.Tsuki.Graphs {
    public delegate float Heuristics(int index, int destination);

    public delegate bool AStarFilter<E>(int from, int to, E edge);

    public static partial class Graphs {
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

        public struct ExplorationCallbacks<V, E> {
            public AStarFilter<E> EdgeFilter;
            public OnDiscoveredCallback<E> OnVisit;
            public OnSelectedCallback<E> OnSelected;
        }
    }

    public sealed class GraphPath<V, E> {
        public GraphPath(Graph<V, E> graph, int[] indices) {
            Graph = graph;
            Indices = indices;
        }

        public int[] Indices { get; }

        public void Using(
            UnityAction<int, int, E> block
        ) {
            Using((from, to) => block(from, to, Graph[from, to]));
        }

        public void Using(
            UnityAction<int, int> block
        ) {
            for (var i = 0; i < Indices.Length - 1; i++) {
                var current = Indices[i];
                var next = Indices[i + 1];
                block(current, next);
            }
        }

        public Graph<V, E> Graph { get; }

        public IEnumerable<V> Vertices => Indices.Select(index => Graph[index]);

        public IEnumerable<E> Edges {
            get {
                for (var i = 0; i < Indices.Length - 1; i++) {
                    var current = Indices[i];
                    var next = Indices[i + 1];
                    yield return Graph[current, next];
                }
            }
        }

        public E Edge(int index) {
            return Graph[Indices[index], Indices[index + 1]];
        }

        public V Vertex(int index) {
            return Graph[Indices[index]];
        }

        public bool IsLast(int current) {
            return current == Indices.Length - 1;
        }
    }

    public class GraphPlan<V, E> {
        private int current;

        public UnityEvent OnCurrentChanged { get; } = new UnityEvent();
        public UnityEvent OnReloaded { get; } = new UnityEvent();
        private GraphPath<V, E> currentPath;


        public GraphPath<V, E> CurrentPath => currentPath;

        public int CurrentIndex => CurrentPath.Indices[current];

        public int NextIndex {
            get {
                if (CurrentPath.IsLast(current)) {
                    return -1;
                }

                return CurrentPath.Indices[current + 1];
            }
        }

        public V Vertex(int index) {
            return currentPath.Vertex(index);
        }

        public E Edge(int index) {
            return currentPath.Edge(index);
        }

        public V CurrentVertex => currentPath.Graph[CurrentIndex];

        public V NextVertex {
            get {
                var next = NextIndex;
                return next == -1 ? default : Vertex(next);
            }
        }

        public E CurrentEdge => Edge(Current);

        public E NextEdge {
            get {
                var next = NextIndex;
                return next == -1 ? default : Edge(next);
            }
        }

        public bool IsLast(int index) {
            return currentPath.IsLast(index);
        }

        public bool IsAtLast() {
            return IsLast(current);
        }

        public GraphPlan(GraphPath<V, E> currentPath, int current = 0) {
            this.currentPath = currentPath;
            this.current = current;
        }

        public void Reload(GraphPath<V, E> path) {
            if (path == currentPath) {
                return;
            }

            currentPath = path;
            Current = 0;
            OnReloaded.Invoke();
        }

        public int Current {
            get => current;
            set {
                if (current == value) {
                    return;
                }

                var max = currentPath.Indices.Length - 1;
                if (current < 0 || current > max) {
                    throw new ArgumentOutOfRangeException(nameof(value), "Index must be between 0 and " + max);
                }

                current = value;
                OnCurrentChanged.Invoke();
            }
        }
    }
}