using System;

namespace EstudoDeCasoPessoa
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Pessoa p1 = new Pessoa("Albert", "Einstein", new DateTime(1955, 6, 17), "98765432345");
            p1.Peso = 76;
            p1.Altura = 1.76;
            p1.MostrarDados();
            p1.Comer(2.5);
            p1.Comer(3800);
            p1.Correr(7, 30);
            p1.MostrarDados();

            Console.WriteLine();

            Pessoa p2 = new Pessoa("Ada", "LoveLace", new DateTime(1975, 4, 18), "12345678910", 62, 1.65);
            p2.MostrarDados();
        }
    }
}
