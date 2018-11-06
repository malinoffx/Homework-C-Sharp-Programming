using System;

namespace Глава_3___Задача_5
{
    class Program
    {
        static void Main(string[] args)
        {
            int a;
            Console.WriteLine("Insert parameter for a:");
            a = Convert.ToInt32(Console.ReadLine());

            int b;
            Console.WriteLine("Insert parameter for b:");
            b = Convert.ToInt32(Console.ReadLine());

            int h;
            Console.WriteLine("Insert parameter for h:");
            h = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Your value is:");
            Console.WriteLine((a + b) / 2 * h); 
        }
    }
}
