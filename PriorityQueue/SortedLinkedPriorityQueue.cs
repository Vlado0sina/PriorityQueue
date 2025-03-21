using System;
using System.Runtime.Remoting.Messaging;

namespace PriorityQueue
{
    class SortedLinkedPriorityQueue<T>
    {
        //The heaad of the linked list
        private Node<T> head;
        public SortedLinkedPriorityQueue() 
        {
            head = null; //The process of makinf list empty
        }

        //Adds an item with a given priority to the queue, maintaining the order
        public void Add(T item, int priority)
        {
            //Create a new priority item and node
            var newItem = new PriorityItem<T>(item, priority);
            Node<T> newNode = new Node<T>(newItem);

            //Check if the list is empty or if new node is higher than the head
            if (IsEmpty() || head.PriorityItem.Priority <= priority)
            {
                newNode.Next = head; //Insert a new node
                head = newNode;//Update head to the new node
                return;
            }

            //We look throught the list and find a suitable position
            Node<T> current = head;
            while (current.Next != null && current.Next.PriorityItem.Priority < priority)
            {
                current = current.Next;//Move to next node
            }

            //Insert new node
            newNode.Next = current.Next;
            current.Next = newNode;
        }

        public T Head()
        {
            if (IsEmpty())
            {
                throw new InvalidOperationException("Queue is empty");
            }
            return head.PriorityItem.Item; // Return the highest priority item to head of the list  
        }

        public T Remove()
        {
            if (IsEmpty())
            {
                throw new InvalidOperationException("Queue is empty");
            }


            T item = head.PriorityItem.Item;//Remove the head
            head = head.Next;//Update head to next node

            return item;//Return the removed item
        }

        //Check id the queue is empty
        public bool IsEmpty()
        {
            return head == null;
        }
    }
}
