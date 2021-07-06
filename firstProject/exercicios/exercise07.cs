using System;

namespace firstProject
{
    class exercise07
    {
        public static void run()
        {
            Console.WriteLine("-------Exercise 07-------");
            double fabricCost, seller, taxes,cost;

            Console.WriteLine("enter fabric cost:");
            fabricCost = double.Parse(Console.ReadLine());
            seller = 0.28 * fabricCost;
            taxes = 0.45 * fabricCost;            
            cost = seller + taxes + fabricCost;

            Console.WriteLine($"final cost: {cost:.00}");

        }

    }

}