using System;

namespace Curso_Básico_CSHARP_M2
{
    internal class Program
    {
        static Program()
        {
            Console.WriteLine("Programa Inicializado com suacesso");
        }
        static void CriarObjetos()
        {
            Carro c1 = new Carro();
            c1.Modelo = "Fusca";
            c1.Portas = 4;
            c1.Preco = 29990;

            Carro c2 = new Carro();
            c2.Modelo = "Opala";
            c2.Portas = 4;
            c2.Preco = 49990;

            Carro c3 = new Carro("Chevete");
            c3.Portas = 2;
            c3.Preco = 32990;

            Carro c4 = new Carro("Monza", 4, 43990);

            Carro c5 = new Carro(1190);
        }
        static void Main(string[] args)
        {
            CriarObjetos();   

            Console.WriteLine("Objetos já não são mais usados");

            GC.Collect();
        }
    }
}
