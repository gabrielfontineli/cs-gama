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
            Console.WriteLine($"day of birth = {DayOfBirth.Date.ToString("dd/MM/yyyy")}");
        }
        public void ShowAge()
        {
            int years = DateTime.Today.Year - DayOfBirth.Year;
            int months = DateTime.Today.Month - DayOfBirth.Month;
            if((DayOfBirth.Month > DateTime.Now.Month) || (DayOfBirth.Month == DateTime.Now.Month && DayOfBirth.Day > DateTime.Now.Day))
            {
                years --;
                months += 12;

            }
            Console.WriteLine($"{Name} has {years} year(s) and {months} month(s)");
        }
        public void ShowNameLikeUS()
        {

            Console.WriteLine($"{Surname}, {Name}");
        }
    }
}