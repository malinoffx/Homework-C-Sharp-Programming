using System;

namespace Задача_413
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] Masive = new double[5];
            RealNumber(Masive);
            AverageThree(Masive);

        }
        static void RealNumber(double[]Double)
        {
            for (int i = 0; i < Double.Length; i++)
            {
                Console.WriteLine("Enter number :");
                Double[i] = Convert.ToDouble(Console.ReadLine());
            }
        }
        static void AverageThree(double[]Three)
        {
            int count = 0;
            double sum = 0;

            for (int i = 0; i < Three.Length; i++)
            {
                

                if (Three[i] % 3 == 0)
                {
                    sum += Three[i];
                    count++;
                }

                

                    
            }
            Console.WriteLine("Your result is: ");
            Console.WriteLine(sum / count);
        }
    }
}
