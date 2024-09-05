using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoBasicoCSHARP
{
    internal class Class1
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Classes, Objetos e Escopos de Visibilidade");

            Product p1 = new Product("Maça", 6.2);
            Product p2 = new Product("Banana", 2.5);
            Product p3 = new Product("Laranja", 3.9);
            Product p4 = new Product("Pêra", 5.75);
            Product p5 = new Product("Abacaxi", 3.33);
            Product p6 = new Product

            List<Product> produtos = new List<Product>();
            produtos.Add(p1);
            produtos.Add(p2);
            produtos.Add(p3);
            produtos.Add(p4);
            produtos.Add(p5);

            foreach (Product p in produtos)
            {
                p.Comprar(100);
                Console.WriteLine(p.ObterTexto());
            }
        }
    }
}
