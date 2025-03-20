using System;

namespace PriorityQueue
{
    public class UnsortedArrayPriorityQueue<T> : PriorityQueue<T>
    {
        private readonly PriorityItem<T>[] storage;
        private readonly int capacity;
        private int tailIndex;

        public UnsortedArrayPriorityQueue(int size)
        {
            storage = new PriorityItem<T>[size];
            capacity = size;
            tailIndex = -1;
        }
        public T Head()
        {
            //Check for emptiness in array if empty throw an error
            if (IsEmpty())
            {
                throw new QueueUnderflowException();
            }

            //Storing a highest priority item
            int maxIndex = 0;

            //Loop throw the array to find a highest priority item
            for (int i = 1;i<tailIndex;i++)
            {
                //If current item's is higher, update maxIndex
                if (storage[i].Priority > storage[maxIndex].Priority)
                {
                maxIndex = i;
                }

            }

            //Return the item with the highest priority 
            return storage[maxIndex].Item; 
        }

        public void Add(T item, int priority)
        {   //Check if queue is full before adding a new item
            if (tailIndex + 1 >= capacity)
            {
                //Throw an exception in case the condition wasn't met
                throw new QueueOverflowException();
            }

            //Move tailIndex forward to store the new item in the next available position
            tailIndex++;

            //Store the new item with its priority at the new tailIndex position
            storage[tailIndex] = new PriorityItem<T>(item, priority);
        }

        public void Remove()
        {
            //Check if queue is empty before removing item
            if (IsEmpty())
            {
                throw new QueueUnderflowException();
            }


            //Storing a highest priority item
            int maxIndex = 0;

            //Loop throw the array to find a highest priority item
            for (int i = 1; i < tailIndex; i++)
            {
                //If we find an elemt with a higher priority, update maxIndex
                if (storage[i].Priority > storage[maxIndex].Priority)
                {
                    maxIndex = i;
                }

            }

            //Overwrite highest-priority item 
            storage[maxIndex] = storage[tailIndex];

            ///Reduce the size of queue
            tailIndex--;
        }

        public bool IsEmpty()
        {
            return tailIndex < 0;
        }

        public override string ToString()
        {
            if (IsEmpty())
            {
                throw new QueueUnderflowException("No items to display");
            }

            string result = "[";
            for (int i = 0; i <= tailIndex; i++)
            {
                if (i > 0)
                {
                    result += ", ";
                }
                result += storage[i];
            }
            result += "]";
            return result;
        }   
    }
}
