using System;

namespace ClassExercises
{
    class Exercise05
    {
        public static void Run()
        {
            Console.WriteLine("-------Exercise 05-------");
            double sallary, fgts, ir, inss, sindicato, ValuePerHour, HourPerMonth, fgtsValue, irValue, sindicatoValue, inssValue, totalDiscount;
            sindicato = 0.03; fgts = 0.11;
            Console.WriteLine("enter value per hour:"); // QUAL É O VALOR DA HORA
            ValuePerHour = double.Parse(Console.ReadLine());
            Console.WriteLine("enter hour per month:"); // QUAL É O NUMERO DE HORAS POR MES
            HourPerMonth = double.Parse(Console.ReadLine());

            sallary = ValuePerHour * HourPerMonth; // SALARIO BRUTO

            if (sallary <= 2000)
            {
                ir = 0; // IMPOSTO DE RENDA == ISENTO
            }
            else if (sallary > 2000 && sallary <= 5000)
            {
                ir = 0.05; // IMPOSTO DE RENDA = 5%
            }
            else if (sallary > 5000 && sallary <= 7500)
            {
                ir = 0.1; // IMPOSTO DE RENDA = 10%
            }
            else
            {
                ir = 0.2; // IMPOSTO DE RENDA = 20%
            }

            Console.WriteLine($"        Salario Bruto: ({ValuePerHour}*{HourPerMonth}) : R${sallary}");

            irValue = ir * sallary;
            Console.WriteLine($"(-) IR ({ir*100}%)                 : R$ {irValue}");

            sindicatoValue = sindicato * sallary;
            Console.WriteLine($"(-) Sindicato({sindicato * 100}%)           : R$ {sindicatoValue}");

            inss = 0.1;
            inssValue = inss * sallary;
            Console.WriteLine($"(-) INSS({inss*100}%)               : R$ {inssValue}");

            fgtsValue = fgts * sallary;
            Console.WriteLine($"FGTS ({fgts * 100}%)                  : R${fgtsValue}");

            totalDiscount = irValue + inssValue + sindicatoValue;
            Console.WriteLine($"Total de descontos          : R$ {totalDiscount}");
            Console.WriteLine($"Salario liquido             : R$ {sallary - totalDiscount}");



        }

    }

}