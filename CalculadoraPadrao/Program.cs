using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculadoraPadrao
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Padrão
            CalcPadrao CP = new CalcPadrao();
           
            Console.WriteLine("Calculadora Padrão:");
            Console.WriteLine("Soma: " + CP.Soma());
            Console.WriteLine("Subtrai: " + CP.Subtrai());
            //Cientifica
            CalcCientifica CT = new CalcCientifica();
            CadastroCalc(CT);
            Console.WriteLine("Calculadora Cientifica:");
            Console.WriteLine("Soma: " + CT.Soma());
            Console.WriteLine("Subtrai: " + CT.Subtrai());
            Console.WriteLine("Cubo de X: " + CT.CuboRegX());
            Console.ReadKey();
        }
        static void CadastroCalc(CalcPadrao aux)
        {
            aux.RedX = 5;
            aux.RedY = 2;

        }
    }
}
