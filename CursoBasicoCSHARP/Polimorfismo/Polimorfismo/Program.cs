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
            Veiculo v2 = new Carro(1100, DateTime.Now.Date.AddDays(-600));
            Veiculo v3 = new Onibus(6000, DateTime.Now.Date.AddDays(-5800));

            v2.Abastecer(40);
            v3.Abastecer(120);

            v2.Mover(30);
            v3.Mover(100);

            v2.Frear();
            v3.Frear();

        }
    }
}
