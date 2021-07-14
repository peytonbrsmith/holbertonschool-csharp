using System;

namespace _14_rectangular_array
{
    class Program
    {
        static void Main(string[] args)
        {
            // create 5 by 5 array of 0s
            int[,] array = new int[5, 5];

            // set all indices to 0
            // for (int row = 0; row < array.GetLength(0); row++)
            // {
            //     for (int col = 0; col < array.GetLength(1); col++)
            //     {
            //         array[row, col] = 0;
            //     }
            // }

            // set index 2,2 to 1
            array[2, 2] = 1;

            // loop through array and print each index
            for (int row = 0; row < array.GetLength(0); row++)
            {
                for (int col = 0; col < array.GetLength(1); col++)
                {
                    Console.Write(array[row, col] + " ");
                }
            Console.WriteLine();
            }
        }
    }
}
