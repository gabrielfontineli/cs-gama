using System;

namespace ClassExercises
{
    class Exercise07
    {
        public static void Run()
        {
            Console.WriteLine("-------Exercise 07-------");
            float Grade1, Grade2, FinalGrade;

            Console.WriteLine("enter grade");
            Grade1 = float.Parse(Console.ReadLine());

            Console.WriteLine("enter grade");
            Grade2 = float.Parse(Console.ReadLine());

            FinalGrade = (Grade1 + Grade2) / 2;
            string GradeConcept;

            if (FinalGrade >= 0 && FinalGrade < 4)
            {
                GradeConcept = "E";
            }
            else if (FinalGrade > 4 && FinalGrade <= 6)
            {
                GradeConcept = "D";
            }
            else if (FinalGrade >= 6 && FinalGrade < 7.5)
            {
                GradeConcept = "C";
            }
            else if (FinalGrade >= 7.5 && FinalGrade < 9)
            {
                GradeConcept = "B";
            }
            else if (FinalGrade >= 9 && FinalGrade <= 10)
            {
                GradeConcept = "A";
            }
            else GradeConcept = "Invalid input";
            Console.WriteLine($"Grade 1 = {Grade1} | | Grade 2 = {Grade2}");
            Console.WriteLine($"Grade concept: {GradeConcept}");
            Console.WriteLine(FinalGrade >=6 ? "APROVADO" : "REPROVADO" );

        }

    }

}