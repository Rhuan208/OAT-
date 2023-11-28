using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oat
{
    internal class Exercicio_12
    {
        public void Exercicio12()
        {
            double media = 0;
            Console.WriteLine("Primeira nota do aluno: ");
            double nota1 = double.Parse(Console.ReadLine());
            Console.WriteLine("--------------------------");
            Console.WriteLine("Segunda nota do aluno: ");
            double nota2 = double.Parse(Console.ReadLine());
            Console.WriteLine("--------------------------");
            Console.WriteLine("Terceira nota do aluno: ");
            double nota3 = double.Parse(Console.ReadLine());
            Console.WriteLine("--------------------------");
            Console.WriteLine("Qual a média dos Exercicios: ");
            double exercicios = double.Parse(Console.ReadLine());

            Console.WriteLine("--------------------------");

            media = (nota1 + nota2 * 2 + nota3 * 3 + exercicios) / 7;
            Console.WriteLine("O aproveitamento do aluno foi de: " + media);
            Console.WriteLine("--------------------------");

            if (media >= 7.5)
            {
                Console.WriteLine("APROVADO");
            }
            else
            {
                Console.WriteLine("REPROVADO");
            }
            Console.WriteLine("--------------------------");

            Console.ReadLine();

        }
    }
}
        
    

