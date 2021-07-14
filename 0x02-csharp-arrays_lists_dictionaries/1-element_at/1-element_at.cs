using System;
class Array
{
    public static int elementAt(int[] array, int index)
    {
        if (array == null)
        {
            return -1;
        }
        if (index < 0 || index >= array.Length)
        {
            Console.WriteLine("Index out of range");
            return -1;
        }
        return array[index];
    }
}
