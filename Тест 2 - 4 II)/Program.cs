using System;

namespace Тест_2___4_II_
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {

            
            Console.WriteLine("Enter number between 1-7:");
            int n;
            n = int.Parse(Console.ReadLine());

                if (n < 0)
                {
                    Console.WriteLine("Wrong number. Try Again!");
                }
                else if (n > 9)
                {
                    Console.WriteLine("Wrong number.Try Again!");
                }

                switch (n)
                {
                    case 1:
                        Console.WriteLine("The day of the week is:");
                        Console.WriteLine("Понеделник"); break;
                    case 2:
                        Console.WriteLine("The day of the week is:");
                        Console.WriteLine("Вторник"); break;
                    case 3:
                        Console.WriteLine("The day of the week is:");
                        Console.WriteLine("Сряда"); break;
                    case 4:
                        Console.WriteLine("The day of the week is:");
                        Console.WriteLine("Четвъртак"); break;
                    case 5:
                        Console.WriteLine("The day of the week is:");
                        Console.WriteLine("Петък"); break;
                    case 6:
                        Console.WriteLine("The day of the week is:");
                        Console.WriteLine("Събота"); break;
                    case 7:
                        Console.WriteLine("The day of the week is:");
                        Console.WriteLine("Неделя"); break;

                    default:
                        break;
                }
            }

        }
    }
}
