using System;


class Array
{
    public static int[] CreatePrint(int size)
    {
        if (size == 0)
        {
            Console.WriteLine();
            return new int[0];
        }
        else if (size < 0)
        {
            Console.WriteLine("Size cannot be negative");
            return null;
        }
        // Create an array of size 'size'
        int[] arr = new int[size];

        // Fill the array with values
        for (int i = 0; i < size; i++)
        {
            arr[i] = i;
        }

        // Print the array seperated by spaces
        Console.WriteLine(string.Join(" ", arr));

        return arr;
    }
}

