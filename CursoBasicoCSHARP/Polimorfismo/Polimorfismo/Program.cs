using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;

namespace Polimorfismo
{
    internal class Program
    {
        static List<Veiculo> veiculos = new List<Veiculo>();
        static Random random = new Random();
        static void Main(string[] args)
        {
            //Não é possivel instanciar a classe Veiculo, pois é abstrata
            //Veiculo v1 = new Veiculo(1000, new DateTime(25, 10, 2000))
            //Veiculo v2 = new Carro(1100, DateTime.Now.Date.AddDays(-600));
            //Veiculo v3 = new Onibus(6000, DateTime.Now.Date.AddDays(-5800));

            //v2.Abastecer(40);
            //v3.Abastecer(120);

            //v2.Mover(30);
            //v3.Mover(100);

            //v2.Frear();
            //v3.Frear();

            CriarVeiculosAleatorios();

            foreach (var v in veiculos)
            {
                Console.WriteLine("------------------------");
                Console.WriteLine(v.Tipo);
                v.Abastecer(random.Next(10, 60));
                v.Mover(random.Next(10, 200));
                v.Frear();
                Console.WriteLine("------------------------");
            }
            static void CriarVeiculosAleatorios()
            {
                for(int i = 0; i < 10; i++)
                {
                    if(random.Next() % 2 == 0)
                    {
                        veiculos.Add(new Carro(random.Next(800, 1400), DateTime.Now.Date.AddDays(-random.Next(30, 3600))));
                    }
                    else
                    {
                        veiculos.Add(new Onibus(random.Next(3000, 12000), DateTime.Now.Date.AddDays(random.Next(30, 3600))));
                    }
                }
            }
        }
    }
}
