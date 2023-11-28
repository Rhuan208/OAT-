using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oat
{
    internal class Exercicio_04
    {
        public void Exercicio4()
        {
            int soma = 0;
            int multiplicar = 0;
            int auxiliar = 0;
            Console.WriteLine("Informe o valor de A: ");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Informe o valor de B: ");
            int b = int.Parse(Console.ReadLine());

            if (a == b)
            {
                soma = a + b;
                auxiliar = soma;
                Console.WriteLine("O valor da soma de A + B é: " + auxiliar);
            }
            else
            {
                multiplicar = a * b;
                auxiliar = multiplicar;
                Console.WriteLine("O valor da multiplicação de A * B é: " + auxiliar);
            }
            Console.ReadLine();
        }
    }
}
