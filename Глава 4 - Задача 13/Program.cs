using System;

namespace Глава_4___Задача_13
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter last number :");
            int n = int.Parse(Console.ReadLine());
            double sum = 1.0;

            for (int i = 2; i < n; i++)
            {
                sum += (1.0 / i);
            }
            Console.WriteLine("{0:F3}", sum);




        }
    }
}
