using DataStructureLinkedList;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace DataStructureLinkedListTests
{
    [TestClass]
    public class LinkedListTest
    {
        /// <summary>
        /// Given Three Numbers Added Should Return Top
        /// </summary>
        [TestMethod]
        public void GivenThreeNumbersAdded_ShouldReturnTop()
        {
            LinkedList linkedList1 = new LinkedList();
            linkedList1.Add(56);
            linkedList1.Add(30);
            linkedList1.Add(70);
            Assert.AreEqual(56, linkedList1.head.data);
        }

        /// <summary>
        /// Given Three Numbers Appended Should Return Top
        /// </summary>
        [TestMethod]
        public void GivenThreeNumbersAppended_ShouldReturnTop()
        {
            LinkedList linkedList1 = new LinkedList();
            linkedList1.Add(56);
            linkedList1.Add(30);
            linkedList1.Add(70);
            Assert.AreEqual(56, linkedList1.head.data);
        }

        /// <summary>
        /// Given Three Numbers Insert Between Two Should Return Middle Element
        /// </summary>
        [TestMethod]
        public void GivenThreeNumbersInsertBetweenTwo_ShouldReturnMiddleElement()
        {
            LinkedList linkedList1 = new LinkedList();
            linkedList1.Add(56);
            linkedList1.Add(70);
            linkedList1.InsertAtMid(30);
            Assert.AreEqual(30, linkedList1.head.next.data);
        }

        /// <summary>
        /// Given Three Numbers When Delete First Elemnet Should Return Result
        /// </summary>
        [TestMethod]
        public void GivenThreeNumbers_WhenDeleteFirstElemnet_ShouldReturnResult()
        {
            LinkedList linkedList1 = new LinkedList();
            linkedList1.Add(56);
            linkedList1.Add(30);
            linkedList1.Add(70);
            linkedList1.Pop();
            Assert.AreEqual(30, linkedList1.head.data);
        }

        /// <summary>
        /// Given Three Numbers When Delete Last Elemnet Should Return Result
        /// </summary>
        [TestMethod]
        public void GivenThreeNumbers_WhenDeleteLastElemnet_ShouldReturnResult()
        {
            LinkedList linkedList1 = new LinkedList();
            linkedList1.Add(56);
            linkedList1.Add(30);
            linkedList1.Add(70);
            linkedList1.PopLast();
            Assert.AreEqual(56, linkedList1.head.data);
        }

        /// <summary>
        /// Given Three Numbers When Search Element 30 Should Return Position
        /// </summary>
        [TestMethod]
        public void GivenThreeNumbers_WhenSearchElement30_ShouldReturnPosition()
        {
            LinkedList linkedList1 = new LinkedList();
            linkedList1.Add(56);
            linkedList1.Add(30);
            linkedList1.Add(70);
            int position = linkedList1.Search(30);
            Assert.AreEqual(1, position);
        }
    }
}
