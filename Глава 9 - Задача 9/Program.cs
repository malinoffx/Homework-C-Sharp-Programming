using System;

namespace Глава_9___Задача_9
{
    class Program
    {
        public static int GetMax(int[] array, int start, int end)
        {
            int maxNum = array[start];

            for (int i = start + 1; i < end; i++)
            {
                if (array[i] > maxNum) maxNum = array[i];
            }

            return maxNum;
        }

        public static void Main(string[] args)
        {
            Console.Write("Въведете дължината на масива: ");
            int length = Int32.Parse(Console.ReadLine());

            int[] arr = new int[length];

            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write("Въведете {0} елемент: ", i);
                arr[i] = Int32.Parse(Console.ReadLine());
            }
            Console.Write("\nВъведете границите на интервала");
            Console.Write("\nВъведете първия индекс: ");
            int startIndex = Int32.Parse(Console.ReadLine());

            Console.Write("Въведете последния индекс: ");
            int endIndex = Int32.Parse(Console.ReadLine());

            Console.WriteLine("Най-голямото число в интервала е {0}-{1} is {2}.", startIndex, endIndex, GetMax(arr, startIndex, endIndex));
        }
    }
}
