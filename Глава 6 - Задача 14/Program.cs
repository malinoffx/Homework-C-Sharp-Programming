using System;

namespace Глава_6___Задача_14
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input");
            int value;
            value = int.Parse(Console.ReadLine());
            string binary = Convert.ToString(value, 16);
            Console.WriteLine("Result: ");
            Console.WriteLine(binary);
        }
    }
}
