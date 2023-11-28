using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oat
{
    internal class Exercicio_11
    {
        public void Exercicio11()
        {
            double valor = 0;
            Console.WriteLine("Qual o preço do produto");
            double produto = double.Parse(Console.ReadLine());
            Console.WriteLine("====CONDIÇÕES DE PAGAMENTO====");
            Console.WriteLine("(1) À vista em dinheiro ou cheque, recebe 10% de desconto\n(2) À vista no cartão de credito, recebe 15% de desconto\n(3) Em duas vezes, preço normal de etiquetas sem juros\n(4) Em duas vezes, preço normal de etiqueta mais juros de 10%");
            Console.WriteLine("Escolha sua melhor condição: ");
            int condicao = int.Parse(Console.ReadLine());

            if (condicao == 1)
            {
                valor = produto - (produto * 10 / 100);
                Console.WriteLine("Produto com um desconto de 10% vai ficar " + valor);
            }
            else if (condicao == 2)
            {
                valor = produto - (produto * 15 / 100);
                Console.WriteLine("Produto com um desconto de 15% vai ficar " + valor);
            }
            else if (condicao == 3)
            {
                Console.WriteLine("Quantas parcelas: ");
                int parcela = int.Parse(Console.ReadLine());
                valor = (produto / parcela);
                Console.WriteLine("O preço do Produto dividido em " + parcela + " parcelas ficou em " + valor);
            }
            else if (condicao == 4)
            {
                Console.WriteLine("Quantas parcelas: ");
                int parcela = int.Parse(Console.ReadLine());
                valor = produto + (produto * parcela / 100);
                Console.WriteLine("O preço do Produto dividido em " + parcela + " parcelas ficou em " + valor);

            }
            Console.ReadLine();

        }
    }
}
        
    

