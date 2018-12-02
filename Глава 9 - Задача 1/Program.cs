using System;

namespace Глава_9___Задача_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter name: ");
            ReturnName(Console.ReadLine());


            static void ReturnName(string name)
            {
                Console.WriteLine("Hello {0}", name);
            }
        }

            
        
    }
}
