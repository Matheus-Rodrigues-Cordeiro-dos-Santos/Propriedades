using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculadoraPadrao
{
    internal class CalcPadrao
    {
        private double redX;
        private double redY;

        public double RedX { get => redX; set => redX = value; }
        public double RedY { get => redY; set => redY = value; }

        public double Soma()
        {
            return RedX + RedY;
        }

        public double Subtrai()
        {
            return RedX - RedY;
        }
    }
}
