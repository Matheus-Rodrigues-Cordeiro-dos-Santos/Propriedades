using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Registro_de_Aluno_Data
{
    internal class Aluno
    {
        private string nome;
        private TData objeto_data;

        public Aluno()
        {
            Objeto_data = new TData();
        }
        public string Nome {get => nome; set => nome = value; }
        public TData Objeto_data { get => objeto_data; set => objeto_data = value; }

        public string MostrarAluno()
        {
            string AUX;
            AUX = nome + " - " + objeto_data.MostrarData();
            return AUX;
        }
    }
}
