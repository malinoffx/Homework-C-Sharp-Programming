using System;

namespace Глава_5___Задача_3
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b, c;
            Console.WriteLine("Enter a :");
            a = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter b :");
            b = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter c :");
            c = int.Parse(Console.ReadLine());

            if (a > b && a > c)
            {
                Console.WriteLine("A is biggest!");
            }
            else if (b > a && b > c)
            {
                Console.WriteLine("B is biggest!");
            }
            else
            {
                Console.WriteLine("C is biggest!");
            }
        }
    }
}
