﻿using System;

namespace Глава_10___Задача_5
{
    class Program
    {
        static string[] strings, str;
        static int length;
        
        static void cycle(int iter, int index, int k)
        {
            if (iter == k)
            {
                for (int i = 0; i < length; i++)
                    Console.WriteLine("({0}) ", str[i]);
                return;
            }

            for (int i = index; i < strings.Length; i++)
            {
                str[iter] = strings[i];
                cycle(iter + 1, i + 1, k);
            }
        }

        static void Main(string[] args)
        {
            Console.Write("Въведете дължината на масива от думи: ");
            length = Int32.Parse(Console.ReadLine());

            strings = new string[length];

            for (int i = 0; i < length; i++)
            {
                Console.Write("Въведете {0} дума: ", i + 1);
                strings[i] = Console.ReadLine();
            }

            for (int i = 0; i <= length; i++)
            {
                str = new string[length];
                cycle(0, 0, i);
            }
        }
    }
}
