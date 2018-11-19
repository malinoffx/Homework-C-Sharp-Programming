using System;

namespace Глава_6___Задача_13
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter binary number: ");
            int n = int.Parse(Console.ReadLine());
            string toDouble = Convert.ToString(Convert.ToInt32(n, 2), 10);
            Console.WriteLine("Result is {0}", toDouble);
        }
    }
}
