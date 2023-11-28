using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oat
{
    internal class Exercicio_03
    {
        public void Exercicio3()
        {
            Console.WriteLine("Informe um número qualquer: ");
            int numero = int.Parse(Console.ReadLine());

            if (numero % 2 == 0)
            {
                Console.WriteLine("Esse número é PAR");
            }
            else
            {
                Console.WriteLine("Esse número é IMPAR");
            }
            Console.ReadLine();
        }
    }
}

