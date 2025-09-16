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
            int[,] M = new int[3,3];//Vetor com os Valores.
            int L;//Linha.
            int C;//Coluna.
            int S = 0;//Soma.
            int MV = 0;//Maior Valor.

            for (L = 0; L < 3; L++)
            { 
                for (C = 0; C < 3; C++)
                {
                    Console.WriteLine("Qual é o valor da " + (L + 1) + "º Linha " + (C + 1) + "º Coluna:");
                    M[L,C] = int.Parse(Console.ReadLine());
                    S = S + M[L,C];
                    if (MV < M[L,C])
                    {
                        MV = M[L,C];
                    }
                }
            }
            Console.WriteLine("A Soma dos Valores é:" + S);
            Console.WriteLine("A Media dos Valores é:" + S / 9);
            Console.ReadKey();
        }
    }
}
