using System;

class Array{
    public static void Reverse(int[] array)
    {
        if (array != null)
        {
            // Print the array in reverse order
            for (int i = array.Length - 1; i >= 0; i--)
            {
                Console.Write(array[i]);
                if (i != 0)
                {
                    Console.Write(" ");
                }
            }
        }
        Console.WriteLine();
    }
}