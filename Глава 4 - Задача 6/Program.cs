using System;

namespace Глава_4___Задача_6
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b;
            Console.WriteLine("Insert a :");
            a = int.Parse(Console.ReadLine());
            Console.WriteLine("Insert b :");
            b = int.Parse(Console.ReadLine());
            Console.WriteLine("Your result :");
            Console.WriteLine("{0} > {1}", Math.Max(a, b), Math.Min(a, b));
        }
    }
}
