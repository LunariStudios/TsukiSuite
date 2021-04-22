using System;
using System.Collections;
using System.Collections.Generic;

namespace Lunari.Tsuki.Runtime.Algorithm {
    public class Tree<K, V> : IEnumerable<Tree<K, V>.Node> {
        public class Node {
            public Dictionary<K, Node> Children { get; } = new Dictionary<K, Node>();

            public Node(V value) {
                Value = value;
            }

            public V Value { get; }

            public Node AddChild(K key, V value) {
                return Children[key] = new Node(value);
            }

            public Node GetChildNode(K key) {
                return Children.TryGetValue(key, out var result) ? result : null;
            }

            public V this[K key] => GetChildNode(key).Value;
        }

        public Node Root { get; }

        public Tree(V rootValue = default) {
            Root = new Node(rootValue);
        }

        public IEnumerator<Node> GetEnumerator() {
            IEnumerable<Node> Recurse(Node node) {
                yield return node;
                foreach (var child in node.Children) {
                    foreach (var del in Recurse(child.Value)) {
                        yield return del;
                    }
                }
            }

            return Recurse(Root).GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator() {
            return GetEnumerator();
        }
    }

    public static class Trees {
        public static void Explore<K, V>(
            this Tree<K, V> tree,
            Action<K, Tree<K, V>.Node> onEnter,
            Action<K, Tree<K, V>.Node> onExit
        ) {
            void Recurse(K entry, Tree<K, V>.Node node) {
                onEnter(entry, node);
                foreach (var child in node.Children) {
                    Recurse(child.Key, child.Value);
                }

                onExit(entry, node);
            }

            Recurse(default, tree.Root);
        }

        public static void ExploreWithPath<K, V>(
            this Tree<K, V> tree,
            Action<Stack<K>, Tree<K, V>.Node> onEnter,
            Action<Stack<K>, Tree<K, V>.Node> onExit
        ) {
            var stack = new Stack<K>();
            tree.Explore(delegate(K k, Tree<K, V>.Node node) {
                stack.Push(k);
                onEnter(stack, node);
            }, delegate(K k, Tree<K, V>.Node node) {
                stack.Pop();
                onExit(stack, node);
            });
        }

        private static IEnumerable<string> Separate(string slashSeparatedKey) {
            return slashSeparatedKey.Split('/');
        }

        public static V Find<V>(this Tree<string, V> tree, string slashSeparatedKey) {
            return tree.Find(Separate(slashSeparatedKey));
        }

        public static V Find<V>(this Tree<string, V> tree, IEnumerable<string> segments) {
            return tree.FindNode(segments).Value;
        }

        public static V FindOrCreate<V>(this Tree<string, V> tree, string slashSeparatedKey) where V : new() {
            return tree.FindOrCreateNode(Separate(slashSeparatedKey)).Value;
        }

        public static Tree<string, V>.Node FindOrCreateNode<V>(this Tree<string, V> tree, IEnumerable<string> segments)
            where V : new() {
            var current = tree.Root;
            foreach (var segment in segments) {
                var candidate = current.GetChildNode(segment) ?? current.AddChild(segment, new V());
                current = candidate;
            }

            return current;
        }

        public static Tree<string, V>.Node FindNode<V>(this Tree<string, V> tree, IEnumerable<string> segments) {
            var current = tree.Root;
            foreach (var segment in segments) {
                var candidate = current.GetChildNode(segment);
                if (candidate == null) {
                    return default;
                }

                current = candidate;
            }

            return current;
        }
    }
}