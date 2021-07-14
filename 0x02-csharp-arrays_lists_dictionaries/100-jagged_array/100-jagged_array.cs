using System;

namespace _100_jagged_array
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create a jagged array
            int[][] jaggedArray = new int[3][];
            jaggedArray[0] = new int[4];
            jaggedArray[1] = new int[7];
            jaggedArray[2] = new int[2];

            // loop through the arrays
            for (int i = 0; i < jaggedArray.Length; i++)
            {
                // loop through the array
                for (int j = 0; j < jaggedArray[i].Length; j++)
                {
                    // set the array
                    jaggedArray[i][j] = j;
                }
            }
            // loop through the arrays
            for (int i = 0; i < jaggedArray.Length; i++)
            {
                // loop through the array
                for (int j = 0; j < jaggedArray[i].Length; j++)
                {
                    // print the array
                    Console.Write(jaggedArray[i][j]);
                    if (j != jaggedArray[i].Length - 1)
                    {
                        Console.Write(" ");
                    }
                }
                Console.WriteLine();
            }
        }
    }
}
