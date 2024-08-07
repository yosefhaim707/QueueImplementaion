using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QueueImplementaion
{
   internal class SampleQueue
    {
        public Queue<int> Queue { get; set; }
        public SampleQueue()
        {
            Queue = new Queue<int>();
        }

        // A few common methods of Queue
        
        // Enqueue
        public void Enqueue(int value)
        {
            Queue.Enqueue(value);
        }

        // Dequeue
        public void Dequeue()
        {
            if (Queue.Count > 0)
            {
                Queue.Dequeue();
            }
            else
            {
                Console.WriteLine("Queue is empty");
            }
        }

        // Peek
        public void Peek()
        {
            if (Queue.Count > 0)
            {
                Console.WriteLine(Queue.Peek());
            }
            else
            {
                Console.WriteLine("Queue is empty");
            }
        }

        // Contains
        public void Contains(int value)
        {
            if (Queue.Contains(value))
            {
                Console.WriteLine("Queue contains " + value);
            }
            else
            {
                Console.WriteLine("Queue does not contain " + value);
            }
        }

        // Clear
        public void Clear()
        {
            Queue.Clear();
        }

        // Get all elements
        public void GetAllElements()
        {
            foreach (var item in Queue)
            {
                Console.WriteLine(item);
            }
        }
    }
}
