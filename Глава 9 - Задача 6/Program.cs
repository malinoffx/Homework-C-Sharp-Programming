﻿using System;

namespace Глава_9___Задача_6
{
    class Program
    {
        static int number = int.MinValue;

        static void CompareNumb(int[] arr)
        {
            for (int i = 1; i < arr.Length - 1; i++)
                if (arr[i] > arr[i - 1] && arr[i] > arr[i + 1])
                {
                    number = arr[i];
                    break;
                }
        }

        static void Main(string[] args)
        {
            Console.Write("Въведете дължината на масива: ");
            int length = Int32.Parse(Console.ReadLine());

            int[] arr = new int[length];

            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write("Въведете {0} елемент: ", i);
                arr[i] = Int32.Parse(Console.ReadLine());
            }

            CompareNumb(arr);

            if (number == int.MinValue) Console.WriteLine("-1");
            else Console.WriteLine("{0} е по-голямо от съседните числа", number);
        }
    }
}
