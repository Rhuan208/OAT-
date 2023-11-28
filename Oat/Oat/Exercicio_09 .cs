using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oat
{
    internal class Exercicio_09
    {
        public void Exercicio9()
        {
            {

                Console.WriteLine("Altura: ");
                double altura = double.Parse(Console.ReadLine());
                Console.WriteLine("Digite seu sexo se é masculino ou feminino: ");
                string sexo = Console.ReadLine();

                if (sexo == "masculino")
                {
                    double pesoIdeal = (72.7 * altura) - 58;
                    Console.WriteLine("Seu sexo é masculino e o seu peso ideal é: " + pesoIdeal);
                }
                else
                {
                    double pesoIdeal = (62.1 * altura) - 44.7;
                    Console.WriteLine("Seu sexo é feminino e o seu peso ideal é: " + pesoIdeal);
                }
                Console.ReadLine();

            }
        }
    }
}
    

