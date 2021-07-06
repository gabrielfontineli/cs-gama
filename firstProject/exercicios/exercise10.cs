using System;

namespace firstProject
{
    class exercise10
    {
        public static void run()
        {
            Console.WriteLine("-------Exercise 10-------");
            double fahrenheit,celsius;

            Console.WriteLine("enter temperature in fahrenheit");
            fahrenheit = double.Parse(Console.ReadLine());

            celsius = ((fahrenheit-32) * 5)/9;
            Console.WriteLine($"your converted temperature: {celsius:00}C");
            

        }

    }

}