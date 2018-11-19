using System;

namespace Глава_6___Задача_5
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;
            n = int.Parse(Console.ReadLine());
            int a, b, s;
            a = 0;
            b = 1;
            s = 0;
            Console.WriteLine(a);
            Console.WriteLine(b);


            for (int i = 2; i <= n; i++)
            {
                s = a + b;
                Console.WriteLine(s);
                a = b;
                b = s;
            }
        }
    }
}
