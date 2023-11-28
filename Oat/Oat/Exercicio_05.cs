using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oat
{
    internal class Exercicio_05
    {
        public void Exercicio5()
        {
            Console.WriteLine("Digite um número Positivo ou Negativo: ");
            int numero = int.Parse(Console.ReadLine());

            if (numero >= 0)
            {
                int resultado = numero * 2;
                Console.WriteLine("O Dobro do número positivo informado é de: " + resultado);
            }
            else
            {
                int resultado = numero * 3;
                Console.WriteLine("O Triplo do número negativo é: " + resultado);
            }
            Console.ReadLine();
        }
    }
}
