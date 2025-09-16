using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercícioP1Vacina
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string E1;//1ºEstado.
            string E2;//2ºEstado.
            string E3;//3ºEstado.
            int C;//Continuar?
            int PV;//Pessoas Vacinadas.
            float PT;//População Total.
            float PPV;//Porcentagem de Pessoas Vacinadas.
            float PNV;//Porcentagem de Pessoas Não Vacinadas.

            do
            {
                Console.WriteLine("Informe o Nome do 1ºEstado Brasileiro:");
                E1 = Console.ReadLine();
                Console.WriteLine("Qual é a sua População:");
                PT = float.Parse(Console.ReadLine());
                Console.WriteLine("Número de Pessoas Vacinadas:");
                PV = int.Parse(Console.ReadLine());
                PPV = (PV * 100) / PT;
                PNV = 100 - PPV;
                Console.WriteLine(PNV + "% Não Foram Vacinadas.");
                PT = 0;
                PV = 0;
                PPV = 0;
                PNV = 0;
                Console.WriteLine();

                Console.WriteLine("Informe o Nome do 2ºEstado Brasileiro:");
                E1 = Console.ReadLine();
                Console.WriteLine("Qual é a sua População:");
                PT = float.Parse(Console.ReadLine());
                Console.WriteLine("Número de Pessoas Vacinadas:");
                PV = int.Parse(Console.ReadLine());
                PPV = (PV * 100) / PT;
                PNV = 100 - PPV;
                Console.WriteLine("Faltam Vacinar" + );
                PT = 0;
                PV = 0;
                PPV = 0;
                PNV = 0;
                Console.WriteLine();

                Console.WriteLine("Informe o Nome do 2ºEstado Brasileiro:");
                E1 = Console.ReadLine();
                Console.WriteLine("Qual é a sua População:");
                PT = float.Parse(Console.ReadLine());
                Console.WriteLine("Número de Pessoas Vacinadas:");
                PV = int.Parse(Console.ReadLine());
                PPV = (PV * 100) / PT;
                PNV = 100 - PPV;
                Console.WriteLine(PNV + "% Não Foram Vacinadas.");
                PT = 0;
                PV = 0;
                PPV = 0;
                PNV = 0;
                Console.WriteLine();
                Console.WriteLine("Deseja Continuar?(1 = Sim/2 = Não)");
                C = int.Parse(Console.ReadLine());
            } while (C == 1);
        }
    }
}
