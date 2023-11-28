using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oat
{
    public class Exercicio_01
    {
       public void Exercicio1()
        { 

            Console.WriteLine("Informe o valor de A: ");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Informe o valor de B: ");
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine("Informe o valor de C: ");
            int c = int.Parse(Console.ReadLine());

           if (a + b < c)
            {
                Console.WriteLine("A soma de A + B é menor que C");
            }
           else
            {
                Console.WriteLine("A soma de A + B não é menor que c.");
            }
            
        }
    }
}