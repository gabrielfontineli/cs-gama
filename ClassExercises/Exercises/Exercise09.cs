using System;

namespace ClassExercises
{
    class Exercise09
    {
        public static void Run()
        {
            Console.WriteLine("-------Exercise 09-------");
            int day, month, year, max;
            bool isValid;
            max = 31;

            Console.WriteLine("enter a day in format dd/mm/aaaa");
            string[] entry = Console.ReadLine().Split('/');

            day = int.Parse(entry[0]);
            month = int.Parse(entry[1]);
            year = int.Parse(entry[2]);

            switch (month)
            {
                case 2:
                    if (year % 4 == 0 && year % 100 != 0 || year % 400 == 0) max = 29;
                    else max = 28; break;
                case 4:
                case 6:
                case 9:
                case 11: max = 30; break;
            }
            if ( day >= 1 && day <=max && month >=1 && month <=12)
            {
                isValid = true;
            }
            else isValid = false;
            Console.WriteLine(isValid ? "Data valida" : "Data invalida");

        }

    }

}