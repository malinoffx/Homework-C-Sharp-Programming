using System;

namespace Глава_6___Задача_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter number: ");
            int lowest = 0;
            int highest = 0;
            int input;
            int n;
            n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine("Enter number:");
                input = int.Parse(Console.ReadLine());
                if (i == 0) lowest = highest = input;
                else
                {
                    if (lowest > input) lowest = input;
                    if (highest < input) highest = input;
                }

                Console.WriteLine("Lowest - {0}, Highest - {1}", lowest, highest);

                
            }
        }
    }
}
