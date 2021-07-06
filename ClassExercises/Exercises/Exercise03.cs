using System;

namespace ClassExercises
{
    class Exercise03
    {
        public static void Run()
        {
            Console.WriteLine("-------Exercise 03-------");
            float price1, price2, price3, cheapest;

            Console.WriteLine("What is the price?");
            price1 = float.Parse(Console.ReadLine());
            
            Console.WriteLine("What is the price?");
            price2 = float.Parse(Console.ReadLine());
            
            Console.WriteLine("What is the price?");
            price3 = float.Parse(Console.ReadLine());

            cheapest = price1;

            if(price2 < cheapest)
            {
                cheapest = price2;
            }
            if (price3 < cheapest)
            {
                cheapest = price3;
            }
            Console.WriteLine("The cheapest: "+cheapest);

        }

    }

}