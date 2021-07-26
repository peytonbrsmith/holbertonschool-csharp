using System;
using System.Collections.Generic;

class List
{
    public static List<int> Divide(List<int> list1, List<int> list2, int listLength)
    {
        List<int> results = new List<int>() {};

        try
        {
            for (int i = 0; i < listLength; i++)
            {
                try
                {
                    results.Add(list1[i] / list2[i]);
                }
                catch (System.DivideByZeroException)
                {
                    Console.WriteLine("Cannot divide by zero");
                    results.Add(0);
                }
                catch (System.ArgumentOutOfRangeException)
                {
                    Console.WriteLine("Out of range");
                }
            }
        }
        catch (System.ArgumentOutOfRangeException)
        {
            Console.WriteLine("Out of range");
        }

        return results;
    }
}
