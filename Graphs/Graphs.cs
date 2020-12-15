using System;
using System.Collections.Generic;
using System.Linq;
using Lunari.Tsuki.Runtime;
using UnityEngine;
using UnityEngine.Events;

namespace Lunari.Tsuki.Graphs {
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

    public class GraphPathNavigator<V, E> {
        private int current;
        public UnityEvent onCurrentChanged, onReloaded;
        private GraphPath<V, E> currentPath;

        public GraphPath<V, E> CurrentPath => currentPath;

        public GraphPathNavigator(GraphPath<V, E> currentPath, int current = 0) {
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