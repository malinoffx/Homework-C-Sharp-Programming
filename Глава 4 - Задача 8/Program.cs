using System;

namespace Глава_4___Задача_8
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b, c, d, e;
            Console.WriteLine("Insert a :");
            a = int.Parse(Console.ReadLine());
            Console.WriteLine("Insert b :");
            b = int.Parse(Console.ReadLine());
            Console.WriteLine("Insert c :");
            c = int.Parse(Console.ReadLine());
            Console.WriteLine("Insert d :");
            d = int.Parse(Console.ReadLine());
            Console.WriteLine("Insert e :");
            e = int.Parse(Console.ReadLine());

            

            if (a > b && a > c && a > d && a > e)
            {
                Console.WriteLine("Your result :");
                Console.WriteLine(a);
            }
            else if (b > a && b > b && c > b && d > e)
            {
                Console.WriteLine("Your result :");
                Console.WriteLine(b);
            }
            else if (c > a && c > b && c > c && d > e)
            {
                Console.WriteLine("Your result :");
                Console.WriteLine(c);
            }
            else if(d > a && d > b && d > c && d > e)
            {
                Console.WriteLine("Your result :");
                Console.WriteLine(d);
            }
            else
            {
                Console.WriteLine("Your result :");
                Console.WriteLine(e);
            }
            
            
        }
    }
}
