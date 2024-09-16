using System;

namespace MembrosClassesAbstratas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Carro c1 = new Carro(1200);
            Aviao a1 = new Aviao(3000);
            ViajarParaCalifornia(a1);
        }
        static void ViajarParaCalifornia(Veiculo v)
        {
            v.Mover(10000);
        }
    }
}
