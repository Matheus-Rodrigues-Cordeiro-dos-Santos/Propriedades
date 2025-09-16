using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Projeto2;

namespace Projeto2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CalculadoraCientifica CC = new CalculadoraCientifica(2, 5, 8);
            Console.WriteLine(CC.cubo());
            Console.ReadKey();
        }
    }
}
