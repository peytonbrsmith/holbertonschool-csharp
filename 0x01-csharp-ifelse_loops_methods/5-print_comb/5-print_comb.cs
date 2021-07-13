using System;

namespace _5_print_comb
{
    class Program
    {
        static void Main(string[] args)
        {
            // loop and print integers 0 to 99 seperated by a command and space
            for (int i = 0; i < 100; i++)
            {
                if (i == 99)
                    Console.Write("{0:D2}\n", i);
                // write the integer with preceding zeros
                else
                    Console.Write("{0:D2}, ", i);
            }
        }
    }
}
