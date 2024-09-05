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

            Product p1 = new Product();
            p1.Nome = "Banana";
            p1.Preco = 3.9;
            p1.Comprar(20);
            p1.Vender(13);
            Console.WriteLine(p1.ObterTexto());


            Product p2 = new Product();
            p2.Nome = "Maca";
            p2.Preco = 2.99;
            p2.Comprar(100);
            p2.Vender(29);
            Console.WriteLine(p2.ObterTexto());



            Product p3 = new Product("Laranaja", 4.99);
            p3.Comprar(120);
            p3.Vender(98);
            Console.WriteLine(p3.ObterTexto());
            

        }
    }
}
