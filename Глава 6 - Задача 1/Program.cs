using System;

namespace Глава_6___Задача_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number :");
            int n;
            n = int.Parse(Console.ReadLine());
            Console.WriteLine("Your Result is :");
            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine(i);
            }
        }
    }
}
