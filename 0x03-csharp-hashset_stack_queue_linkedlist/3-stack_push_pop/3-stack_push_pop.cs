using System;
using System.Collections.Generic;

class MyStack {
    public static Stack<string> Info(Stack<string> aStack, string newItem, string search)
    {
        Console.WriteLine($"Number of items: {aStack.Count}");
        Console.WriteLine($"Top item: {aStack.Peek()}");
        if (aStack.Count == 0)
        {
            Console.WriteLine("Stack is empty");
        }
        else {
            Console.WriteLine("Stack contains \"{0}\": {1}", search, aStack.Contains(search));
        }
        if (aStack.Contains(search))
        {
            while (aStack.Contains(search))
            {
                aStack.Pop();
            }
        }
        if (newItem != null)
        {
            aStack.Push(newItem);
        }
        return aStack;
    }
}