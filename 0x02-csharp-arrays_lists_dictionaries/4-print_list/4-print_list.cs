using System;
using System.Collections.Generic;

class List {
    public static List<int> CreatePrint(int size)
    {
        if (size < 0)
        {
            Console.WriteLine("Size cannot be negative");
        }

        // Create and print list of integers of size
        List<int> list = new List<int>();
        for (int i = 0; i < size; i++)
        {
            list.Add(i);
        }
        foreach (int i in list)
        {
            Console.Write(i);
            // print space if not last item
            if (i != size - 1)
            {
                Console.Write(" ");
            }
        }
        Console.WriteLine();
        return list;
    }
}