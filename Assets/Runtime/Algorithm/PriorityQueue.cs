using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using UnityEngine;
using Debug = System.Diagnostics.Debug;
namespace Lunari.Tsuki.Algorithm {
    [DebuggerDisplay("Count = {Count}")]
    public class PriorityQueue<TElement, TPriority> {
        private (TElement Element, TPriority Priority)[] _nodes;


        private readonly IComparer<TPriority> _comparer;


        private UnorderedItemsCollection _unorderedItems;


        private int _size;


        private int _version;


        private const int Arity = 4;


        private const int Log2Arity = 2;

#if DEBUG
        static PriorityQueue() {
            Debug.Assert(Log2Arity > 0 && Mathf.Approximately((float)Math.Pow(2, Log2Arity), Arity));
        }
#endif


        public PriorityQueue() {
            _nodes = Array.Empty<(TElement, TPriority)>();
            _comparer = InitializeComparer(null);
        }


        public PriorityQueue(int initialCapacity)
            : this(initialCapacity, comparer: null) { }


        public PriorityQueue(IComparer<TPriority> comparer) {
            _nodes = Array.Empty<(TElement, TPriority)>();
            _comparer = InitializeComparer(comparer);
        }


        public PriorityQueue(int initialCapacity, IComparer<TPriority> comparer) {
            if (initialCapacity < 0) {
                throw new ArgumentOutOfRangeException();
            }

            _nodes = new (TElement, TPriority)[initialCapacity];
            _comparer = InitializeComparer(comparer);
        }


        public PriorityQueue(IEnumerable<(TElement Element, TPriority Priority)> items)
            : this(items, comparer: null) { }


        public PriorityQueue(
            IEnumerable<(TElement Element, TPriority Priority)> items,
            IComparer<TPriority> comparer
        ) {
            if (items is null) {
                throw new ArgumentNullException(nameof(items));
            }

            _nodes = items.ToArray();
            _size = _nodes.Length;
            _comparer = InitializeComparer(comparer);

            if (_size > 1) {
                Heapify();
            }
        }


        public int Count => _size;


        public IComparer<TPriority> Comparer => _comparer ?? Comparer<TPriority>.Default;


        public UnorderedItemsCollection UnorderedItems => _unorderedItems ??= new UnorderedItemsCollection(this);


        public void Enqueue(TElement element, TPriority priority) {
            int currentSize = _size++;
            _version++;

            if (_nodes.Length == currentSize) {
                Grow(currentSize + 1);
            }

            if (_comparer == null) {
                MoveUpDefaultComparer((element, priority), currentSize);
            } else {
                MoveUpCustomComparer((element, priority), currentSize);
            }
        }


        public TElement Peek() {
            if (_size == 0) {
                throw new InvalidOperationException();
            }

            return _nodes[0].Element;
        }


        public TElement Dequeue() {
            if (_size == 0) {
                throw new InvalidOperationException();
            }

            TElement element = _nodes[0].Element;
            RemoveRootNode();
            return element;
        }


        public bool TryDequeue(
            out TElement element,
            out TPriority priority
        ) {
            if (_size != 0) {
                (element, priority) = _nodes[0];
                RemoveRootNode();
                return true;
            }

            element = default;
            priority = default;
            return false;
        }


        public bool TryPeek(
            out TElement element,
            out TPriority priority
        ) {
            if (_size != 0) {
                (element, priority) = _nodes[0];
                return true;
            }

            element = default;
            priority = default;
            return false;
        }


        public TElement EnqueueDequeue(TElement element, TPriority priority) {
            if (_size != 0) {
                (TElement Element, TPriority Priority) root = _nodes[0];

                if (_comparer == null) {
                    if (Comparer<TPriority>.Default.Compare(priority, root.Priority) > 0) {
                        MoveDownDefaultComparer((element, priority), 0);
                        _version++;
                        return root.Element;
                    }
                } else {
                    if (_comparer.Compare(priority, root.Priority) > 0) {
                        MoveDownCustomComparer((element, priority), 0);
                        _version++;
                        return root.Element;
                    }
                }
            }

            return element;
        }


        public void EnqueueRange(IEnumerable<(TElement Element, TPriority Priority)> items) {
            if (items is null) {
                throw new ArgumentNullException(nameof(items));
            }

            int count = 0;
            var collection = items as ICollection<(TElement Element, TPriority Priority)>;
            if (collection != null && (count = collection.Count) > _nodes.Length - _size) {
                Grow(_size + count);
            }

            if (_size == 0) {
                if (collection != null) {
                    collection.CopyTo(_nodes, 0);
                    _size = count;
                } else {
                    int i = 0;
                    (TElement, TPriority)[] nodes = _nodes;
                    foreach ((TElement element, TPriority priority) in items) {
                        if (nodes.Length == i) {
                            Grow(i + 1);
                            nodes = _nodes;
                        }

                        nodes[i++] = (element, priority);
                    }

                    _size = i;
                }

                _version++;

                if (_size > 1) {
                    Heapify();
                }
            } else {
                foreach ((TElement element, TPriority priority) in items) {
                    Enqueue(element, priority);
                }
            }
        }


        public void EnqueueRange(IEnumerable<TElement> elements, TPriority priority) {
            if (elements is null) {
                throw new ArgumentNullException(nameof(elements));
            }

            int count;
            if (elements is ICollection<(TElement Element, TPriority Priority)> collection &&
                (count = collection.Count) > _nodes.Length - _size) {
                Grow(_size + count);
            }

            if (_size == 0) {
                int i = 0;
                (TElement, TPriority)[] nodes = _nodes;
                foreach (TElement element in elements) {
                    if (nodes.Length == i) {
                        Grow(i + 1);
                        nodes = _nodes;
                    }

                    nodes[i++] = (element, priority);
                }

                _size = i;
                _version++;

                if (i > 1) {
                    Heapify();
                }
            } else {
                foreach (TElement element in elements) {
                    Enqueue(element, priority);
                }
            }
        }


        public void Clear() {
            Array.Clear(_nodes, 0, _size);
            _size = 0;
            _version++;
        }


        public int EnsureCapacity(int capacity) {
            if (capacity < 0) {
                throw new ArgumentOutOfRangeException();
            }

            if (_nodes.Length < capacity) {
                Grow(capacity);
                _version++;
            }

            return _nodes.Length;
        }


        public void TrimExcess() {
            int threshold = (int)(_nodes.Length * 0.9);
            if (_size < threshold) {
                Array.Resize(ref _nodes, _size);
                _version++;
            }
        }


        private void Grow(int minCapacity) {
            Debug.Assert(_nodes.Length < minCapacity);

            const int GrowFactor = 2;
            const int MinimumGrow = 4;

            var newcapacity = GrowFactor * _nodes.Length;

            newcapacity = Math.Max(newcapacity, _nodes.Length + MinimumGrow);


            if (newcapacity < minCapacity) newcapacity = minCapacity;

            Array.Resize(ref _nodes, newcapacity);
        }


        private void RemoveRootNode() {
            int lastNodeIndex = --_size;
            _version++;

            if (lastNodeIndex > 0) {
                (TElement Element, TPriority Priority) lastNode = _nodes[lastNodeIndex];
                if (_comparer == null) {
                    MoveDownDefaultComparer(lastNode, 0);
                } else {
                    MoveDownCustomComparer(lastNode, 0);
                }
            }

            _nodes[lastNodeIndex] = default;
        }


        private int GetParentIndex(int index) => (index - 1) >> Log2Arity;


        private int GetFirstChildIndex(int index) => (index << Log2Arity) + 1;


        private void Heapify() {
            (TElement Element, TPriority Priority)[] nodes = _nodes;
            int lastParentWithChildren = GetParentIndex(_size - 1);

            if (_comparer == null) {
                for (int index = lastParentWithChildren; index >= 0; --index) {
                    MoveDownDefaultComparer(nodes[index], index);
                }
            } else {
                for (int index = lastParentWithChildren; index >= 0; --index) {
                    MoveDownCustomComparer(nodes[index], index);
                }
            }
        }


        private void MoveUpDefaultComparer((TElement Element, TPriority Priority) node, int nodeIndex) {
            Debug.Assert(_comparer is null);
            Debug.Assert(0 <= nodeIndex && nodeIndex < _size);

            (TElement Element, TPriority Priority)[] nodes = _nodes;

            while (nodeIndex > 0) {
                int parentIndex = GetParentIndex(nodeIndex);
                (TElement Element, TPriority Priority) parent = nodes[parentIndex];

                if (Comparer<TPriority>.Default.Compare(node.Priority, parent.Priority) < 0) {
                    nodes[nodeIndex] = parent;
                    nodeIndex = parentIndex;
                } else {
                    break;
                }
            }

            nodes[nodeIndex] = node;
        }


        private void MoveUpCustomComparer((TElement Element, TPriority Priority) node, int nodeIndex) {
            Debug.Assert(_comparer != null);
            Debug.Assert(0 <= nodeIndex && nodeIndex < _size);

            IComparer<TPriority> comparer = _comparer;
            (TElement Element, TPriority Priority)[] nodes = _nodes;

            while (nodeIndex > 0) {
                int parentIndex = GetParentIndex(nodeIndex);
                (TElement Element, TPriority Priority) parent = nodes[parentIndex];

                if (comparer.Compare(node.Priority, parent.Priority) < 0) {
                    nodes[nodeIndex] = parent;
                    nodeIndex = parentIndex;
                } else {
                    break;
                }
            }

            nodes[nodeIndex] = node;
        }


        private void MoveDownDefaultComparer((TElement Element, TPriority Priority) node, int nodeIndex) {
            Debug.Assert(_comparer is null);
            Debug.Assert(0 <= nodeIndex && nodeIndex < _size);

            (TElement Element, TPriority Priority)[] nodes = _nodes;
            int size = _size;

            int i;
            while ((i = GetFirstChildIndex(nodeIndex)) < size) {
                (TElement Element, TPriority Priority) minChild = nodes[i];
                int minChildIndex = i;

                int childIndexUpperBound = Math.Min(i + Arity, size);
                while (++i < childIndexUpperBound) {
                    (TElement Element, TPriority Priority) nextChild = nodes[i];
                    if (Comparer<TPriority>.Default.Compare(nextChild.Priority, minChild.Priority) < 0) {
                        minChild = nextChild;
                        minChildIndex = i;
                    }
                }


                if (Comparer<TPriority>.Default.Compare(node.Priority, minChild.Priority) <= 0) {
                    break;
                }


                nodes[nodeIndex] = minChild;
                nodeIndex = minChildIndex;
            }

            nodes[nodeIndex] = node;
        }


        private void MoveDownCustomComparer((TElement Element, TPriority Priority) node, int nodeIndex) {
            IComparer<TPriority> comparer = _comparer;
            (TElement Element, TPriority Priority)[] nodes = _nodes;
            int size = _size;

            int i;
            while ((i = GetFirstChildIndex(nodeIndex)) < size) {
                (TElement Element, TPriority Priority) minChild = nodes[i];
                int minChildIndex = i;

                int childIndexUpperBound = Math.Min(i + Arity, size);
                while (++i < childIndexUpperBound) {
                    (TElement Element, TPriority Priority) nextChild = nodes[i];
                    if (comparer.Compare(nextChild.Priority, minChild.Priority) < 0) {
                        minChild = nextChild;
                        minChildIndex = i;
                    }
                }


                if (comparer.Compare(node.Priority, minChild.Priority) <= 0) {
                    break;
                }


                nodes[nodeIndex] = minChild;
                nodeIndex = minChildIndex;
            }

            nodes[nodeIndex] = node;
        }


        private static IComparer<TPriority> InitializeComparer(IComparer<TPriority> comparer) {
            if (typeof(TPriority).IsValueType) {
                if (comparer == Comparer<TPriority>.Default) {
                    return null;
                }

                return comparer;
            }
            return comparer ?? Comparer<TPriority>.Default;
        }

        public sealed class UnorderedItemsCollection : IReadOnlyCollection<(TElement Element, TPriority Priority)>,
            ICollection {
            internal readonly PriorityQueue<TElement, TPriority> _queue;

            internal UnorderedItemsCollection(PriorityQueue<TElement, TPriority> queue) => _queue = queue;

            public int Count => _queue._size;
            object ICollection.SyncRoot => this;
            bool ICollection.IsSynchronized => false;

            void ICollection.CopyTo(Array array, int index) {
                if (array is null) {
                    throw new ArgumentNullException(nameof(array));
                }

                if (array.Rank != 1) {
                    throw new ArgumentException();
                }

                if (array.GetLowerBound(0) != 0) {
                    throw new ArgumentException();
                }

                if (index < 0 || index > array.Length) {
                    throw new ArgumentOutOfRangeException(nameof(index), index, "");
                }

                if (array.Length - index < _queue._size) {
                    throw new ArgumentException();
                }

                try {
                    Array.Copy(_queue._nodes, 0, array, index, _queue._size);
                }
                catch (ArrayTypeMismatchException) {
                    throw new ArgumentException();
                }
            }

            public struct Enumerator : IEnumerator<(TElement Element, TPriority Priority)> {
                private readonly PriorityQueue<TElement, TPriority> _queue;
                private readonly int _version;
                private int _index;
                private (TElement, TPriority) _current;

                internal Enumerator(PriorityQueue<TElement, TPriority> queue) {
                    _queue = queue;
                    _index = 0;
                    _version = queue._version;
                    _current = default;
                }

                public void Dispose() { }

                public bool MoveNext() {
                    PriorityQueue<TElement, TPriority> localQueue = _queue;

                    if (_version == localQueue._version && ((uint)_index < (uint)localQueue._size)) {
                        _current = localQueue._nodes[_index];
                        _index++;
                        return true;
                    }

                    return MoveNextRare();
                }

                private bool MoveNextRare() {
                    if (_version != _queue._version) {
                        throw new InvalidOperationException();
                    }

                    _index = _queue._size + 1;
                    _current = default;
                    return false;
                }

                public (TElement Element, TPriority Priority) Current => _current;

                object IEnumerator.Current => _current;

                void IEnumerator.Reset() {
                    if (_version != _queue._version) {
                        throw new InvalidOperationException();
                    }

                    _index = 0;
                    _current = default;
                }
            }

            public Enumerator GetEnumerator() => new Enumerator(_queue);

            IEnumerator<(TElement Element, TPriority Priority)> IEnumerable<(TElement Element, TPriority Priority)>.
                GetEnumerator() => GetEnumerator();

            IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
        }

        public bool Contains(TElement element) {
            return _nodes.Any(valueTuple => valueTuple.Element.Equals(element));
        }
    }
}