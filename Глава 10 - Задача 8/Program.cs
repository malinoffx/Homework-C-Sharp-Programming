using System;

namespace Глава_10___Задача_8
{
    class Program
    {
        public static bool SubsetSum(int[] arr, int n, int sum)
        {
            bool[,] subset = new bool[sum + 1, n + 1];

            for (int i = 0; i <= n; i++)
                subset[0, i] = true;

            for (int i = 1; i <= sum; i++)
                subset[i, 0] = false;

            for (int i = 1; i <= sum; i++)
                for (int j = 1; j <= n; j++)
                {
                    subset[i, j] = subset[i, j - 1];
                    if (i >= arr[j - 1])
                        subset[i, j] = subset[i, j] || subset[i - arr[j - 1], j - 1];
                }

            return subset[sum, n];
        }

        static void Main(string[] args)
        {
            Console.Write("Въведите дължината на масива: ");
            int length = Int32.Parse(Console.ReadLine());
            int[] arr = new int[length];

            for (int i = 0; i < length; i++)
            {
                Console.Write("Въведете {0} елемент: ", i + 1);
                arr[i] = Int32.Parse(Console.ReadLine());
            }

            Console.Write("Въведете сума: ");
            int sum = Int32.Parse(Console.ReadLine());

            if (SubsetSum(arr, arr.Length, sum) == true)
                Console.WriteLine("Подмножество с дадена сума съществува.");
            else
                Console.WriteLine("Подмножество с дадена сума няма.");
            Console.ReadLine();
        }
    }
}
