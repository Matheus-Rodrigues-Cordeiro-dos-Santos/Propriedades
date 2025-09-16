using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercício_em_Grupro_Convertido_para_Clases
{
    class Aluno
    {
        private string N;//Nome
        private double N1;//1ª Nota
        private double N2;//2ª Nota

        public string Nome
        {
            get { return N; }
            set { N = value.ToUpper(); }
        }
        public double Nota1
        {
            get => N1;
            set => N1 = value;
        }
        public double Nota2
        {
            get => N2;
            set => N2 = value;
        }
        public double Media
        {
            get
            {
                double soma = 0;
                {
                    soma = (N1 + N2) / 2;
                }
                return soma;
            }
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Aluno A1 = new Aluno();
            Console.Write("Qual é o nome do aluno:");
            A1.Nome = Console.ReadLine();
            Console.Write("Qual é a 1ª nota do aluno:");
            A1.Nota1 = double.Parse(Console.ReadLine());
            Console.Write("Qual é a 2ª nota do aluno:");
            A1.Nota2 = double.Parse(Console.ReadLine());
            Console.WriteLine($"O(A) aluno(a):{(A1.Nome)}");
            Console.WriteLine($"1ª Nota:{(A1.Nota1)}");
            Console.WriteLine($"2ª Nota:{(A1.Nota2)}");
            Console.Write($"Media:{A1.Media.ToString("0,00")}");
            Console.ReadKey();
        }
    }
}
