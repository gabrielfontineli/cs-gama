using System;

namespace ClassExercises
{
    class Exercise01
    {
        public static void Run()
        {
            Console.WriteLine("-------Exercise 01-------");

            float grade1, grade2, final; // declarei as variaveis
            grade1 = grade2 = 0;
            try
            {
                
                Console.WriteLine("enter your first grade"); // perguntando a nota 1
                grade1 = float.Parse(Console.ReadLine()); // recebo a entrada na variavel'
                float.TryParse(Console.ReadLine(),out float Tempgrade1);
                grade1 = Tempgrade1;
                Console.WriteLine("enter your second grade"); // perguntando a nota 2
                grade2 = float.Parse(Console.ReadLine()); // recebo a entrada
            }
            catch (Exception e)
            {
                Console.WriteLine("Valor inválido");
                Console.WriteLine(e.Message);
            }

            final = (grade1 + grade2) / 2; // calcular media

            if (final >= 7) // se a nota final for maior ou igual a 7
            {
                if (final == 10)
                {
                    Console.WriteLine("Aprovado com Distinção");
                }

                else
                {
                    Console.WriteLine("Aprovado com nota " + final);
                }
            }
            else
            {
                Console.WriteLine("Reprovado com nota " + final);
            }






        }

    }

}