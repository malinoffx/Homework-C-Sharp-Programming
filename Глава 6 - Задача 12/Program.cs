using System;

namespace Глава_6___Задача_12
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input");
            int value;
            value = int.Parse(Console.ReadLine());
            string binary = Convert.ToString(value, 2);
            Console.WriteLine("Result: ");
            Console.WriteLine(binary);
        }
    }
}
