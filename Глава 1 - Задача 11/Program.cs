using System;

namespace Глава_1___Задача_11
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(new string('-', 40));
            int myAge;
            Console.WriteLine("Enter your Age:");
            myAge = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(new string('-', 40));
            Console.WriteLine("Your age after ten years will be:");
            Console.WriteLine(myAge + 10);
            Console.WriteLine(new string('-', 40));
        }
    }
}
