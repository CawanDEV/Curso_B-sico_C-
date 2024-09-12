using System;
using System.Globalization;

namespace HerançaDeClasses
{
    internal class Veiculo
    {
        public double Peso { get; set; }
        public double Altura { get; set; }
        public double Largura { get; set; }
        public double Comprimento { get; set; }
        protected double Densidade 
        {
            get
            {
                return this.Peso / (this.Altura * this.Largura * this.Comprimento);
            }
        }

        public Veiculo(double peso, double altura, double largura, double comprimento)
        {
            this.Peso = peso;
            this.Altura = altura;   
            this.Largura = largura;
            this.Comprimento = comprimento;
            Console.WriteLine("Um objeto do tipo veiculo foi criado");
        }
        ~Veiculo()
        {
            Console.WriteLine("Um objeto do tipo veiculo foi destruido");
        }
    }
}