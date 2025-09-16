using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoCalculadora
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CalculadoraPadrao C = new CalculadoraPadrao(1, 4);
            Console.WriteLine(C.soma());
            CalculadoraCientifica CC = new CalculadoraCientifica(2, 5);
            Console.WriteLine(CC.cubo());
            CalculadoraProgramador CP = new CalculadoraProgramador(2, 3);
            Console.WriteLine(CP.binario());
            Console.ReadKey();
        }
    }
}
