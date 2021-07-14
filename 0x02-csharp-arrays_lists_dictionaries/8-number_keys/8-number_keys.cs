using System;
using System.Collections.Generic;

class Dictionary{
    public static int NumberOfKeys(Dictionary<string, string> myDict)
    {
        // Count keys in dictionary
        int count = 0;
        foreach (var key in myDict.Keys)
        {
            count++;
        }
        return count;
    }
}