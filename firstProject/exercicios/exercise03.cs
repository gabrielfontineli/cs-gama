using System;

namespace firstProject
{
    class exercise03
    {
        public static void run()
        {
            int rectBase, rectHeight, area;
            Console.WriteLine("-------Exercise 03-------");
            
            Console.WriteLine("enter rectangle base:");
            rectBase = int.Parse(Console.ReadLine());

            Console.WriteLine("enter rectangle height");
            rectHeight = int.Parse(Console.ReadLine());

            area = rectBase * rectHeight;

            Console.WriteLine($"the area of your rectangle = {area}");
        }

   }

}