using System;
using System.Collections.Generic;
using System.Linq;

class List
{
    public static int Sum(List<int> myList)
    {
        int sum = 0;

        // get unique elements from the list
        foreach (int i in myList.Distinct())
        {
            sum += i;
        }

        return sum;
    }
}