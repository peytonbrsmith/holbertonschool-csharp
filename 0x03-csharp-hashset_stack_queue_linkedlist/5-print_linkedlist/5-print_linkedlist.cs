using System;
using System.Collections.Generic;

class LList {
    public static LinkedList<int> CreatePrint(int size)
    {
        // Create and print a linkedlist with size elements
        LinkedList<int> list = new LinkedList<int>();
        for (int i = 0; i < size; i++)
        {
            list.AddLast(i);
        }
        foreach (int i in list)
        {
            Console.WriteLine(i);
        }
        return list;
    }
}