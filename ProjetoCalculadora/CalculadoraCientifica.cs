using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoCalculadora
{
    class CalculadoraCientifica : CalculadoraPadrao
    {
        public CalculadoraCientifica(double regX, double regY) : base(regX, regY)
        { }
        public double cubo()
        {
            return regX * regX * regX;
        }
    }
}
    namespace ProjetoCalculadora
{
    class CalculadoraProgramador : CalculadoraPadrao
    {
        public CalculadoraProgramador(double regX, double regY) : base(regX, regY)
        { }
        public string binario()
        {
            int Y = Convert.ToInt32(soma());
            return Convert.ToString(Y, 2);
        }
    }
}
