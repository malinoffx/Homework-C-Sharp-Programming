using System;

namespace Глава_1___Задача_10
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(new string('-', 40));

            int i = 2;
            while (i <= 100)
            {
               
                if (i % 2 == 1)
                {
                    Console.WriteLine(i * -1);
                }
                else
                {
                    Console.WriteLine(i);
                }
                i++;
                
                
            }
            
            

            
            
                
                
            
            
        }
    }
}
