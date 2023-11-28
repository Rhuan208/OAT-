using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oat
{
    public class Exercicio_02
    {
        public void Exercicio2()
        {
            Console.WriteLine("Digite o seu nome: ");
            string nome = Console.ReadLine();
            Console.WriteLine("Qual o seu Sexo: ");
            string sexo = Console.ReadLine();
            Console.WriteLine("Você é Casada(o) ou Solteira(o): ");
            string estadoCivil = Console.ReadLine();

            if (sexo == "Feminino" && estadoCivil == "Casada") ;
            {
                Console.WriteLine("Quantos anos você tem de Casada? ");
                int anos = int.Parse(Console.ReadLine());
                Console.WriteLine("Você e casada a " + anos + " anos!");
            }
            Console.ReadLine();
        }
    }
}
