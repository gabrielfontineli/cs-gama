using System;

namespace firstProject
{
    class exercise08
    {
        public static void run()
        {
            Console.WriteLine("-------Exercise 08-------");
            double sallary, numberOfCars, comission, totalSales, fixedSallary, tax = 0.05;
            
            Console.WriteLine("number of cars:");
            numberOfCars = double.Parse(Console.ReadLine());
            Console.WriteLine("totalSales:");
            totalSales = double.Parse(Console.ReadLine());
            Console.WriteLine("sallary:");
            fixedSallary = double.Parse(Console.ReadLine());
            Console.WriteLine("comission:");
            comission = double.Parse(Console.ReadLine());
            
            sallary = fixedSallary + (tax * totalSales) + (comission * numberOfCars);

            Console.WriteLine($"sallary: {sallary:.00}");
            


        }

    }

}