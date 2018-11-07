using System;

namespace Глава_4___Задача_10
{
    class Program
    {
        static void Main(string[] args)
        {
            int sum = 0;

            Console.Write("Enter number count :");
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Enter {0} number :", i + 1);
                sum += int.Parse(Console.ReadLine());

            }

            Console.WriteLine("Sum of all numbers is {0}", sum);
        }
    }
}
