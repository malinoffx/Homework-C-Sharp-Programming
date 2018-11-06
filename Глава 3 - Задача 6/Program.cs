using System;

namespace Глава_3___Задача_6
{
    class Program
    {
        static void Main(string[] args)
        {
            

            int a;
            Console.WriteLine("Insert parameter for a:");
            a = Convert.ToInt32(Console.ReadLine());

            int h;
            Console.WriteLine("Insert parameter for h:");
            h = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Value 1 is:");
            Console.WriteLine(2 * a + 2 * h);
            Console.WriteLine("Value 2 is:");
            Console.WriteLine(a * h);
        }
    }
}
