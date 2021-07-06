using System;

namespace ClassExercises
{
    class Exercise08
    {
        public static void Run()
        {
            Console.WriteLine("-------Exercise 08-------");
            int a, b, c;
            string ClassifyBySides;
            Console.WriteLine("enter a side of the triangle");
            a = int.Parse(Console.ReadLine());

            Console.WriteLine("enter a side of the triangle");
            b = int.Parse(Console.ReadLine());

            Console.WriteLine("enter a side of the triangle");
            c = int.Parse(Console.ReadLine());

            if (a + b <= c || a + c <= b || b + c <= a)
            {
                ClassifyBySides = ("non existent");
            }
            else
            {
                if (a == b && b == c)
                {
                    ClassifyBySides = "Equilatero";
                }
                else if (a != b && b != c)
                {
                    ClassifyBySides = "Escaleno";
                }
                else
                {
                    ClassifyBySides = "Isosceles";
                }
            }
            Console.WriteLine("triangle: " + ClassifyBySides);

        }

    }

}