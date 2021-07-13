using System;

namespace _3_print_alphabt
{
    class Program
    {
        static void Main(string[] args)
        {
            // Write a program that prints the alphabet, in lowercase, not followed by a new line.
            // Print all the letters except q and e
            // You can only use Console.Write once
            // You can only use one loop in your code
            for (int i = 97; i <= 122; i++)
            {
                if (i != 113 && i != 101)
                {
                    Console.Write((char)i);
                }
            }
        }
    }
}
