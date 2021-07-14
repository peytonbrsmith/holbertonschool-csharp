using System;
using System.Collections.Generic;
using System.Linq;

class Dictionary
{
    public static void PrintSorted(Dictionary<string, string> myDict)
    {
        var sortedKeys = myDict.Keys.OrderBy(x => x);
        foreach (var key in sortedKeys)
        {
            Console.WriteLine($"{key}: {myDict[key]}");
        }
    }
}