/*
5. Implement Queue data structure that 
store 5 integer values and generate output as below.

		Total Elements in Queue: 5

		Queue elements are:
		1	2	3	4	5
 
Deleted : 1

		Queue elements are:
		2	3	4	5
*/

using System;
using System.Collections;

namespace QueueApp
{
    class IntegerQueue
    {
        static void Main(string[] args)
        {
            Queue intQueue = new Queue();
            intQueue.Enqueue(1);
            intQueue.Enqueue(2);
            intQueue.Enqueue(3);
            intQueue.Enqueue(4);
            intQueue.Enqueue(5);

            Console.WriteLine("Total Elements in Queue: {0}", intQueue.Count);

            Console.WriteLine("\nQueue elements are: ");
            foreach (var i in intQueue.ToArray())
                Console.Write("{0} \t", i);

            Console.Write("\n\nDeleted : {0}", intQueue.Peek());
            intQueue.Dequeue();

            Console.WriteLine("\n\nQueue elements are: ");
            foreach (var i in intQueue.ToArray())
                Console.Write("{0} \t", i);

        }
    }
}
