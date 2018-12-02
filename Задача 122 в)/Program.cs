using System;

namespace Задача_122_в_
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter x :");
            double x = double.Parse(Console.ReadLine());
            Console.WriteLine("CosX = : ");
            double cos = Math.Cos(x);
            Console.WriteLine(cos);
            Console.WriteLine("Enter n :");
            int n = int.Parse(Console.ReadLine());
            double fac = 1;
            double result = 1;
            for (int i = 1; i <= n; i++)
            {
                for (int j = i * 2; j > 0; j--)
                {
                    fac *= j;
                }
                result += (Math.Pow(-1,i))*(Math.Pow(x, 2 * i) / fac);
                fac = 1; 
            }
            Console.WriteLine("The result is:" + result);
            if (result > cos)
            {
                Console.WriteLine("The greater number is:" + result);
            }
            else
            {
                Console.WriteLine("The greater number is:" + cos);
            }
            
            
        }
    }
}
