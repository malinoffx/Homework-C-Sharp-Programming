using System;

namespace Глава_3___Задача_11
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 35;
            int p = 6;
            int i = 1;
            int mask = 1 << p;
            Console.WriteLine((n & mask) != 0 ? 1: 0);
            Console.WriteLine();
        }
    }
}
