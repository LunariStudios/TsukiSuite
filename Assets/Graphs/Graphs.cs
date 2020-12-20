using System.Collections.Generic;
using System.Linq;
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
            UnityAction<Graph<V, E>, int, int, E> block
        ) {
            for (var i = 0; i < Indices.Length - 1; i++) {
                var current = Indices[i];
                var next = Indices[i + 1];
                block(Graph, current, next, Graph[current, next]);
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
    }

    public class GraphPlan<V, E> {
        private int current;
        public UnityEvent onCurrentChanged, onReloaded;
        private GraphPath<V, E> currentPath;

        public GraphPath<V, E> CurrentPath => currentPath;

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
            onReloaded.Invoke();
        }

        public int Current {
            get => current;
            set {
                if (current == value) {
                    return;
                }

                current = value;
                onCurrentChanged.Invoke();
            }
        }
    }
}