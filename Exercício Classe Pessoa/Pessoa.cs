using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercício_Classe_Pessoa
{
    internal class Pessoa
    {
        private string nome;
        private int idade;
        private string cpf;

        public string Nome { get => nome; set => nome = value; }
        public int Idade { get => idade; set => idade = value; }
        public string Cpf { get => cpf; set => cpf = value; }

        public string cadastropessoal(Pessoa obj)
        {
            string V;//Visualizar
            V = "Nome: " + Nome;
            V = "\nIdade: " + Idade;
            V = "\nCPF: " + Cpf;
            return V;
        }
    }
}