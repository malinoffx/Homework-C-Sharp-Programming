using System;

namespace Глава_3___Задача_4
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = 30;
            bool bit3 = (num & 8) != 0;
            Console.WriteLine(bit3);
        }
    }
}
