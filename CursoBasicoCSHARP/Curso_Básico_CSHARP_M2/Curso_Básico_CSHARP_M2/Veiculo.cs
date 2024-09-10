using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Curso_Básico_CSHARP_M2
{
    internal class Veiculo
    {
        public int PesoKg { get; set; }

        public Veiculo() 
        {
            Console.WriteLine("Um Objeto do tipo veiculo foi criado");
        }

        public Veiculo (int pesoKg) : this() 
        {
            this.PesoKg = pesoKg;
        }

        ~Veiculo()
        {
            Console.WriteLine("Um objeto do tipo veiculo foi destruido");
        }
    }
}
