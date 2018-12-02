﻿using System;

namespace Глава_9___Задача_11
{
    class Program
    {
        public static string ReverseString(string s)
        {
            char[] arr = s.ToCharArray();
            Array.Reverse(arr);
            return new string(arr);
        }

        static void Reverse()
        {
            int numb;
            string stringNumberReverse;
            do
            {
                Console.Clear();
                Console.Write("Въведете неотрицателно число (хххх): ");
                stringNumberReverse = Console.ReadLine();
                numb = int.Parse(stringNumberReverse);
            } while (numb < 0);

            Console.WriteLine("Число обърнато " + ReverseString(stringNumberReverse));
            Console.ReadLine();
        }

        static void Average()
        {
            int numberAverage = 0;
            int entries = -1;
            int temp;
            string numberAverageString;
            bool input;
            Console.Clear();

            do
            {
                Console.Write("Въведете число. Въведете буква за да приключите: ");
                numberAverageString = Console.ReadLine();
                input = Int32.TryParse(numberAverageString, out temp);
                numberAverage += temp;
                entries++;
            } while (input);

            Console.WriteLine("Средно аретметично е {0}.", (float)numberAverage / entries);
            Console.ReadLine();
        }

        static void SolveEquation()
        {
            int a = 0;

            do
            {
                Console.Clear();
                Console.Write("Въведете a: ");
                a = int.Parse(Console.ReadLine());
            } while (a == 0);

            Console.Write("Въведете b: ");
            int b = int.Parse(Console.ReadLine());

            Console.WriteLine("x = {0}", (float)-b / a);
            Console.ReadLine();
        }

        static void Main(string[] args)
        {
            byte choice;

            do
            {
                Console.Clear();
                Console.WriteLine("-------------------------- М Е Н Ю --------------------------");
                Console.WriteLine("1.Обръщане на последователността на цифрите в едно число.");
                Console.WriteLine("2.Пресмятане на средното аритметично на дадена поредица от числа.");
                Console.WriteLine("3.Решаване на линейно уравнение: a * x + b = 0.");
                Console.WriteLine("4.Изход.");
                Console.Write("Въведете номера от менюто: ");

                choice = byte.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1: Reverse(); break;
                    case 2: Average(); break;
                    case 3: SolveEquation(); break;
                }

            } while (choice != 4);

            Console.WriteLine(Environment.NewLine + "Приятен ден!");
            Console.ReadLine();
        }
    }
}
