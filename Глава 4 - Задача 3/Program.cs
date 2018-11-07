using System;

namespace Глава_4___Задача_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter company name :");
            string cName = Console.ReadLine();
            Console.WriteLine("Enter company adress :");
            string cAdd = Console.ReadLine();
            Console.WriteLine("Enter company phone number :");
            string cPN = Console.ReadLine();
            Console.WriteLine("Enter company Fax number :");
            string cF = Console.ReadLine();
            Console.WriteLine("Enter company WebSite :");
            string cWeb = Console.ReadLine();
            Console.WriteLine("Enter company manager name :");
            string cM = Console.ReadLine();
            Console.WriteLine("Enter Company manager surname :");
            string cMs = Console.ReadLine();
            Console.WriteLine("Eter company manager phone number :");
            string mPN = Console.ReadLine();

            Console.WriteLine("About Company : {0} | {1} | {2} | {3} | {4} ", cName, cAdd, cPN, cF, cWeb);
            Console.WriteLine("About Manager : {0} | {1} | {2} ", cM, cMs, mPN);
        }
    }
}
