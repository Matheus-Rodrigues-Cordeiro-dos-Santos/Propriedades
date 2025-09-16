using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercícioP2_Vetor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] V = new int[3];//Vetor com os Valores.
            int I;
            int S = 0;//Soma.
            int MV = 0;//Maior Valor.

            for (I = 0; I < 3; I++) {
                Console.WriteLine("Qual é o " + (I+1) + "º valor:");
                V[I] = int.Parse(Console.ReadLine());
                S = S + V[I];
                if (MV < V[I])
                {
                    MV = V[I];
                }
            }
            Console.WriteLine("A Soma dos Valores é:" + S);
            Console.WriteLine("A Media dos Valores é:" + S/3);
            Console.WriteLine("O Maior Valor é:" + MV);
            Console.ReadKey();
        }
    }
}
