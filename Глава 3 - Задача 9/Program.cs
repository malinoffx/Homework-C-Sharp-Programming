using System;

namespace Глава_3___Задача_9
{
    class Program
    {
        static void Main(string[] args)
        {
            int x, y;
            Console.WriteLine("Insert x = ");
            x = int.Parse(Console.ReadLine());
            Console.WriteLine("Insert y = ");
            y = int.Parse(Console.ReadLine());
            if (x <= 6 && y <= 6 && (x * x) + (y * y) <= 25)
            {
                Console.WriteLine("Inside");
            }
            else
            {
                Console.WriteLine("Outside");
            }
        }
    }
}
