﻿using System;

namespace CursoBasicoCSHARP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n1 = 3;
            double n2 = 3.4;
            string s1 = "Cawan Davi";
            char c1 = '@';
            Console.WriteLine($"{n1} + {n2} + {s1} + {c1}");
            double n3 = n1 + n2;
            Console.WriteLine($"O Valor da Soma é {n3:f4}.");
            n3 += 5;
            Console.WriteLine($"O Valor da Soma é {n3:f4}.");
            bool ehPar = (n1 % 2 == 0);
            if (!ehPar == true)
            {
                Console.WriteLine("O Número é impar");
            }
            else
            {
                Console.WriteLine("O Número é par");
            }
            switch (n1)
            {
                case 1:
                    Console.WriteLine("O valor é 1");
                    break;

                case 2:
                    Console.WriteLine("O valor é 2");
                    break;

                case 3:
                    Console.WriteLine("O valor 3");
                    break;

                case 4:
                    Console.WriteLine("O valor é 4");
                    break;

                default:
                    Console.WriteLine("O valor não está entre 1 e 4.");
                    break;
            }
            int i = 0;
            while (i < 10)
            {
                Console.WriteLine($"Iteração {i}.");
                
                if (i == 5)
                {
                    break;
                }
                i++;
            }
            Console.WriteLine("Estrutura Finalizada");


            for (int j=0; j < 10; j++)
            {

                if (j == 5)
                {
                    continue;
                }
                Console.WriteLine($"Iteração {j}");
            }
            Console.WriteLine("Estrutura Finalizada");

            i = 10;
            do
            {
                i--;
                if (i == 5)
                {
                    break;
                }
                Console.WriteLine($"Iteração {i}");
               
            } while (i > 0);
        }

    }
}
