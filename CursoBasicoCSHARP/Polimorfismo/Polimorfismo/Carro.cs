using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polimorfismo
{
    public class Carro : Veiculo
    {
        private int capacidade;
        public override int Capacidade
        {
            get
            {
                return capacidade;
            }
            set
            {
                if ((value >= 2) && (value <=7))
                {
                    capacidade = value;
                }
                else
                {
                    throw new ArgumentException("O Carro pode ter capacidade de 2 a 7 pessoas");
                }
            }
        }
        public int PotenciaCv { get; set; }
        public override void Abastecer(double quantidadeLitros)
        {
            QuantidadeCombustivel += quantidadeLitros;
            Console.WriteLine($"Carro foi abastecido com {quantidadeLitros} litros de gasolina.");
        }
        public override void Mover(double distanciKm)
        {
            if(QuantidadeCombustivel > (distanciKm / 10))
            {
                QuantidadeCombustivel -= (distanciKm / 10);
                Console.WriteLine($"O carro se moveu por {distanciKm} kilometros.");
            }
            else
            {
                Console.WriteLine("Não ha combustivel para percorrer a distancia informada");
            }
        }
        public override void Frear()
        {
            Console.WriteLine("Acionando os Freios ABS... Parou");
        }
        public Carro(int pesoKg, DateTime dataFabricacao, int capacidade = 5) : base(pesoKg, dataFabricacao)
        {
            Capacidade = capacidade;
        }
    }
}
