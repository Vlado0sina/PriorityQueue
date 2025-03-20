using System;
using NUnit.Framework;

namespace PriorityQueue.Test
{
    //Test class for PriorityQueue implementation
    [TestFixture]
    class PriorityQueueTests
    {
       //Declare queue variables
       private UnsortedArrayPriorityQueue<string> unsortedArrayPriorityQueue;
       private UnsortedLinkedPriorityQueue<string> unsortedLinkedPriorityQueue;
       private SortedLinkedPriorityQueue<string> sortedLinkedPriorityQueue;
       private HeapPriorityQueue<string> heapPriorityQueue;
       

        [SetUp]

        public void SetUp()
        {
            //Initialize each queue before every test
            unsortedArrayPriorityQueue = new UnsortedArrayPriorityQueue<string> (10);
            unsortedLinkedPriorityQueue = new UnsortedLinkedPriorityQueue<string>();
            sortedLinkedPriorityQueue = new SortedLinkedPriorityQueue<string>();
            heapPriorityQueue = new HeapPriorityQueue<string>();



        }

        [Test]
        public void AddItemToQueueShouldNotBeEmpty()
        {
            //TEst to ensure items are added to each queue
            unsortedArrayPriorityQueue.Add("A", 1);
            Assert.That(unsortedArrayPriorityQueue.IsEmpty(), Is.False);

            unsortedLinkedPriorityQueue.Add("B", 2);
            Assert.That(unsortedLinkedPriorityQueue.IsEmpty(), Is.False);

            sortedLinkedPriorityQueue.Add("C", 3);
            Assert.That(sortedLinkedPriorityQueue.IsEmpty(), Is.False);

            heapPriorityQueue.Add("D", 4);
            Assert.That(heapPriorityQueue.IsEmpty(), Is.False);


        }

        [Test]
        public void HeadShouldReturnHighestPriorityItem()
        {
            //To check if head return highest priority item
            unsortedArrayPriorityQueue.Add("Low", 1);
            unsortedArrayPriorityQueue.Add("Hight", 10);
            Assert.That("Hight", Is.EqualTo(unsortedArrayPriorityQueue.Head()));

            unsortedLinkedPriorityQueue.Add("Low", 1);
            unsortedLinkedPriorityQueue.Add("Hight", 10);
            Assert.That("Hight", Is.EqualTo(unsortedLinkedPriorityQueue.Head()));

            sortedLinkedPriorityQueue.Add("Low", 1);
            sortedLinkedPriorityQueue.Add("Hight", 10);
            Assert.That("Hight", Is.EqualTo(sortedLinkedPriorityQueue.Head()));

            heapPriorityQueue.Add("Low", 1);
            heapPriorityQueue.Add("Hight", 10);
            Assert.That("Hight", Is.EqualTo(heapPriorityQueue.Head()));
        }

        [Test]

        public void HeadShouldThrowExceptionWhenQueueIsEmpty()
        {
            //To test if you can remove from empty queue
            Assert.Throws<InvalidOperationException>(() => unsortedArrayPriorityQueue.Head());
            Assert.Throws<InvalidOperationException>(() => unsortedLinkedPriorityQueue.Head());
            Assert.Throws<InvalidOperationException>(() => sortedLinkedPriorityQueue.Head());
            Assert.Throws<InvalidOperationException>(() => heapPriorityQueue.Head());
        }

        [Test]
        public void RemoveShouldRemoveHighestPriorityItem() 
        {
            //To test if the highest priority item is removed
            unsortedArrayPriorityQueue.Add("Low", 1);
            unsortedArrayPriorityQueue.Add("Hight", 10);
            unsortedArrayPriorityQueue.Remove();
            Assert.That("Low", Is.EqualTo(unsortedArrayPriorityQueue.Head()));

            unsortedLinkedPriorityQueue.Add("Low", 1);
            unsortedLinkedPriorityQueue.Add("Hight", 10);
            unsortedLinkedPriorityQueue.Remove();
            Assert.That("Low", Is.EqualTo(unsortedLinkedPriorityQueue.Head()));

            sortedLinkedPriorityQueue.Add("Low", 1);
            sortedLinkedPriorityQueue.Add("Hight", 10);
            sortedLinkedPriorityQueue.Remove();
            Assert.That("Low", Is.EqualTo(sortedLinkedPriorityQueue.Head()));

            heapPriorityQueue.Add("Low", 1);
            heapPriorityQueue.Add("Hight", 10);
            heapPriorityQueue.Remove();
            Assert.That("Low", Is.EqualTo(heapPriorityQueue.Head()));
        }

        [Test]

        public void RemoveShouldThrowExceptionWhenQueueIsEmpty()
        {
            //To test if you can remove from empty queue
            Assert.Throws<InvalidOperationException>(() => unsortedArrayPriorityQueue.Remove());
            Assert.Throws<InvalidOperationException>(() => unsortedLinkedPriorityQueue.Remove());
            Assert.Throws<InvalidOperationException>(() => sortedLinkedPriorityQueue.Remove());
            Assert.Throws<InvalidOperationException>(() => heapPriorityQueue.Remove());
        }

        [Test]

        public void AddItemWithSamePriority()
        {
            //To test and ensure if queues behave as expected when there are multiple items with same priority
            unsortedArrayPriorityQueue.Add("Item1", 3);
            unsortedArrayPriorityQueue.Add("Item2", 3);
            Assert.That(unsortedArrayPriorityQueue.Head(), Is.EqualTo("Item2"));

            unsortedLinkedPriorityQueue.Add("Item1", 3);
            unsortedLinkedPriorityQueue.Add("Item2", 3);
            Assert.That(unsortedLinkedPriorityQueue.Head(), Is.EqualTo("Item2"));

            sortedLinkedPriorityQueue.Add("Item1", 3);
            sortedLinkedPriorityQueue.Add("Item2", 3);
            Assert.That(sortedLinkedPriorityQueue.Head(), Is.EqualTo("Item2"));

            heapPriorityQueue.Add("Item1", 3);
            heapPriorityQueue.Add("Item2", 3);
            Assert.That(heapPriorityQueue.Head(), Is.EqualTo("Item2"));
        }
    }
}
