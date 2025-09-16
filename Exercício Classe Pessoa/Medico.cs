using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercício_Classe_Pessoa
{
    internal class Medico : Pessoa
    {
        private string crm;
        private string especialidade;

        public string Crm { get => crm; set => crm = value; }
        public string Especialidade { get => especialidade; set => especialidade = value; }

        public string mostraMedico()
        {
            string V;//Visualizar
            V = "Nome: " + Nome;
            V = "\nIdade: " + Idade;
            V = "\nCPF: " + Cpf;
            V = "CMR: " + Crm;
            V = "Especialidade: " + Especialidade;
            return V;
        }
    }
}
