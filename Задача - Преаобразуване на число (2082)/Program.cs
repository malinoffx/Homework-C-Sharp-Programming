using System;

namespace Задача___Преаобразуване_на_число__2082_
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("My number is 2082");
            int a = 2082;

            string binary = Convert.ToString(a, 2);
            string octal = Convert.ToString(a, 8);
            string hexadecimal = Convert.ToString(a, 16);

            Console.WriteLine("How looks my number in binary :");
            Console.WriteLine(binary);
            Console.WriteLine("How looks my number in octal :");
            Console.WriteLine(octal);
            Console.WriteLine("How looks my number in hexadecimal :");
            Console.WriteLine(hexadecimal);
        }
    }
}
