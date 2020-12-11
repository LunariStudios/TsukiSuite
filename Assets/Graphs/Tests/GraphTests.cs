using System.Collections;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;
using Assert = UnityEngine.Assertions.Assert;

namespace Lunari.Tsuki.Graphs.Tests {
    public class AdjacencyListTest : AbstractGraphTest<AdjacencyList<string, int>> {
        protected override int AddVertex(AdjacencyList<string, int> graph, string label) {
            return graph.AddVertex(label);
        }

        [Test]
        public void AStarTest() {
            Assert.IsTrue(map.AStar(
                first,
                third,
                Graphs.ZeroHeuristics,
                out var path
            ));
            Assert.IsNotNull(path);

            var expected = new[] {first, second, third};
            for (var i = 0; i < path.Indices.Length; i++) {
                Assert.AreEqual(expected[i], path.Indices[i]);
            }
        }

        protected override AdjacencyList<string, int> CreateGraph() {
            return new AdjacencyList<string, int>();
        }
    }

    public class AdjacencyMatrixTest : AbstractGraphTest<AdjacencyMatrix<string, int>> {
        private int currentVert = 0;

        protected override int AddVertex(AdjacencyMatrix<string, int> graph, string label) {
            graph[currentVert++] = label;
            return currentVert - 1;
        }

        protected override AdjacencyMatrix<string, int> CreateGraph() {
            return new AdjacencyMatrix<string, int>(3);
        }
    }
}