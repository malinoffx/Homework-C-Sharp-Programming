using System;

namespace Глава_9___Задача_7
{
    class Program
    {
        public static string Circl(string number)
        {
            char[] charArr = number.ToCharArray();
            Array.Reverse(charArr);
            return new string(charArr);
        }

        static void Main(string[] args)
        {
            Console.Write("Въведете число: ");
            string number = Console.ReadLine();

            Console.WriteLine(Circl(number));
        }
    }
}
