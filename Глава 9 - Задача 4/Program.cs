using System;

namespace Глава_9___Задача_4
{
    class Program
    {
        static int CountNumb(int numb, int[] arr)
        {
            int counter = 0;

            for (int i = 0; i < arr.Length; i++) if (numb == arr[i]) counter++;

            return counter;
        }

        static void Main(string[] args)
        {
            Console.Write("Въведете дължината на масива: ");
            int length = Int32.Parse(Console.ReadLine());

            int[] arr = new int[length];

            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write("Въведете {0} eлемент: ", i);
                arr[i] = Int32.Parse(Console.ReadLine());
            }

            Console.Write("Въведете число: "); 
            int number = Int32.Parse(Console.ReadLine());

            Console.WriteLine("{0} се среща {1} пъти.", number, CountNumb(number, arr));
        }
    }
}
