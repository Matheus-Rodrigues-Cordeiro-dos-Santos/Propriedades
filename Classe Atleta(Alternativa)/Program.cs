using System;
using System.Collections.Generic;

namespace Classe_Atleta_Alternativa_
{
    class Atleta
    {
        string N;//Nome
        int I;//Idade
        string[] M;//Modalidades
        int VB;//Valor da Bolsa

        public GravarDados()
        {
            VB = 0;
            Console.Write("Nome: ");
            N = Console.ReadLine();
            Console.Write("Idade: ");
            I = int.Parse(Console.ReadLine());
            Console.Write("Número de Modalidades: ");
            int NM = int.Parse(Console.ReadLine());//Número de Modalidades
            M = new string[NM];
            for (int I = 0; I < NM; I++)
            {
                Console.Write("Modalidade" + I + 1 + ": ");
                M[I] = Console.ReadLine();
                VB += M[I] == "Futebol" ? 20 : 0;
                VB += M[I] == "Voleibol" ? 10 : 0;
                VB += M[I] == "Natação" ? 20 : 0;
                VB += M[I] == "Basquete" ? 15 : 0;
            }
        }
        public void MostrarDados()
        {
            Console.WriteLine(N + I);
            foreach (string item in M)
            {
                Console.WriteLine(item + "\t");
            }
            Console.WriteLine("Conseguiu" + VB + "% de Bolsa");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Atleta A;
            List<Atleta> ListaAtletas = new List<Atleta>();
            int OP;
            do
            {
                Console.Clear();
                Console.WriteLine("1.Cadastrar Atletas");
                Console.WriteLine("2.Mostrar os dados de um atleta especifico");
                Console.WriteLine("3.Mostrar todos os atletas que possuem desconto maior que 30%");
                Console.WriteLine("4.Pesquisar o nome do atleta de uma determinada modalidade");
                Console.WriteLine("5.Verificar os atletas que possuem desconto maior que 30%");
                Console.WriteLine("0.Sair");
                Console.Write("Opções:");
                OP = int.Parse(Console.ReadLine());

                switch (OP)
                {
                    case 1:
                        {
                            A = new Atleta();
                            A.GravarDados()
                            ListaAtleta.Add(A);
                            break;
                        }
                    case 2:
                        {
                            Console.Write("Nome: ");
                            string AXN = Console.ReadLine();//AX = Auxiliar
                            foreach (string item in ListaAtletas)
                            {
                                if (item.MostrarNome() == AXN)
                                    item.MostrarNome();
                            }
                            break;
                        }
                    case 3:
                        {
                            foreach(Atleta item in ListaAtletas)
                            {
                                item.MostrarDados()
                            }
                            break;
                        }
                    case 4:
                        {
                            Console.WriteLine("Modalidades");
                            string AXM = Console.ReadLine();
                            foreach(string M in item.MostrarModalidades())
                            {
                                if (M == AXM)
                                    item.MostrarModalidades();
                            }
                        }
                        Console.ReadKey();
                }
            } while (OP != 0);
        }
    }
}
