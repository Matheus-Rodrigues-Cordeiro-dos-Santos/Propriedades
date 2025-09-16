using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercício_Classe_Pessoa
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Medico m = new Medico();

            //método de cadastro dos atributos em comum da classe medico e pessoa
            cadastropessoal(m);

            Console.Write("CRM: ");
            m.Crm = Console.ReadLine();
            Console.Write("Especialidade: ");
            m.Especialidade = Console.ReadLine();
            Console.WriteLine("\n" + m.mostraMedico());

            Paciente p = new Paciente();
            //método de cadastro dos atributos em comum da classe paciente e pessoa

            cadastropessoal(p);
            Console.Write("Plano: ");
            p.Plano = Console.ReadLine();
            Console.WriteLine("\n" + p.mostraPaciente());
            Console.ReadKey();
        }
        static void cadastropessoal(Pessoa obj)
        {
            if (obj is Medico)
                Console.WriteLine("\n Cadastro de médico \n");
            else
                Console.WriteLine("\n Cadastro de Paciente \n");
            Console.Write("CPF: ");
            obj.Cpf = Console.ReadLine();
            Console.Write("Nome: ");
            obj.Nome = Console.ReadLine();
            Console.Write("Idade: ");
            obj.Idade = int.Parse(Console.ReadLine());
        }
    }
}
