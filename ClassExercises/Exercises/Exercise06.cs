using System;

namespace ClassExercises
{
    class Exercise06
    {
        public static void Run()
        {
            Console.WriteLine("-------Exercise 06-------");
            int IntDay;
            string StringDay;
            Console.WriteLine("enter a day of the week");
            IntDay = int.Parse(Console.ReadLine());


            switch (IntDay)
            {
                default:
                    StringDay = "valor(es) invalido(s)";
                    break;
                case 1:
                    StringDay = "Domingo";
                    break;
                case 2:
                    StringDay = "Segunda";
                    break;
                case 3:
                    StringDay = "Terça";
                    break;
                case 4:
                    StringDay = "Quarta";
                    break;
                case 5:
                    StringDay = "Quinta";
                    break;
                case 6:
                    StringDay = "Sexta";
                    break;
                case 7:
                    StringDay = "Sábado";
                    break;
            }

            Console.WriteLine(IntDay + " - " + StringDay);


        }

    }

}