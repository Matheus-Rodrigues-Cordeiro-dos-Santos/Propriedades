using System;
using System.Collections.Generic;

namespace Classes_Alternativa_
{
     class Atleta
    {
        private string N;//Nome
        private int I;//Idade
        private string M;//Mdalidade
        private double VB;//Valor daBolsa 

        // Vetor de modalidades e seus respectivos valores de bolsa
        private static string[] MS = { "Futebol", "Voleibol", "Natação", "Basquete" };//Modalidades
        private static double[] VBS = { 0.20, 0.10, 0.20, 0.15 };//Valores das Bolsas

        // Construtor
        public Atleta(string N, int I, string M)
        {
            this.N = N;
            this.I = I;
            this.M = M;

            // Calcular valor da bolsa com base na modalidade
            int index = Array.IndexOf(MS, M);
            this.VB = index != -1 ? VBS[index] : 0;
        }

        // Método para gravar os dados do atleta
        public void GravarDados()
        {
            Console.WriteLine("Dados do Atleta:");
            Console.WriteLine($"Nome: {N}");
            Console.WriteLine($"Idade: {I}");
            Console.WriteLine($"Modalidade: {M}");
            Console.WriteLine($"Valor da Bolsa: {VB:P}");
        }

        // Método para mostrar os dados do atleta
        public void MostrarDados()
        {
            Console.WriteLine($"Nome: {N}, Idade: {I}, Modalidade: {M}, Valor da Bolsa: {VB:P}");
        }

        // Método para retornar somente o nome do atleta
        public string ObterNome()
        {
            return N;
        }

        // Método para retornar somente as modalidades do atleta
        public string ObterModalidade()
        {
            return M;
        }

        // Método para verificar se o atleta possui desconto maior que 30%
        public bool PossuiDescontoMaiorQue30()
        {
            return VB > 0.30;
        }
    }

class Program
    {
        static List<Atleta> atletas = new List<Atleta>();

        static void Main(string[] args)
        {

            Console.WriteLine("\nMenu:");
            Console.WriteLine("1. Cadastrar Atletas");
            Console.WriteLine("2. Mostrar os dados de um atleta especificado pelo usuário através do seu nome");
            Console.WriteLine("3. Mostrar todos os atletas");
            Console.WriteLine("4. Pesquisar o nome dos atletas de uma determinada modalidade");
            Console.WriteLine("5. Verificar os atletas que possuem desconto maior que 30%");
            Console.WriteLine("0. Sair");

            Console.Write("Escolha uma opção: ");
            int OP = int.Parse(Console.ReadLine());
            do
            {

                switch (OP)
                {
                    case 1:
                        CadastrarAtleta();
                        break;
                    case 2:
                        MostrarDadosAtletaPorNome();
                        break;
                    case 3:
                        MostrarTodosAtletas();
                        break;
                    case 4:
                        PesquisarAtletasPorModalidade();
                        break;
                    case 5:
                        VerificarAtletasDescontoMaiorQue30();
                        break;
                    default:
                        Console.WriteLine("Opção inválida. Tente novamente.");
                        break;
                } 
            } while (OP != 0);
        }

        static void CadastrarAtleta()
        {
            Console.WriteLine("\nCadastro de Atleta:");
            Console.Write("Nome: ");
            string N = Console.ReadLine();
            Console.Write("Idade: ");
            int I = int.Parse(Console.ReadLine());
            Console.Write("Modalidade: ");
            Console.Write("Futebol: 20%");
            Console.Write("Voleibol: 10%");
            Console.Write("Natação: 20%");
            Console.Write("Basquete: 15%");
            string M = Console.ReadLine();

            Atleta novoAtleta = new Atleta(N, I, M);
            atletas.Add(novoAtleta);

            Console.WriteLine("Atleta cadastrado com sucesso!");
        }

        static void MostrarDadosAtletaPorNome()
        {
            Console.WriteLine("\nDigite o nome do atleta:");
            string N = Console.ReadLine();

            Atleta AE = atletas.Find(A => A.ObterNome() == N);//Atleta Encontrado

            if (AE != null)
            {
                AE.MostrarDados();
            }
            else
            {
                Console.WriteLine("Atleta não encontrado.");
            }
        }

        static void MostrarTodosAtletas()
        {
            Console.WriteLine("\nLista de Atletas:");
            foreach (var atleta in atletas)
            {
                atleta.MostrarDados();
            }
        }

        static void PesquisarAtletasPorModalidade()
        {
            Console.WriteLine("\nDigite a modalidade:");
            string M = Console.ReadLine();

            List<Atleta> AM = atletas.FindAll(a => a.ObterModalidade() == M);//Modalidade do Atleta

            if (AM.Count > 0)
            {
                Console.WriteLine($"Atletas da modalidade {M}:");
                foreach (var atleta in AM)
                {
                    Console.WriteLine(atleta.ObterNome());
                }
            }
            else
            {
                Console.WriteLine("Nenhum atleta encontrado para essa modalidade.");
            }
        }

        static void VerificarAtletasDescontoMaiorQue30()
        {
            List<Atleta> atletasComDescontoMaiorQue30 = atletas.FindAll(A => A.PossuiDescontoMaiorQue30());

            if (atletasComDescontoMaiorQue30.Count > 0)
            {
                Console.WriteLine("Atletas com desconto maior que 30%:");
                foreach (var atleta in atletasComDescontoMaiorQue30)
                {
                    Console.WriteLine(atleta.ObterNome());
                }
            }
            else
            {
                Console.WriteLine("Nenhum atleta possui desconto maior que 30%.");
            }
        }
    }


}
