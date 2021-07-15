using System;
using System.Collections.Generic;

class List {

    public static List<int> CommonElements(List<int> list1, List<int> list2)
    {
        // Create a new sorted list of common elements from list1 and list2
        List<int> commonElements = new List<int>();
        foreach (int i in list1)
        {
            if (list2.Contains(i))
            {
                commonElements.Add(i);
            }
        }
        commonElements.Sort();
        return commonElements;
    }
}