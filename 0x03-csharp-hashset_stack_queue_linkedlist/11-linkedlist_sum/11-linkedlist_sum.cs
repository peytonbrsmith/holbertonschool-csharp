using System;
using System.Collections.Generic;

class LList {
    public static int Sum(LinkedList<int> myLList)
    {
        // Get sum of list values
        int sum = 0;
        foreach (var item in myLList)
        {
            sum += item;
        }
        return sum;
    }
}