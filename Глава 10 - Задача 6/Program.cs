using System;

namespace Глава_10___Задача_6
{
    class Program
    {
        static public void DoMerge(int[] numbers, int left, int mid, int right)
        {   
            int[] temp = new int[25];
            int i, leftEnd, numElements, tmpPos;

            leftEnd = (mid - 1);                          
            tmpPos = left;
            numElements = (right - left + 1);

            while ((left <= leftEnd) && (mid <= right))
            {
                if (numbers[left] <= numbers[mid])
                    temp[tmpPos++] = numbers[left++];
                else
                    temp[tmpPos++] = numbers[mid++];
            }

            while (left <= leftEnd)
                temp[tmpPos++] = numbers[left++];

            while (mid <= right)
                temp[tmpPos++] = numbers[mid++];

            for (i = 0; i < numElements; i++)
            {
                numbers[right] = temp[right];
                right--;
            }
        }

        static public void MergeSortRecursive(int[] numbers, int left, int right)  
        {
            int mid;

            if (right > left)
            {
                mid = (right + left) / 2;
                MergeSortRecursive(numbers, left, mid);
                MergeSortRecursive(numbers, (mid + 1), right);
                DoMerge(numbers, left, (mid + 1), right);
            }
        }


        static void Main(string[] args)
        {
            Console.Write("Въведете дължината на масива: ");
            int length = Int32.Parse(Console.ReadLine());

            int[] arr = new int[length];

            for (int i = 0; i < length; i++)
            {
                Console.Write("Въведете {0} eлемент: ", i + 1);
                arr[i] = Int32.Parse(Console.ReadLine());
            }

            Console.WriteLine("\nСортировка");

            MergeSortRecursive(arr, 0, length - 1);
            for (int i = 0; i < length; i++)
                Console.WriteLine(arr[i]);
        }
    }
}
