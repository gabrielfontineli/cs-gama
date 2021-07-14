using System;

namespace ClassExercises
{
    class Program
    {
        static void Main(string[] args)
        {
            int Entry = 0;
            Console.WriteLine("******* Lista de Exercícios ********");

            do
            {
                Console.WriteLine(" ------------------------------------------ ");
                Console.Write("Digite o exercício que você deseja Run: ");
                Entry = int.Parse(Console.ReadLine());

                switch (Entry)
                {
                    case 1:
                        Exercise01.Run();
                        break;
                    case 2:
                        Exercise02.Run();
                        break;
                    case 3:
                        Exercise03.Run();
                        break;
                    case 4:
                        Exercise04.Run();
                        break;
                    case 5:
                        Exercise05.Run();
                        break;
                    case 6:
                        Exercise06.Run();
                        break;
                    case 7:
                        Exercise07.Run();
                        break;
                    case 8:
                        Exercise08.Run();
                        break;
                    case 9:
                        Exercise09.Run();
                        break;
                    case 10:
                        Exercise10.Run();
                        break;
                    case 99:
                        Console.WriteLine("Saindo do programa.");
                        break;
                    default:
                        Console.WriteLine("Exercício não encontrado.");
                        break;
                }

            } while (Entry != 99);

        }
    }
}
