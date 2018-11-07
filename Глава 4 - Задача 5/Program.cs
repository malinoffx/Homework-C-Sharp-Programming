using System;

namespace Глава_4___Задача_5
{
    class Program
    {
        static void Main(string[] args)
        {
            int c = 0;

            Console.Write("Enter first number :");
            int a = int.Parse(Console.ReadLine());
            Console.Write("Enter second number :");
            int b = int.Parse(Console.ReadLine());

            for (int i = a; i <= b; i++)
            {
                if (i % 5 == 0) c++;
            }
            Console.WriteLine("{0} numbers found.", c);
        }
    }
}
