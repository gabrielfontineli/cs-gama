using System;

namespace LastProject
{
    class Program
    {
        static void Main(string[] args)
        {
            
            DateTime DayOfBirth = DateTime.Parse("02/09/2004");
            Person Me = new Person("Gabriel Fontineli", "Dantas",DayOfBirth , 1.80);
            Console.WriteLine("-----------------------------------------------------------");
            Me.ShowData();
            Console.WriteLine("-----------------------------------------------------------");            
            Me.ShowAge();
            Console.WriteLine("-----------------------------------------------------------");            
            Me.ShowNameLikeUS();
            Console.WriteLine("-----------------------------------------------------------");            

        }
    }
}
