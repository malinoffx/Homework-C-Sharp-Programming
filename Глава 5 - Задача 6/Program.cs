using System;

namespace Глава_5___Задача_6
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
            double d = (b * b) - 4 * a * c;

            Console.WriteLine("D =");
            Console.WriteLine(d);

            if (d<0)
            {
                Console.WriteLine("There's no real roots!");
            }
            else if (d == 0)
            {
                double x1 = (double)(-b / 2 * a);
                Console.WriteLine("x1 = ");
                Console.WriteLine(x1);
            }
            else
            {
                double x1 = ((b * -1) + (Math.Sqrt(d))) / 2;
                double x2 = ((b * -1) - (Math.Sqrt(d))) / 2;
                Console.WriteLine("x1 =");
                Console.WriteLine(x1);
                Console.WriteLine("x2 =");
                Console.WriteLine(x2);
            }
        }
    }
}
