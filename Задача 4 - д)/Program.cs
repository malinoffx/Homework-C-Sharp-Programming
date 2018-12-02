using System;

namespace Задача_4___д_
{
    class Program
    {
        static void Main(string[] args)
        {
            double x, y, z;
            Console.WriteLine("Enter number for x: ");
            x = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter number for y: ");
            y = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter number for z: ");
            z = int.Parse(Console.ReadLine());

            double c = x + y;

            double d = z + (z / (x + (z / (y - x))));
            Console.WriteLine("Your answer for (x+y) / z + (z / (x + (z / (y - x)))) is: ");
            Console.WriteLine(c/d);

        }
    }
}
