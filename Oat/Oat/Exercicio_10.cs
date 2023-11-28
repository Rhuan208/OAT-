using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oat
{
    internal class Exercicio_10
    {
        public void Exercicio10()
        {
            Console.WriteLine("Qual seu peso");
            double peso = double.Parse(Console.ReadLine());
            Console.WriteLine("Qual sua altura: ");
            double altura = double.Parse(Console.ReadLine());

            double imc = peso / (altura * altura);
            if (imc < 18.5)
            {
                Console.WriteLine("Seu IMC é de " + imc + " você está abaixo do peso!");
            }
            else if (imc <= 25)
            {
                Console.WriteLine("Seu IMC é de " + imc + " você está com o peso normal");
            }
            else if (imc <= 30)
            {
                Console.WriteLine("Seu IMC é de " + imc + " você está obeso!");
            }
            Console.ReadLine();
        }
    }
}
