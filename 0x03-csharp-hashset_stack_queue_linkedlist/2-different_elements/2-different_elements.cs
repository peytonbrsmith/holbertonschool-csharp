using System;
using System.Collections.Generic;

class List {
    public static List<int> DifferentElements(List<int> list1, List<int> list2)
    {
        // Create list of elements not in both lists
        List<int> result = new List<int>();
        foreach (int i in list1)
        {
            if (!list2.Contains(i))
            {
                result.Add(i);
            }
        }
        foreach (int i in list2)
        {
            if (!list1.Contains(i))
            {
                result.Add(i);
            }
        }
        result.Sort();
        return result;
    }
}