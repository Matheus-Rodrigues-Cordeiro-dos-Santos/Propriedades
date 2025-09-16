using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercícioP1Menu
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string NP;//Nome do Produto.
            float VP;//Valor do Produto.
            int OP;//Opições.
            int FP;//Forma de Pagamento.
            int QP;//Quantas Parcelas?
            do
            {
                Console.WriteLine("Menu:");
                Console.WriteLine("1.Nome do Produto:");
                Console.WriteLine("2.Valor do Produto:");
                Console.WriteLine("3.Forma de Pagamento:");
                Console.WriteLine("4.Mostrar Dados da Compra:");
                Console.WriteLine("0.Sair");
                Console.WriteLine("Escolha uma Opção:");
                OP = int.Parse(Console.ReadLine());
                switch (OP)
                {
                    case 1:
                        Console.WriteLine("Nome do Produto:");
                        NP = Console.ReadLine();
                        break;
                    case 2:
                        Console.WriteLine("Qual é o Valor do Produto:");
                        VP = float.Parse(Console.ReadLine());
                        break;
                    case 3:
                        Console.WriteLine("As Formas de Pagamento são:");
                        Console.WriteLine("1 = A Vista (Tem desconto de 10%) ");
                        Console.WriteLine("2 = Pix");
                        Console.WriteLine("3 = Parcelado");
                        Console.WriteLine("Qual é a Forma de Pagamento:");
                        FP = int.Parse(Console.ReadLine());
                        if (FP == 1)
                        {
                            {
                                VP = VP * 0.9;
                                Console.WriteLine("Novo Valor do Produto:" + VP.ToString("R$0,00"));
                            }
                        }
                        if (FP == 2)
                            {
                                Console.WriteLine("Codígo do Pix: 0123456789");
                            }
                            if (FP == 3)
                            {
                                Console.WriteLine("Quantas Parcelas:");
                                QP = int.Parse(Console.ReadLine());
                                VP = VP / QP;
                                Console.WriteLine("Você vai Pagar " + QP + "Parcelas de " + VP.ToString("R$0,00"));
                            }
                            else
                                Console.WriteLine("Opção Invalida!!!");
                            
                            break;
                    case 4:
                         Console.WriteLine("Produto: " + NP);
                         Console.WriteLine("Forma de Pagamento:");
                         if (FP == 1)
                         {
                            Console.WriteLine("Valor do Produto com Desconto:" + VP.ToString("R$0,00"));
                         }
                         if (FP == 2)
                         {
                            Console.WriteLine("Pix");
                            Console.WriteLine("Valor do Produto: " + VP);
                         }
                         if (FP == 3)
                         {
                            Console.WriteLine("Você vai Pagar " + QP + "Parcelas de " + VP.ToString("R$0, 00"));
                         }
                    }
             } while (OP != 0);
         } 
     }
}

