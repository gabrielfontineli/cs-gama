using System;

namespace firstProject
{
    class exercise04
    {
        public static void run()
        {
            Console.WriteLine("-------Exercise 04-------");
            int years, months, days, total;

            Console.WriteLine("enter your age in years");
            years = int.Parse(Console.ReadLine());
            
            Console.WriteLine($"{years} year(s) and how much months");
            months = int.Parse(Console.ReadLine());
            
            Console.WriteLine($"{years} year(s), {months} month(s) and how much days");
            days = int.Parse(Console.ReadLine());
            
            total = years * 365 + months * 30 + days;
            Console.WriteLine($"your age is days: {total}");
        }

    }

}