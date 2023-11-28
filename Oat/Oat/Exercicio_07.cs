using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oat
{
    internal class Exercicio_07
    {
        public void Exercicio7()
        {
            Console.WriteLine("Informe um número: ");
            int numero = int.Parse(Console.ReadLine());
            Console.WriteLine("==============");

            if (numero % 2 == 0)
            {
                int resultado = numero + 5;
                Console.WriteLine("O resultado final da soma é: " + resultado);
            }
            else
            {
                int resultado = numero + 8;
                Console.WriteLine("O resultado final da soma é: " + resultado);
            }
            Console.ReadLine();
        }
    }
}
