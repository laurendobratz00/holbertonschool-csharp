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
            int index = aQueue.ToArray().ToList().IndexOf(search);
            while (aQueue.Count > index - 1)
            {
                aQueue.Dequeue();
            }
        }
        aQueue.Enqueue(newItem);
        return (aQueue);
    }
}
