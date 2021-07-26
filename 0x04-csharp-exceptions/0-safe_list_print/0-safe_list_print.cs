using System;
using System.Collections.Generic;

class List {
    public static int SafePrint(List<int> myList, int n)
    {
        int prints = 0;
        // Print the first n elements of the list
        for (int i = 0; i < n && i < myList.Count; i++, prints++)
        {
            Console.WriteLine(myList[i]);
        }
        return prints;
    }
}
