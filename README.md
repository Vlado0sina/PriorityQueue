
## **Overview**
This project implements various priority queue structures using C#, demonstrating different approaches to handling priority-based data structures.
---

## **Repository Structure**

- `Person.cs`: A class used as a type for testing priority queues with the provided driver program.
- `PriorityItem.cs`: A class representing individual items within the priority queue. It includes properties for the item and its priority.
- `PriorityQueue.cs`: An interface defining the required methods for all Priority Queue implementations. This interface must not be modified.
- `QueueManager.cs`: A driver program implemented as a Windows Form application. It allows users to interact with and test different Priority Queue implementations.
- `QueueOverflowException.cs`:  A custom exception class for handling scenarios where the queue exceeds its defined capacity.
- `QueueUnderflowException.cs`: A custom exception class for handling scenarios where an operation is attempted on an empty queue.
- `SortedArrayPriorityQueue.cs`: A complete implementation of the Priority Queue using a sorted array. This serves as an example and a reference for creating additional implementations.
- `UnsortedArrayPriorityQueue.cs`:A complete implementation of the Priority Queue using a unsorted array.
- `UnsortedLinkedListPriorityQueue.cs`:A complete implementation of the Priority Queue using a unsorted linked list.
- `SortedLinkedListPriorityQueue.cs`:A complete implementation of the Priority Queue using a sorted linked list.
- `HeapBasedPriorityQueue.cs`:A complete implementation of the Priority Queue using a heap.
- `PriorityQueueTest.cs`:A complete implementation of test for the Priority Queue.
---
