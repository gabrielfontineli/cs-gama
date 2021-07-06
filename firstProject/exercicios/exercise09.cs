using System;

namespace firstProject
{
    class exercise09
    {
        public static void run()
        {
            Console.WriteLine("-------Exercise 09-------");
            double finalGrade, n1, n2, n3;
            Console.WriteLine("enter your first grade:");
            n1 = double.Parse(Console.ReadLine());
            Console.WriteLine("enter your second grade:");
            n2 = double.Parse(Console.ReadLine());
            Console.WriteLine("enter your third grade:");
            n3 = double.Parse(Console.ReadLine());
            
            finalGrade = ((n1 * 2)+(n2 *3)+ (n3*5))/10;

            Console.WriteLine($"final grade: {finalGrade:.00}");
        }

    }

}