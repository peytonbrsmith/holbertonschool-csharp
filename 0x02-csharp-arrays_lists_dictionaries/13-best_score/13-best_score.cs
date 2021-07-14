using System;
using System.Collections.Generic;
using System.Linq;

class Dictionary{
    public static string BestScore(Dictionary<string, int> myList)
    {
        // Returns biggest integer
        return myList.OrderByDescending(x => x.Value).First().Key;
    }
}