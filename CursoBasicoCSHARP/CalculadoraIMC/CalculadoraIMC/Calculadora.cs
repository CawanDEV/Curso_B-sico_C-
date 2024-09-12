using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculadoraIMC
{
    internal class Calculadora
    {
        public double Altura { get; set; }
        public double Peso { get; set; }
        public double IMC
        {
            get 
            {
                return (Peso / (Altura * Altura));
            }
        }

        public void exibirInformacoes()
        {
            Console.WriteLine($"Seu IMC é de: {IMC:f2}");
        }
    }
}
