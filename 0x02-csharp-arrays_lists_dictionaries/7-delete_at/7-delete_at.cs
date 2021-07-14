using System;
using System.Collections.Generic;

class List {
    public static List<int> DeleteAt(List<int> myList, int index)
    {
        if (index < 0 || index >= myList.Count)
        {
            Console.WriteLine("Index out of range");
            return myList;
        }

        myList.Remove(myList[index]);
        return myList;
    }
}