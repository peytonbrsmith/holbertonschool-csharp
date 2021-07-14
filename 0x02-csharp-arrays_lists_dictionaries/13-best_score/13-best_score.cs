using System;
using System.Collections.Generic;
using System.Linq;

class Dictionary{
    public static string BestScore(Dictionary<string, int> myList)
    {
        // if list is empty return "none"
        if (myList.Count == 0)
        {
            return "None";
        }
        // Returns biggest integer
        return myList.OrderByDescending(x => x.Value).First().Key;
    }
}