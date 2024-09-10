using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.PortableExecutable;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace MetodosSobrecarregados
{
    enum CorVeiculo
    {
        Branco,
        Preto,
        Vermelho,
        Prata,
        Grafite
    }
    internal class Veiculo
    {
        public string Modelo { get; set; }
        public int Peso { get; set; }
        public double Velocidade { get; set; }
        public int Portas { get; set; }
        public CorVeiculo Cor { get; set; }

        public Veiculo(string modelo)
        {
            this.Modelo = modelo;
        }
        public Veiculo(string modelo, CorVeiculo cor) : this(modelo)
        {
            this.Cor = cor;
        }
        public Veiculo(string modelo, CorVeiculo cor, int portas = 4) : this(modelo, cor)
        {
            this.Portas = portas;
        }
        public void MostrarDados()
        {
            Console.WriteLine($"Veiculo {this.Modelo} :: Cor {this.Cor} :: {this.Portas} Portas");
        }
        public void MostrarDados(int nroLinha)
        {
            Console.WriteLine($"{nroLinha}. Veiculo {this.Modelo} :: Cor {this.Cor} :: {this.Portas} Portas");
        }
        public void Acelerar()
        {
            this.Velocidade += 10;
        }
        public void Acelerar (int acrescimoPorSegundo, double tempoS)
        {
            DateTime inicio = DateTime.Now;
            DateTime fim = inicio.AddSeconds(tempoS);
            while (inicio < fim)
            {
                this.Velocidade += acrescimoPorSegundo;
                Thread.Sleep(1000);
            }
        }
    }
}
