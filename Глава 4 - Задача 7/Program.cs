using System;

namespace Глава_4___Задача_7
{
    class Program
    {
        static void Main(string[] args)
        {

            
            int count = 0;
            int sum = 0;
            bool boop = true;
            Console.WriteLine("Insert your 5 numbers :");
            while (boop == true)
            {
                try
                {
                    int a = int.Parse(Console.ReadLine());

                    
                    
                        sum += a;
                        count++;
                    
                    
                    if (count == 5)
                    {
                        boop = false;
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message + "Try again :");
                    
                }
                
            }
            Console.WriteLine("Your result is :");
            Console.WriteLine(sum);

            
            

            
        }
    }
}
