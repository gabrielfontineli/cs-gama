using System;

namespace ClassExercises
{
    class Exercise04
    {
        public static void Run()
        {
            Console.WriteLine("-------Exercise 04-------");
            double sallary, raise;

            Console.WriteLine("enter your sallary");
            sallary = double.Parse(Console.ReadLine());

            if(sallary <= 2800)
            {
                raise = 0.2; // 20%
            }
            else if(sallary > 2800 && sallary <= 7000)
            {
                raise = 0.15; // 15%
            }
            else if(sallary >7000 && sallary <= 15000)
            {
                raise = 0.1; // 10%
            }
            else
            {
                raise = 0.05; // 5%
            }

            Console.WriteLine($"i. sallary: {sallary}");
            Console.WriteLine($"ii. raise percentage: {raise*100}%"); //porcentagem do aumento
            Console.WriteLine($"iii. raise value: {raise * sallary}"); // valor do aumento
            Console.WriteLine($"iv. new sallary: {raise * sallary + sallary}");

        }

    }

}