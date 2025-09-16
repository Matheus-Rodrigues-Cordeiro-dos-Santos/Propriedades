using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoTransacao_Classe_separada_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Trasacao T1 = new Trasacao();
            double A1, A2;
            Console.Write("Preço do Poduto:");
            A1 = double.Parse(Console.ReadLine());
            Console.Write("Valor Pago:");
            A2 = double.Parse(Console.ReadLine());
            T1.Gravar(A1 , A2);
            Console.WriteLine(T1.CalcularTroco());
            T1.Mostrar();
            Console.ReadKey();
        }
    }
}
