using System;
using System.Collections.Generic;

class Dictionary{
    public static Dictionary<string, int> MultiplyBy2(Dictionary<string, int> myDict)
    {
        // create a new dictionary with values multiplied by 2
        Dictionary<string, int> newDict = new Dictionary<string, int>();
        
        foreach (KeyValuePair<string, int> kvp in myDict)
        {
            newDict.Add(kvp.Key, kvp.Value * 2);
        }

        return newDict;
    }
}