using System;
using System.Linq;
using Lunari.Tsuki.Algorithm;
using NUnit.Framework;
using Assert = UnityEngine.Assertions.Assert;

namespace Tsuki.Runtime.Tests.Runtime.Tests {
    public class RingBufferTest {
        private const int BufferSize = 32;

        private RingBuffer<int> BuildBuffer() {
            var buffer = new RingBuffer<int>(BufferSize);

            for (var i = BufferSize / 2; i < BufferSize; i++) {
                buffer.Push(i);
            }

            for (var i = 0; i < BufferSize / 2; i++) {
                buffer.Push(i);
            }

            return buffer;
        }

        [Test]
        public void EnumerableTest() {
            var buffer = BuildBuffer();
            var expected = new int[BufferSize];
            var index = 0;
            for (var i = BufferSize / 2; i < BufferSize; i++) {
                expected[index++] = i;
            }

            for (var i = 0; i < BufferSize / 2; i++) {
                expected[index++] = i;
            }

            var actual = buffer.ToArray();
            Assert.IsTrue(
                expected.SequenceEqual(actual),
                $"Expected: [{string.Join(", ", expected)}] but got [{string.Join(", ", actual)}]"
            );
        }

        [Test]
        public void CreateEmptyBufferTest() {
            var failed = false;
            try {
                new RingBuffer<int>(0);
            }
            catch (Exception) {
                failed = true;
            }

            Assert.IsTrue(failed, "Expected constructor to disallow empty buffer, but no exception was thrown");
        }

        [Test]
        public void OverflowTest() {
            var buffer = BuildBuffer();
            var failed = false;
            try {
                buffer.Push(-1);
            }
            catch (Exception) {
                failed = true;
            }

            Assert.IsTrue(failed, "Expected buffer to overflow, but no exception was thrown");
        }

        [Test]
        public void UnderflowTest() {
            var buffer = new RingBuffer<int>(1);
            var failed = false;
            try {
                buffer.Pop();
            }
            catch (Exception) {
                failed = true;
            }

            Assert.IsTrue(failed, "Expected buffer to underflow, but no exception was thrown");
        }
        [Test]
        public void IsFullTest() {
            const int length = 200;
            var buffer = new RingBuffer<int>(length);
            Assert.IsFalse(buffer.IsFull, "Expected buffer to be empty");
            for (int i = 0; i < length; i++) {
                buffer.Push(i);
            }
            Assert.IsTrue(buffer.IsFull, "Expected buffer to be full");
        }

        [Test]
        public void IsEmptyTest() {
            const int length = 200;
            var buffer = new RingBuffer<int>(length);
            Assert.IsTrue(buffer.IsEmpty, "Expected buffer to be empty");
            for (int i = 0; i < length; i++) {
                buffer.Push(i);
            }
            Assert.IsFalse(buffer.IsEmpty, "Expected buffer to not be empty");
        }
        [Test]
        public void CountTest() {
            const int length = 200;
            var buffer = new RingBuffer<int>(length);
            for (int i = 0; i < length; i++) {
                buffer.Push(i);
                var expectedSize = i + 1;
                Assert.AreEqual(buffer.Count, expectedSize, $"Expected count to be {expectedSize}");
            }
            for (int i = 0; i < length; i++) {
                buffer.LoopPush(i);
                Assert.AreEqual(buffer.Count, length, $"Expected count to be {length} @ {i}");
            }
        }
    }
}