using System;
using static Associacao.Clente;

namespace Associacao
{
    class Clente
    {
        internal class Cliente
        {
            private TCPF objeto_cpf;
            private string nome;
            private TEndereco objeto_endereco;
            public string Nome
            { get => nome; set => nome = value; }
            public TCPF Objeto_cpf
            { get => Objeto_cpf; set => Objeto_cpf = value; }
            public TEndereco
            { get => objeto_endereco; set => objeto_endereco = value; }
        
    }

            public Cliente()
            {
                objeto_cpf = new TCPF();
                objeto_endereco = new TEndereco();
            }
        }
        internal class Program
        {
            static void Main(string[] args)
            {
            Cliente C1 = new Cliente();
            Console.Write("Nome Cliente: ");
            C1.Nome = Console.ReadLine();

            Console.Write("CPF: ");
            string auxcpf = Console.ReadLine();

            if (C1.Objeto_cpf.ValidaCpf(auxcpf) == false)
                Console.WriteLine("CPF inválido");
            else
                Console.WriteLine("CFP Válido");

            Console.WriteLine("Entre com seu Numero: ");
            C1.Objeto_endereco.Num = int.Parse(Console.ReadLine());
            Console.WriteLine("Entre com sua Rua: ");
            C1.Objeto_endereco.Rua = (Console.ReadLine());
            Console.WriteLine("Entre com seu Bairro: ");
            C1.Objeto_endereco.Bairro = (Console.ReadLine());
            Console.WriteLine("\nMostrando Endereço: \n" + C1.Objeto_endereco.MostrarEndereco());

            Console.WriteLine("\nMostrando Cliente");
            Console.WriteLine(C1.Nome);
            Console.WriteLine(C1.Objeto_cpf.MostraCPF());
            Console.ReadKey();
            }
        }
}

