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
                if (i > 0)
                    Console.Write(", ");
                Console.Write(i);
            }
        }
    }
}
