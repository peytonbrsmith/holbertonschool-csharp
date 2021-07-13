using System;

class Line
{
    public static void PrintDiagonal(int length)
    {
        // print a triangle of '\' of length 'length'
        for (int i = 0; i < length; i++)
        {
            for (int j = 0; j < i + 1; j++)
            {
                Console.Write(" ");
            }
            Console.WriteLine("\\");
        }
        Console.WriteLine();
    }
}
