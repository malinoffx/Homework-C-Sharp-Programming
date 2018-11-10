using System;

namespace Глава_5___Задача_4
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

            if (a > b && a > c && b > c)
            {
                Console.WriteLine("{0}>{1}>{2}", a, b, c);
            }
            else if (a>b && a<c && b < c)
            {
                Console.WriteLine("{0}>{1}>{2}", b, c, a);
            }
            else if (a > b && a > c && b < c)
            {
                Console.WriteLine("{0}>{1}>{2}",a,c,b);
            }
            else if (a < b && a > c &&b > c)
            {
                Console.WriteLine("{0}>{1}>{2}",b,a,c);
            }
            else if (a < b && a < c && b < c)
            {
                Console.WriteLine("{0}>{1}>{2}",c,b,a);
            }
            else if (a>b && a < c && b < c)
            {
                Console.WriteLine("{0}>{1}>{2}",c,a,b);
            }
        }
    }
}
