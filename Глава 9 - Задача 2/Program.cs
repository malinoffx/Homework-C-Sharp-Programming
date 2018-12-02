using System;

namespace Глава_9___Задача_2
{
    class Program
    {
        static int a;

        static void GetMax(int first, int second)
        {
            if (first > second) a = first;
            else a = second;
        }

        static void Main(string[] args)
        {
            Console.Write("Въведете първото число: ");
            a = Int32.Parse(Console.ReadLine());
            Console.Write("Въведете второто число: ");
            int b = Int32.Parse(Console.ReadLine());
            Console.Write("Въведете третото число: ");
            int c = Int32.Parse(Console.ReadLine());

            GetMax(a, b);
            GetMax(a, c);

            Console.WriteLine("Най-голямото число е {0}", a);
        }
    }
}
