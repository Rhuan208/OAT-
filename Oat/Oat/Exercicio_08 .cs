using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oat
{
    internal class Exercicio_08
    {
        public void Exercicio8()
        {
            {
                int num1, num2, num3;

                do
                {
                    Console.WriteLine("Digite o primeiro numero: ");
                    num1 = int.Parse(Console.ReadLine());

                    Console.WriteLine("Digite o segundo numero: ");
                    num2 = int.Parse(Console.ReadLine());

                    Console.WriteLine("Digite o terceiro numero: ");
                    num3 = int.Parse(Console.ReadLine());

                    if (num1 == num2 || num1 == num3 || num2 == num3)
                    {
                        Console.WriteLine("Números repetidos digite novamente");
                    }
                    else
                    {
                        break;
                    }
                } while (true);

                int maior, meio, menor;

                if (num1 > num2)
                {
                    if (num1 > num3)
                    {
                        maior = num1;
                        if (num2 > num3)
                        {
                            meio = num2;
                            menor = num3;
                        }
                        else
                        {
                            meio = num3;
                            menor = num2;
                        }
                    }
                    else
                    {
                        maior = num3;
                        meio = num1;
                        menor = num2;
                    }
                }
                else
                {
                    if (num2 > num3)
                    {
                        maior = num2;
                        if (num1 > num3)
                        {
                            meio = num1;
                            menor = num3;
                        }
                        else
                        {
                            meio = num3;
                            menor = num1;
                        }
                    }
                    else
                    {
                        maior = num3;
                        meio = num2;
                        menor = num1;
                    }
                }

                Console.WriteLine("Valores em ordem decrescente: " + maior + ", " + meio + ", " + menor);

                Console.ReadKey();
            }

        }
    }
}
    

