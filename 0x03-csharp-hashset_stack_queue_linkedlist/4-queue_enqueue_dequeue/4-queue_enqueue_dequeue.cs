using System;
using System.Collections.Generic;
using System.Linq;

class MyQueue
{
    public static Queue<string> Info(Queue<string> aQueue, string newItem, string search)
    {
        Console.WriteLine("Number of items: " + aQueue.Count);
        if (aQueue.Count == 0)
            Console.WriteLine("Queue is empty");
        else
            Console.WriteLine("First item: " + aQueue.Peek());
        Console.WriteLine("Queue contains \"{0}\": {1}", search, aQueue.Contains(search));
        if (aQueue.Contains(search))
        {
            while (aQueue.Dequeue() != search)
            {
                continue;
            }
        }
        aQueue.Enqueue(newItem);
        return (aQueue);
    }
}
