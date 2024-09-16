using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MembrosClassesAbstratas
{
    internal class Carro : Veiculo
    {
        public Carro(double peso) : base(peso)
        {
            Console.WriteLine("Um novo ojeto carro foi criado");
        }
        public override void Mover(double distancia)
        {
            Console.WriteLine($"Um Objeto carro se moveu por {distancia} KMS.");
        }
    }
}
