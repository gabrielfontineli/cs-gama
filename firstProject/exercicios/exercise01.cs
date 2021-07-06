using System;

namespace firstProject
{
    class exercise01
    {
        public static void run()
        {
            Console.WriteLine("-------Exercise 01-------");
            int a = 10;
            int b = 20;

            (a, b) = (b, a);

            Console.WriteLine($"A: {a}, B: {b}");

        }

    }

}