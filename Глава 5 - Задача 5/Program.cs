using System;

namespace Глава_5___Задача_5
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {


                int a;
                Console.WriteLine("Enter number between 0-9 :");
                a = int.Parse(Console.ReadLine());

                switch (a)
                {
                    case 0: Console.WriteLine("The name of the number in bulgarian is (нула) "); break;
                    case 1: Console.WriteLine("The name of the number in bulgarian s (едно) "); break;
                    case 2: Console.WriteLine("The name of the number in bulgarian is (две) "); break;
                    case 3: Console.WriteLine("The name of the number in bulgarian is (три) "); break;
                    case 4: Console.WriteLine("The name of the number in bulgarian is (четири) "); break;
                    case 5: Console.WriteLine("The name of the number in bulgarian is (пет) "); break;
                    case 6: Console.WriteLine("The name of the number in bulgarian is (шест) "); break;
                    case 7: Console.WriteLine("The name of the number in bulgarian is (седем) "); break;
                    case 8: Console.WriteLine("The name of the number in bulgarian is (осем) "); break;
                    case 9: Console.WriteLine("The name of the number in bulgarian is (девет) "); break;
                    default: Console.WriteLine("Wrong input"); break;

                }
            }
        }
    }
}


    