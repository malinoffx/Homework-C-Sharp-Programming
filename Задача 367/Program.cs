using System;

namespace Курсова_Работа_2018___CSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                
            
            Console.WriteLine("Enter number between 0-9:");
            int n;
            n = int.Parse(Console.ReadLine());


                if (n < 0)
                {
                    Console.WriteLine("Wrong number. Try Again!");
                }
                else if(n > 9)
                {
                    Console.WriteLine("Wrong number.Try Again!");
                }
                

                switch (n)
                {
                    case 0:
                        Console.WriteLine("Word: ");
                        Console.WriteLine("Нула"); break;

                    case 1:
                        Console.WriteLine("Word: ");
                        Console.WriteLine("Едно"); break;
                    case 2:
                        Console.WriteLine("Word: ");
                        Console.WriteLine("Две"); break;
                    case 3:
                        Console.WriteLine("Word: ");
                        Console.WriteLine("Три"); break;
                    case 4:
                        Console.WriteLine("Word: ");
                        Console.WriteLine("Четири"); break;
                    case 5:
                        Console.WriteLine("Word: ");
                        Console.WriteLine("Пет"); break;
                    case 6:
                        Console.WriteLine("Word: ");
                        Console.WriteLine("Шест"); break;
                    case 7:
                        Console.WriteLine("Word: ");
                        Console.WriteLine("Седем"); break;
                    case 8:
                        Console.WriteLine("Word: ");
                        Console.WriteLine("Осем"); break;
                    case 9:
                        Console.WriteLine("Word: ");
                        Console.WriteLine("Девет"); break;

                    default:
                        break;

                        
                }
            }

        }
    }
}
