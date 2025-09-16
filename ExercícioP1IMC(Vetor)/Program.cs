using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercícioP1IMC
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float[] IMC = new float[5];//Indice de Massa Corporal
            float P;//Pesso
            float A;//Altura
            string[] N = new string[5];//Nome
            float M = 0;//Magro
            float PN = 0;//Peso Normal
            float SP = 0;//SobrePeso
            float O = 0;//Obeso
            float OG = 0;//Obeso Grave
            int I;
            for (I = 0; I < 5; I++)
            {
                Console.WriteLine("Nome:");
                N[I] = Console.ReadLine();
                Console.WriteLine("Peso:");
                P = float.Parse(Console.ReadLine());
                Console.WriteLine("Altura:");
                A = float.Parse(Console.ReadLine());
                IMC[I] = (float)(P / Math.Pow(A, 2));
                if (IMC[I] < 18.5)
                {
                    M++;
                }
                else if (IMC[I] >= 18.5 && IMC[I] <= 24.9)
                {
                    PN++;
                }
                else if (IMC[I] >= 25.0 && IMC[I] <= 29.9)
                {
                    SP++;
                }
                else if (IMC[I] >= 30.0 && IMC[I] <= 39.9)
                {
                    O++;
                }
                else
                    OG++;
                Console.WriteLine("IMC - Indice de Massa Corporal (Peso/AlturaxAltura)");
                Console.WriteLine(N[I] + "seu IMC é " + IMC[I].ToString("00.0"));
                Console.ReadKey();
            }
            Console.WriteLine("Análise: \n" + M * 100 / 5 + "% Magros\n" + PN * 100 / 5 + "% Normais\n" + SP * 100 / 5 + "% Sobrepesos\n" + O * 100 / 5 + "% Obesos\n" + OG * 100 / 5 + "% Obesos Grave\n");
        }
    }
}
