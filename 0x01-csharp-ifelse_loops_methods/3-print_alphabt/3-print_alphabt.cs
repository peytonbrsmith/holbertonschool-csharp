using System;

namespace _3_print_alphabt
{
    class Program
    {
        static void Main(string[] args)
        {
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
