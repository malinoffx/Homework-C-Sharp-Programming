using System;

namespace Глава_4___Задача_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter value for r: ");
            int r = int.Parse(Console.ReadLine());
            int d = 2 * r;
            double pi = Math.PI;
            Console.WriteLine("P is :");
            Console.WriteLine(Math.Abs(d * pi));
            Console.WriteLine("S is :");
            Console.WriteLine(Math.Abs(pi *(r*r)));
            
            
            

        }
    }
}
