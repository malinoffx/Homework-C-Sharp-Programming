using System;

namespace Глава_5___Задача_2
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

            if (a < 0 && b < 0 && c < 0)
            {
                Console.WriteLine(" - ");
            }
            else if (a >= 0 && b >= 0 && c >= 0)
            {
                Console.WriteLine("+");
            }
            else if (a < 0 && b < 0 && c >= 0)
            {
                Console.WriteLine(" + ");
            }
            else if (a < 0 && b >= 0 && c < 0)
            {
                Console.WriteLine("+");
            }
            else if (a >= 0 && b < 0 && c < 0)
            {
                Console.WriteLine("+");
            }
            else if (a < 0 && b >= 0 && c >= 0)
            {
                Console.WriteLine("-");
            }
            else if (a >= 0 && b < 0 && c >= 0)
            {
                Console.WriteLine("-");
            }
            else if (a >= 0 && b >= 0 && c < 0)
            {
                Console.WriteLine("-");
            }
        }
    }
}
