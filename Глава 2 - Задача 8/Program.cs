using System;

namespace Глава_2___Задача_8
{
    class Program
    {
        static void Main(string[] args)
        {
            string a = "Hello";
            string b = "World!";
            object c = a + " " + b;
            string d = (string)c;
            Console.WriteLine(d);
        }
    }
}
