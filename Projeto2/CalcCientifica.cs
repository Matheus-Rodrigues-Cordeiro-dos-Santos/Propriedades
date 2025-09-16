using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto2
{
    class CalculadoraCientifica : CalculadoraPadrao
    {
        private double regZ;
        public CalculadoraCientifica(double regX, double regY, double regZ) : base(regX, regY)//classe base classe reservada
        {
            this.regZ = regZ;
        }
        public double cubo()
        {
            return regX * regX * regX;
        }
    }
}
