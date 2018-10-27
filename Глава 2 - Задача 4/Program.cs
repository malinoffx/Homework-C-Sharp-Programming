using System;

namespace Глава_2___Задача_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(new string('-', 40));
            int value = 256;
            string hex = Convert.ToString(value, 16);
            Console.WriteLine(hex);
            Console.WriteLine(new string('-', 40));
            

        }
    }
}
