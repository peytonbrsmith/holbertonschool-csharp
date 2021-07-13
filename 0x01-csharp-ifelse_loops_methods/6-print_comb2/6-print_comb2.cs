using System;

namespace _6_print_comb2
{
    class Program
    {
        static void Main(string[] args)
        {
            // print all combinations of digits 0 through 9
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    if (i == 8 && j == 9)
                        Console.WriteLine("{0}{1}", i, j);
                    else if (i != j && i < j)
                        Console.Write("{0}{1}, ", i, j);
                }
            }

        }
    }
}
