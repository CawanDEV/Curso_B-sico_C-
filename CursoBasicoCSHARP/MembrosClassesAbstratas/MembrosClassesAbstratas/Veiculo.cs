using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MembrosClassesAbstratas
{
    public abstract class Veiculo
    {
        public double Peso { get; set; }
        public Veiculo(double peso)
        {
            this.Peso = peso;
            Console.WriteLine("Um novo objeto foi criado");
        }
        ~Veiculo() 
        {
            Console.WriteLine("Um objeto veiculo foi destruido");
        }

        public abstract void Mover(double distancia);
    }
}
