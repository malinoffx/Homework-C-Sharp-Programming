using System;

namespace Глава_5___Задача_10
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number between 1-9 :");
            int a = int.Parse(Console.ReadLine());

            if (a >= 1 && a <= 3)
            {
                Console.WriteLine("Your result multiplied by 10 = {0}", a * 10);
            }
            else if (a >= 4 && a <= 6)
            {
                Console.WriteLine("Your result multiplied by 100 = {0}", a * 100);
            }
            else if (a >= 7 && a <= 9)
            {
                Console.WriteLine("Your result multiplied by 1000 = {0}", a * 1000);
            }
            else 
            {
                Console.WriteLine("Wrong input!");
            }
        }
    }
}
