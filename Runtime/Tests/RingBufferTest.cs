using System;
using System.Linq;
using Lunari.Tsuki.Runtime.Algorithm;
using NUnit.Framework;
using UnityEngine.TestTools;
using Assert = UnityEngine.Assertions.Assert;

namespace Lunari.Tsuki.Runtime.Tests {
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
            catch (Exception e) {
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
            catch (Exception e) {
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
            catch (Exception e) {
                failed = true;
            }

            Assert.IsTrue(failed, "Expected buffer to underflow, but no exception was thrown");
        }
    }
}