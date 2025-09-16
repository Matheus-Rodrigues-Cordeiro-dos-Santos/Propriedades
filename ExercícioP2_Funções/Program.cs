using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercícioP2_Funções
{
    internal class Program
    {
        static int TroVa()
        {
            int[] VT = new int[2];//Valor Trocado.
            int I;
            int A;//Auxiliar.
            for (I = 0; I < 2; I++)
            {
                Console.WriteLine("Qual é o " + (I + 1) + "º Valor: ");
                VT[I] = int.Parse(Console.ReadLine());
                if (I == 0)
                {
                    A = VT[I];
                }
                else
                {
                    V[I - 1] = VT[I];
                    V[I] = A;
                    return 0;
                }
                Console.WriteLine("O 1º Valor é:" + VT[0]);
                Console.WriteLine("O 2º Valor é:" + VT[1]);
            }
        }
        static int Vet()
        {
            int[] V = new int[3];//Vetor de Números inteiros.
            int S = 0;//Soma.
            int I;
            for (I = 0; I < 3; I++) 
            {
                Console.WriteLine("Qual é o " + (I + 1) + "º Valor:");
                V[I] = int.Parse(Console.ReadLine());
                S = S + V[I];
            }
            Console.WriteLine("A Soma do Valores é:" + S);
        }
        static void Main(string[] args)
        {

            Console.WriteLine("Parte A");
            Console.WriteLine(TroVa());

            Console.WriteLine("Parte B");
            Console.WriteLine(Vet());
        }
    }
}
