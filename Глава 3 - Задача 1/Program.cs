using System;

namespace Глава_3___Задача_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = 5;
            int mynumber = number % 2;

            Console.WriteLine(new string('-', 40));

            if (mynumber == 0)
            {
                Console.WriteLine("Chisloto e chetno");
            }
            else {
                Console.WriteLine("Chisloto e ne chetno");
            }
        }
    }
}
