using System;

namespace _4_print_hexa
{
    class Program
    {
        static void Main(string[] args)
        {
            // Write a program that prints all numbers from 0 to 98 in decimal and in hexadecimal (as in the following example)
            for (int i = 0; i < 99; i++)
            {
                Console.Write("{0,3} = 0x{1,2}\n", i, i.ToString("X"));
            }
        }
    }
}
