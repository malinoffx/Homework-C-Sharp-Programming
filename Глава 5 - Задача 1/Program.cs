using System;

namespace Глава_5___Задача_1
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {


                int a, b;
                Console.WriteLine("Insert parameter for a :");
                a = int.Parse(Console.ReadLine());
                Console.WriteLine("Insert parameter for b :");
                b = int.Parse(Console.ReadLine());
                int c = a;

                if (a > b)
                {
                    Console.WriteLine("{0} > {1}", a, b);
                    Console.WriteLine("Your result = ");
                    Console.WriteLine(b);
                    Console.WriteLine(a);
                }
                else if (a == b)
                {
                    Console.WriteLine("Your result :");
                    Console.WriteLine("They are equals");
                }
                else
                {
                    Console.WriteLine("Try Again");
                }
            }
        }
    }
}
