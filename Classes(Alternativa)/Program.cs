using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes_Alternativa_
{
    class Aluno
    {
        string N;//Nome
        double N1;//Nota 1
        double N2;//Nota 2

        public Aluno()
        {
            Console.WriteLine("Criei o Objeto Aluno");
        }

        public Aluno(string N)
        {
            this.N = N;
        }
        public void Gravar()
        {
            Console.Write("Digite o Nome do Aluno:");
            N = Console.ReadLine();
            Console.Write("Nota 1:");
            N1 = double.Parse(Console.ReadLine());
            Console.Write("Nota 2:");
            N2 = double.Parse(Console.ReadLine());
        }
        public void Mostrar()
        {
            Console.WriteLine("Aluno: " + N + "\n Nota 1: " + N1.ToString("0.00") + "\n Nota 2: " + N2.ToString("0.00") + "\n Media: " + Media().ToString("0.00"));
        }
        public double Media()
        {
            return (N1 + N2) / 2;
        }
    }
        internal class Program
    {
        static void Main(string[] args)
        {
            Aluno A1 = new Aluno();
            A1.Gravar();
            A1.Mostrar();
            Aluno A2 = new Aluno();
            Console.Write("Nome do Aluno: ");
            string N = Console.ReadLine();
            A2.Gravar();
            A2.Mostrar();
            Console.ReadKey();

        }
    }
}
