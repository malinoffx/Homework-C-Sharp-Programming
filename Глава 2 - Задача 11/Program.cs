using System;
using System.Text;

namespace Глава_2___Задача_11
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

            Console.ForegroundColor = ConsoleColor.DarkBlue;

            char a = '\u00a9';
            Console.WriteLine($"            {a}       ");
            Console.WriteLine($"          {a}   {a}    ");
            Console.WriteLine($"        {a}       {a}    ");
            Console.WriteLine($"      {a}           {a} ");
            Console.WriteLine($"    {a} {a} {a} {a} {a} {a} {a} {a} {a}            ");

            Console.WriteLine(" ");
        }
    }
}
