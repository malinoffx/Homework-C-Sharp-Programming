using System;

namespace Глава_8___Задача_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Въведите число: ");
            int n = Int32.Parse(Console.ReadLine());
            string binary = Convert.ToString(n, 2);
            Console.WriteLine("Резултата е {0}", binary);
        }
    }
}
