using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
#if ODIN_INSPECTOR
using Sirenix.OdinInspector;

#endif
namespace Lunari.Tsuki.Algorithm {
    public class RingBuffer<T> : IEnumerable<T> {
#if ODIN_INSPECTOR
        [ShowInInspector, ReadOnly]
#endif
        private readonly T[] buffer;
#if ODIN_INSPECTOR
        [ShowInInspector, ReadOnly]
#endif
        private int head;
#if ODIN_INSPECTOR
        [ShowInInspector, ReadOnly]
#endif
        private int tail;

        public RingBuffer(int size) {
            if (size == 0) {
                throw new ArgumentException("Cannot create an empty ring buffer!");
            }

            buffer = new T[size];
            head = 0;
            tail = 0;
            Count = 0;
        }

        public IEnumerator<T> GetEnumerator() {
            for (var i = 0; i < Count; i++) {
                yield return buffer[(tail + i) % buffer.Length];
            }
        }

        public T Peek(int offset) {
            var i = tail + offset;
            if (i > Count) {
                i %= Count;
            }

            return buffer[i];
        }

        public T PeekHead(int indexBack) {
            var ptr = head - indexBack;

            if (ptr < 0) {
                ptr += Count;
            }

            return buffer[ptr];
        }

        public T PeekTail(int indexForward) {
            var ptr = tail + indexForward;

            if (ptr >= Count) {
                ptr %= Count;
            }

            return buffer[ptr];
        }

        IEnumerator IEnumerable.GetEnumerator() {
            return GetEnumerator();
        }

        public void Push(T item) {
            if (IsFull) {
                throw new OverflowException("Ring buffer is full!");
            }

            buffer[head++] = item;
            CheckOverflow(ref head);
            Count++;
        }

        private void CheckOverflow(ref int i) {
            if (i >= buffer.Length) {
                i = 0;
            }
        }

        public T Pop() {
            if (IsEmpty) {
                throw new OverflowException("Ring buffer is empty!");
            }

            var value = buffer[tail++];
            CheckOverflow(ref tail);
            Count--;
            return value;
        }

        public void Clear() {
            Array.Clear(buffer, 0, buffer.Length);
            head = 0;
            tail = 0;
        }

        public bool Contains(T item) {
            return buffer.Contains(item);
        }

        public void CopyTo(T[] array, int arrayIndex) {
            var asArr = this.ToArray();
            for (var i = arrayIndex; i < array.Length; i++) {
                array[i] = asArr[i];
            }
        }

        public bool IsFull => Count == buffer.Length;
        public bool IsEmpty => Count == 0;

        public int Count {
            get;
            private set;
        }

        public void LoopPush(T value) {
            if (IsFull) {
                Pop();
            }
            Push(value);
        }
    }
}