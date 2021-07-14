using System;

namespace Areas
{
    class Program
    {
        static void Main(string[] args)
        {
            int entry = 0;
            double area, entrybase, height;
            do
            {
                Console.WriteLine("Wish to calculate area from?\n1-Square\n2-Rectangle\n2-Circle");
                entry = int.Parse(Console.ReadLine());
                switch (entry)
                {
                    case 1: 
                        Square square1 = new Square();
                        Console.WriteLine("enter your square side:");
                        area = square1.CalculateArea(double.Parse(Console.ReadLine()));
                        Console.WriteLine("Area:"+ area);
                    break;
                    case 2:
                        Rectangle rect1 = new Rectangle();
                        Console.WriteLine("enter your base and height");
                        entrybase = double.Parse(Console.ReadLine());
                        height = double.Parse(Console.ReadLine());
                        
                        area = rect1.CalculateArea(entrybase,height); 
                        Console.WriteLine("Area:" +area);
                    break;
                    case 3:
                        Circle circle1 = new Circle();
                        Console.WriteLine("enter your radius");

                        area = circle1.CalculateArea(double.Parse(Console.ReadLine()));
                        Console.WriteLine("Area:" + area);

                    break;


                }
            }
            while(entry != 95);
        }
    }
    class Circle
    {
        private double pi = 3.1416;
        private double area;
        public double CalculateArea(double radius)
        {
            area = pi * Math.Pow(radius,2);
            return area;
        }
    }
    class Square
    {
        private double side,area;
        public double CalculateArea(double entryside)
        {
            side = entryside;
            area = Math.Pow(side,2);
            return area;
        }
        
    }
    class Rectangle
    {
        public double b,height,area;
        public double CalculateArea(double ba, double height)
        {
            b = ba;
            height = this.height;

            area = b * height;
            return area;

        }
    }
}
