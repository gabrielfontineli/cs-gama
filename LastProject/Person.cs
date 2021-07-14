using System;

namespace LastProject
{
    class Person
    {
        private string Name{get;set;}
        private string Surname{get;set;}
        private DateTime DayOfBirth{get;set;}
        private double Height{get;set;}

        public Person(string Name, string Surname, DateTime DayOfBirth, double Height) 
        {
            this.Name = Name;
            this.Surname = Surname;
            this.DayOfBirth = DayOfBirth;
            if (Height > 0) this.Height = Height;
        }
        public void ShowData()
        {
            Console.WriteLine($"name         = {Name}");
            Console.WriteLine($"surname      = {Surname}");
            Console.WriteLine($"height       = {Height} meters or {Height*100} centimeters");
            Console.WriteLine($"day of birth = {DayOfBirth.Date.ToShortDateString()}");
        }
        public void ShowAge()
        {
            int years = DateTime.Today.Year - DayOfBirth.Year;
            int months = DateTime.Today.Month - DayOfBirth.Month;
            if((DateTime.Today.DayOfYear < DayOfBirth.DayOfYear))
            {
                years --;
                months += 12;

            }
            Console.WriteLine($"{Name} has {years} year(s) and {months} month(s)");
        }
        public void ShowNameLikeUS()
        {
            String[] aux = Surname.Split();

            Console.WriteLine($"{aux[1]}, {Name} {aux[0]}");
        }
    }
}