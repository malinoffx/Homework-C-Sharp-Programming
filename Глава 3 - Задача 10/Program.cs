using System;

namespace Глава_3___Задача_10
{
    class Program
    {
        static void Main(string[] args)
        {
            int num;
            Console.WriteLine("Enter a 4 digit number: ");
            num = int.Parse(Console.ReadLine());
            int a = num % 10;
            int b = (num / 10) % 10;
            int c = (num / 100) % 10;
            int d = (num / 1000) % 10;

            Console.WriteLine("The Sum is {0}", a + b + c + d);
            Console.WriteLine("Opposite direction is {0} {1} {2} {3}", a, b ,c , d);
            Console.WriteLine("4th on 1st : {0} {1} {2} {3}", a, d, c, b);
            Console.WriteLine("2nd and 3rd swap : {0} {1} {2} {3}", d, b, c, a);
        }
    }
}
