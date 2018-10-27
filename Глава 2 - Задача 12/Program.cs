using System;

namespace Глава_2___Задача_10
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {

                string firstName1 = "Emil";
                string secondName1 = "Kehayov";
                string firstName2 = "Stoyan";
                string lastName2 = "Cheresharov";
                string firstName3 = "Mariq";
                string lastName3 = "Vasileva";
                int Age1 = 30;
                int Age2 = 25;
                int Age3 = 45;
                char Gender1 = 'М';
                char Gender2 = 'Ж';





                int uniqueNumber;
                Console.WriteLine("Insert your unique number which is between 27560000-27569999");
                uniqueNumber = Convert.ToInt32(Console.ReadLine());

                if (uniqueNumber >= 27560000 && uniqueNumber <= 27563333)
                {
                    Console.WriteLine("Name:" + firstName1);
                    Console.WriteLine("Last Name:" + secondName1);
                    Console.WriteLine("Age:" + Age1);
                    Console.WriteLine("Gender:" + Gender1);
                }
                else if (uniqueNumber >= 27563334 && uniqueNumber <= 27566666)
                {
                    Console.WriteLine("Name:" + firstName2);
                    Console.WriteLine("Last Name:" + lastName2);
                    Console.WriteLine("Age:" + Age2);
                    Console.WriteLine("Gender:" + Gender1);
                }
                else if (uniqueNumber >= 27566667 && uniqueNumber <= 27569999)
                {
                    Console.WriteLine("Name:" + firstName3);
                    Console.WriteLine("Last Name:" + lastName3);
                    Console.WriteLine("Age:" + Age3);
                    Console.WriteLine("Gender:" + Gender2);
                }
                else
                {
                    Console.WriteLine("Invalid unique number!");
                }
            }
        




            

        }
    }
}
