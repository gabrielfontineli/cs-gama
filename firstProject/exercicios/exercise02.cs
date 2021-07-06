using System;
namespace firstProject
{
    class exercise02
    {
        public static void run()
        {
            int entry, predecessor;
            Console.WriteLine("-------Exercise 02-------");
            
            Console.WriteLine("enter an integer number:");
            entry = int.Parse(Console.ReadLine());
            predecessor = entry - 1;

            Console.WriteLine($"your number's predecessor: {predecessor}");
            
        }
    }
}