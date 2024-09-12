using System;
using System.Security.Cryptography;

namespace HerançaDeClasses
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Aviao a1 = new Aviao(3200, 4, 16, 12, 12);
            a1.Voar(1000);
        }
    }
}
