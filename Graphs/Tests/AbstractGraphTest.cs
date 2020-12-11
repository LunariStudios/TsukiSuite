using NUnit.Framework;
using Assert = UnityEngine.Assertions.Assert;

namespace Lunari.Tsuki.Graphs.Tests {
    public abstract class AbstractGraphTest<G> where G : Graph<string, int> {
        protected readonly G map;
        protected readonly int first;
        protected readonly int second;
        protected readonly int third;
        private const int FirstDistance = 10;
        private const int SecondDistance = 20;
        private const int ThirdDistance = 40;

        public AbstractGraphTest() {
            map = CreateGraph();
            first = AddVertex(map, "Step 1");
            second = AddVertex(map, "Step 2");
            third = AddVertex(map, "Step 3");
            map.Connect(first, second, FirstDistance);
            map.Connect(second, third, SecondDistance);
            map.Connect(first, third, ThirdDistance);
        }

        protected abstract int AddVertex(G graph, string label);

        protected abstract G CreateGraph();

        [Test]
        public void PersistencyTest() {
            Assert.AreEqual("Step 1", map[first]);
            Assert.AreEqual("Step 2", map[second]);
            Assert.AreEqual("Step 3", map[third]);
            Assert.AreEqual(FirstDistance, map[first, second]);
            Assert.AreEqual(SecondDistance, map[second, third]);
            Assert.AreEqual(ThirdDistance, map[first, third]);
        }

      
    }
}