using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MembrosClassesAbstratas
{
    internal sealed class Aviao : Veiculo
    {
        public Aviao(double peso) : base(peso)
        {
            Console.WriteLine("Um objeto Aviao foi criado.");
        }

        public override void Mover(double distancia)
        {
            Console.WriteLine($"Um Objeto aviao se moveu por {distancia} KMS.");
        }
    }
}
