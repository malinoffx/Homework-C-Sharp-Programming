using System;

namespace Глава_4___Задача_4
{
    class Program
    {
        static void Main(string[] args)
        {
            int nHex = 155;

            Console.WriteLine("|0x{0, -8:X}",nHex);
            double posNum = 1.2597;
            Console.WriteLine("|{0, -10:f2}",posNum);

            double negNum = -1.9547;
            Console.WriteLine("|{0, -10:f2}", negNum);
        }
    }
}
