using System;

namespace Глава_3___Задача_7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter your current weight:");
            double weightEarth = double.Parse(Console.ReadLine());

            double weightMoon = weightEarth * 0.17;
            Console.WriteLine("Your weight {0} on the mood will be {1}", weightEarth, weightMoon);
        }
    }
}
