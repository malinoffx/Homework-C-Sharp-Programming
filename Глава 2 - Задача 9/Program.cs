using System;

namespace Глава_2___Задача_9
{
    class Program
    {
        static void Main(string[] args)
        {
            string a = @"The ""use"" of quotations causes difficulties!";
            string b = "The \"use\" of quotations causes difficulties!";
            Console.WriteLine(new string('-', 40));
            Console.WriteLine(a);
            Console.WriteLine(new string('-', 40));
            Console.WriteLine(b);
            Console.WriteLine(new string('-', 40));
        }
    }
}
