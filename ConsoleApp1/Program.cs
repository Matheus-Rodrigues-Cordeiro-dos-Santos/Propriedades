using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes_Massa_Corporal
{
    class IMC
    {
        public string N;//Nome
        public double P;//Peso
        public double A;//Altura

        public void Gravar() 
        {
            Console.Write("Digite o Nome do Indivíduo:");
            N = Console.ReadLine();
            Console.Write("Peso:");
            P = double.Parse(Console.ReadLine());
            Console.Write("Altura:");
            A = double.Parse(Console.ReadLine());
        }
        public void Mostrar()
        {
            Console.WriteLine("O indivíduo: " + N + "\n Peso: " + P.ToString("0.00") + "\n Altura: " + A.ToString("0.00") + "\n Media: " + Calcular().ToString("0.00"));
        }
        public double Calcular()
        {
            return P / (A * A);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            IMC I = new IMC();
            I.Gravar();
            I.Mostrar();
            Console.ReadKey();
        }
    }
}
