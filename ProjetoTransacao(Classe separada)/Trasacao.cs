using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoTransacao_Classe_separada_
{
    internal class Trasacao
    {
        private double PrecoPruduto;
        private double ValorPago;

        public void Gravar(double PrecoProduto, double ValorPago)
        {
            this.PrecoPruduto = PrecoProduto;
            this.ValorPago = ValorPago;
        }
        public double CalcularTroco()
        {
            if (ValorPago >= PrecoPruduto)
            {
                return PrecoPruduto - ValorPago;
            }
            else
            {
                return -1;
            }
        }
        public string Mostrar()
        {
            string A = "";
            A = "Valor do Pruduto: " + PrecoPruduto.ToString("0.00");
            A += "Valor Pago: " + ValorPago.ToString("0.00");
            if (CalcularTroco() >= 0) {
                A += "\nTroco: " + CalcularTroco().ToString("0.00");
            }
            else
            {
                A += "\nValor Insuficiente. Trasação cancelada";
            }
            return A;
        }

    }
}
