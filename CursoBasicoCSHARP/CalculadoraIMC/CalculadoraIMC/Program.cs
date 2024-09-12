using System;

namespace CalculadoraIMC
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Calculadora calc = new Calculadora();
            Console.WriteLine("Bem Vindo a Calculadora de IMC");
            Console.WriteLine("Escreva Seu Peso:");
            calc.Peso = double.Parse(Console.ReadLine());

            Console.WriteLine("Escreva Sua Altura: ");
            calc.Altura = double.Parse(Console.ReadLine());

            calc.exibirInformacoes();
        }
    }
}
