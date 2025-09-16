using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercício_Classe_Pessoa
{
    internal class Paciente : Pessoa
    {
        private string plano;

        public string Plano { get => plano; set => plano = value; }

        public string mostraPaciente()
        {
            string V;//Visualizar
            V = "Nome: " + Nome;
            V = "\nIdade: " + Idade;
            V = "\nCPF: " + Cpf;
            V = "Plano: " + Plano;
            return V;
        }
    }
}
