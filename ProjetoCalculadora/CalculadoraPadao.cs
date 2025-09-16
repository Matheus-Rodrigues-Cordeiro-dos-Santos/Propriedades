using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoCalculadora
{
    class CalculadoraPadrao
    {
        private double regX;
        private double regY;
        public CalculadoraPadrao(double regX, double regY)
        {
            this.regX = regX;
            this.regY = regY;
        }
        public double soma()
        {
            return regX + regY;
        }
    }
}
