using System;

namespace Глава_4___Задача_9
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b, c;
            Console.WriteLine("Insert a :");
            a = int.Parse(Console.ReadLine());
            Console.WriteLine("Insert b :");
            b = int.Parse(Console.ReadLine());
            Console.WriteLine("Insert c :");
            c = int.Parse(Console.ReadLine());

            Console.WriteLine("Your equasion is {0}*x^2 + {1}*x + {2} = 0", a, b, c);

            double D = (b * b) - 4 * a * c;
            

            Console.WriteLine("D = ");
            Console.WriteLine(D);

            
            if (D < 0)
            {
                Console.WriteLine("There's no value!");
            }
            else
            {
                double x1 = ((b * -1) + (Math.Sqrt(D))) / 2;
                double x2 = ((b * -1) - (Math.Sqrt(D))) / 2;

                Console.WriteLine("x1 = ");
                Console.WriteLine(x1);

                Console.WriteLine("x2 = ");
                Console.WriteLine(x2);
            }







        }
    }
}
