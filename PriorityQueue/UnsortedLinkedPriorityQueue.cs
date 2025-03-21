using System;
using System.Runtime.Remoting.Messaging;

namespace PriorityQueue
{
    class UnsortedLinkedPriorityQueue<T> : PriorityQueue<T>
    {
        //The head of linked list
        private Node<T> head;

        public UnsortedLinkedPriorityQueue()
        {
            //Making initialy empty list
            head = null;
        }

        public void Add(T item, int priority)
        {
            var newItem = new PriorityItem<T>(item, priority); //Create a new PriorityItem
            Node<T> newNode = new Node<T>(newItem);//Create a new node in PriorityItem

            //Check if the list is empty or if new node is higher than the head
            if (IsEmpty() || head.PriorityItem.Priority < priority)
            {
                newNode.Next = head; //Insert a new node
                head = newNode;//Update head to the new node
                return;
            }

            //We look throught the list and find a suitable position
            Node<T> current = head;
            while (current.Next != null && current.Next.PriorityItem.Priority >= priority)
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
            return FindHighestPriorityNode().PriorityItem.Item; // Return the highest priority item to head of the list  
        }

        //public T Remove
        public void Remove()
        {
            if (IsEmpty())
            {
                throw new InvalidOperationException("Queue is empty");
            }
            //Initialize variables to track the highest priority node and its prev node 
            Node<T> prev = null;
            Node<T> highestNode = head;
            Node<T> curent = head;
            Node<T> prevHighest = null;

            //Loop throw the list to find the node with the highest priority
            while (curent != null)
            {
                if (curent.PriorityItem.Priority > highestNode.PriorityItem.Priority)
                {
                    highestNode = curent;//Update highest node
                    prevHighest = prev;//Update prev node
                }
                prev = curent;
                curent = curent.Next;
            }
            //Remove the highest priority node
            if (highestNode == head)
            {
                head = head.Next;
            }
            else
            {
                prevHighest = highestNode.Next;
            }
            // return highestNode.PriorityItem.Item;
        }

        public bool IsEmpty()
        {
            return head == null;
        }

        //Finds and return the node with the highest priority
        private Node<T> FindHighestPriorityNode() 
        {
            Node<T> highestNode = head;
            Node<T> current = head;


            //Loop throw the list to find the node with the highest priority
            while (current != null) 
            {
                if (current.PriorityItem.Priority > highestNode.PriorityItem.Priority) 
                {
                    highestNode =  current;//Update highest node
                }

                current = current.Next;//Move to the next node
            }
            return highestNode; //Return the node with the highest priority 

        }
    }
}
