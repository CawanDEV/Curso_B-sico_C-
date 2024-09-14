using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.PortableExecutable;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace HerançaDeClasses
{
    internal class Aviao : Veiculo
    {
        public int Passageiros { get; set; }
        public double Altitude { get; set; }
        public Aviao(double peso, double altura, double largura, double comprimento, int passageiros) : base(peso, altura, largura, comprimento)
        {
            this.Passageiros = passageiros;
            this.Altitude = 0;
            Console.WriteLine("Um objeto do tipo Aviao foi criado");
        }
        public void Voar (double distancia)
        {
            this.Decolar(1000);
            double percorrida = 0;
            while (percorrida < distancia)
            {
                Console.WriteLine($"Nosso aviao esta a {(distancia - percorrida):f2} metros de distancia do destino");
                percorrida += 220;
                Thread.Sleep(1000);
            }
            this.Pousar();
        }

        private void Pousar()
        {
            while (this.Altitude > 0)
            {
                Console.WriteLine($"Nosso aviao esta a {this.Altitude:f2} metros de altitude.");
                this.Altitude -= 60;
                this.Altitude = this.Altitude < 0 ? 0 : this.Altitude;
                Thread.Sleep(1000);
            }
            Console.WriteLine("Pouso Concluido");
            Thread.Sleep(1000);
        }

        private void Decolar(int altitude)
        {
            while (this.Altitude < altitude)
            {
                Console.WriteLine($"Nosso aviao esta a {this.Altitude:f2} metros de altitude");
                this.Altitude += 60;
                Thread.Sleep(1000);
            }
            Console.WriteLine("Decolagem Concluida");
            Thread.Sleep(1000);
        }
    }
}
