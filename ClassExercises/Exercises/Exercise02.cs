using System;

namespace ClassExercises
{
    class Exercise02
    {
        public static void Run()
        {
            Console.WriteLine("-------Exercise 02-------");
            int a, b, c, biggest, smallest;

            Console.WriteLine("enter a number");
            a = int.Parse(Console.ReadLine());
            Console.WriteLine("enter a number");
            b = int.Parse(Console.ReadLine());
            Console.WriteLine("enter a number");
            c = int.Parse(Console.ReadLine());

            biggest = smallest = a;

            if (b > biggest)
            {
                biggest = b;
            }
            if (c > biggest)
            {
                biggest = c;
            }

            if(b < smallest)
            {
                smallest = b;
            }
            if (c < smallest)
            {
                smallest = c;
            }

            Console.WriteLine("biggest:"+biggest+"\nsmallest:"+ smallest);


        }

    }

}