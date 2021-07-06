using System;

namespace ClassExercises
{
    class Exercise10
    {
        public static void Run()
        {
            Console.WriteLine("-------Exercise 10-------");
            int Entry;
            string Result;

            Console.WriteLine("enter an integer");
            Entry = int.Parse(Console.ReadLine());

            if(Entry % 2 == 0)
            {
                Result = "Even";
            }
            else
            {
                Result = "Odd";
            }

            Console.WriteLine("the number is " +Result);

        }

    }

}