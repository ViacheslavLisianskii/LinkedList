using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LinkedListExample
{
    [TestClass]
    public class SortOrderTests
    {
        [TestMethod]
        public void EmptyList()
        {
            // arrange
            var linkedList = new LinkedList();

            // assert
            Assert.AreEqual(0, linkedList.Nodes.Count());
        }

        [TestMethod]
        public void CanAddPositiveElement()
        {
            // arrange
            var linkedList = new LinkedList();
            const int value = 13;
            var unsortedList = new List<int> { value };

            // act
            linkedList.AddRange(unsortedList.ToArray());

            // assert
            Assert.AreEqual(1, linkedList.Nodes.Count());
            Assert.AreEqual(value, linkedList.Nodes.FirstOrDefault());
        }

        [TestMethod]
        public void CanAddNegativeElement()
        {
            // arrange
            var linkedList = new LinkedList();
            const int value = -13;
            var unsortedList = new List<int> { value };

            // act
            linkedList.AddRange(unsortedList.ToArray());

            // assert
            Assert.AreEqual(1, linkedList.Nodes.Count());
            Assert.AreEqual(value, linkedList.Nodes.FirstOrDefault());
        }

        [TestMethod]
        public void CanHaveDuplicates()
        {
            // arrange
            var linkedList = new LinkedList();
            var unsortedList = new List<int> { 1, 1 };

            // act
            linkedList.AddRange(unsortedList.ToArray());

            // assert
            Assert.AreEqual(2, linkedList.Nodes.Count());
        }

        [TestMethod]
        public void SortOrderOfAnyNumbers()
        {
            // arrange
            var linkedList = new LinkedList();
            var unsortedList = new List<int> { -1, -8, 10, 5, 7 };

            // act
            linkedList.AddRange(unsortedList.ToArray());
            var items = linkedList.Nodes;

            // assert
            Assert.IsTrue(items.SequenceEqual(unsortedList.OrderBy(i => i)));
        }
    }
}