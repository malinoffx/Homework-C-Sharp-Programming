using System;

namespace Глава_2___Задача_3
{
    class Program
    {
        static void Main(string[] args)
        {
            double a;
            Console.WriteLine("Write your  double number and press Enter");
            a = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine(Math.Round(a,6));

            
            
        }
    }
}
