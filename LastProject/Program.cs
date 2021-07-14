using System;

namespace LastProject
{
    class Program
    {
        static void Main(string[] args)
        {

            DateTime DayOfBirth ;
            
            string name,surname;
            double height;
            
            Console.WriteLine("type your name");
            name = Console.ReadLine();

            Console.WriteLine("type your surname");
            surname = Console.ReadLine();
            
            Console.WriteLine("type your height in meters");
            height = double.Parse(Console.ReadLine());
            
            Console.WriteLine("type your birth day");
            DayOfBirth = DateTime.Parse(Console.ReadLine());
            

            Person OtherPerson = new Person(name, surname, DayOfBirth ,height);
            Console.WriteLine("-----------------------------------------------------------");
            OtherPerson.ShowData();
            Console.WriteLine("-----------------------------------------------------------");
            OtherPerson.ShowAge();
            Console.WriteLine("-----------------------------------------------------------");
            OtherPerson.ShowNameLikeUS();
            Console.WriteLine("-----------------------------------------------------------");

        }
    }
}
