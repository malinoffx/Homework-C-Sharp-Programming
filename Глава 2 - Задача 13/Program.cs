using System;

namespace Глава_2___Задача_13
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 5;
            int b = 10;
            int c = a;
            a = b;
            b = c;
            Console.WriteLine(b);
            Console.WriteLine(a);
            
            
        }
    }
}
