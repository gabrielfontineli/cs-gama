using System;

namespace firstProject
{
    class exercise06
    {
        public static void run()
        {
            Console.WriteLine("-------Exercise 06-------");
            double sallary, readjust, newSallary;

            Console.WriteLine("enter sallary");
            sallary = double.Parse(Console.ReadLine());

            Console.WriteLine("enter readjustment percentage");
            readjust = double.Parse(Console.ReadLine());
            readjust /=100;

            newSallary = readjust * sallary + sallary;
            Console.WriteLine($"your new sallary: {newSallary:.00}");
            

        }

    }

}