using System;
using System.Collections.Generic;
using System.Linq;

class MyStack
{
    public static Stack<string> Info(Stack<string> aStack, string newItem, string search)
    {
        if (aStack.Count == 0)
            Console.WriteLine("Stack is empty");
        Console.WriteLine("Number of items: " + aStack.Count);
        Console.WriteLine("Top item: " + aStack.Peek());
        if (aStack.Contains(search))
            Console.WriteLine("Stack contains " + search + ": True");
        else
            Console.WriteLine("Stack contains " + search + ": False");
        int indexOfSearch = aStack.ToArray().ToList().IndexOf(search);
        while (aStack.Count > indexOfSearch - 1)
            aStack.Pop();
        aStack.Push(newItem);
        return (aStack);
    }
}

