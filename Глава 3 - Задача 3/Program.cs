using System;

namespace Глава_3___Задача_3
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 15700;
            int b = 157;
            int c = b % 10;
            Console.WriteLine();

            if (c == 7)
            {
                Console.WriteLine("Tretata cifra e 7");
            }
            else
            {
                Console.WriteLine("Tretata cifra ne e 7");
            }
        }
    }
}
