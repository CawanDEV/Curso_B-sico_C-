using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polimorfismo
{
    public abstract class Veiculo
    {
        public int PesoKg { get; set; }
        public DateTime DataFabricacao { get; set; }
        public double QuantidadeCombustivel { get; set; }
        public string Tipo {  get { return this.GetType().Name; } }
        public abstract int Capacidade {  get; set; }
        public abstract void Abastecer(double quantidadeLitros);
        public abstract void Mover(double distanciKm);
        public virtual void Frear()
        {
            Console.WriteLine("Acionando os freios... Parou.");
        }

        public Veiculo (int pesoKg, DateTime dataFabricacao)
        {
            PesoKg = pesoKg;
            DataFabricacao = dataFabricacao;
        }
    }
}
