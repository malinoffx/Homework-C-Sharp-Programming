using System;

namespace Глава_6___Задача_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter:");
            int n;
            n = int.Parse(Console.ReadLine());
            Console.WriteLine("Result:");
            for (int i = 1; i <= n; i++)
            {
                if (i % (3*7) == 0)
                {
                    Console.WriteLine(" ");
                }
                else
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}
