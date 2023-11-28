using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oat
{
    internal class Exercicio_06
    {
        public void Exercicio6()
        {
            bool A;
            bool B;
            string resultado = string.Empty;
            int contador = 0;

            do
            {
                if (contador != 0)
                    Console.WriteLine("Incorreto, insira o valor de (A) true ou false");
                else
                    Console.WriteLine("Informe se o valor de (A) e true ou false");
                resultado = Console.ReadLine();
                bool.TryParse(resultado, out A);
                contador += 1;
            } while (resultado != "true" && resultado != "false");

            resultado = string.Empty;
            contador = 0;

            do
            {
                if (contador != 0)
                    Console.WriteLine("Incorreto, insira o valor de (B) True ou False");
                else
                    Console.WriteLine("Informe se o valor de (B) e true ou false");
                resultado = Console.ReadLine().ToLower();
                bool.TryParse(resultado, out B);
                contador += 1;
            } while (resultado != "true" && resultado != "false");

            if (A == true)
            {
                Console.WriteLine("A é VERDADEIRO");
            }
            else
            {
                Console.WriteLine("A é FALSO");
            }
            if (B == true)
            {
                Console.WriteLine("B é VERDADEIRO");
            }
            else
            {
                Console.WriteLine("B é FALSO");
            }
            if (A == true && B == false || A == false && B == true)
            {
                Console.WriteLine("A é diferente de B");
            }
            else
            {
                Console.WriteLine("A é igual a B");
            }
            Console.ReadLine();
        }
    }
}
