
using System;
class Line
{
    public static void PrintLine(int length)
    {
        for (int i = 0; i < length; i++)
        {
            Console.Write("_");
        }
        Console.WriteLine();
    }
}