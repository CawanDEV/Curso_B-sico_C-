using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Curso_Básico_CSHARP_M2
{
    internal class Carro : Veiculo
    {
        public int Portas { get; set; }

        public double Preco { get; set; }

        public string Modelo { get; set; }

        public Carro()
        {
            Console.WriteLine("Um Novo Objeto Carro Foi Criado.");
        }

        public Carro (int pesoKg) : base(pesoKg)
        {
            Console.WriteLine($"Um novo objeto do tipo carro com peso {pesoKg} foi criado");
        }
        public Carro(string modelo) : this() 
        {
            this.Modelo = modelo;
        }

        public Carro(string modelo, int portas, double preco) : this(modelo)
        {
            this.Portas = portas;
            this.Preco = preco;
        }

        ~Carro()
        {
            Console.WriteLine("Um Objeto do tipo carro foi destruido.");
        }
    }
}
