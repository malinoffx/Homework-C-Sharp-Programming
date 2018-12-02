using System;

namespace Глава_10___Задача_1
{
    class Program
    {
        static void Recur(int[] arr, int index)
        {
            if (index >= arr.Length)
            {
                foreach (int element in arr) Console.Write("{0} ", element);
                Console.WriteLine();
            }
            else
                for (int i = 1; i <= arr.Length; i++)
                {
                    arr[index] = i;
                    Recur(arr, index + 1);
                }
        }

        static void Main(string[] args)
        {
            Console.Write("Въведете N: ");
            int n = Int32.Parse(Console.ReadLine());
            int[] arr = new int[n];
            Recur(arr, 0);
        }
    }
}
