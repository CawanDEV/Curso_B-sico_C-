using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoBasicoCSHARP
{
    public class Pessoa
    {
        public string Nome;
        public int Idade;
        public char Genero;
        private bool Aprovado;
         
        public void MostrarDados()
        {
            Console.WriteLine($"Nome : {Nome}");
            Console.WriteLine($"Idade : {Idade} anos");
            Console.WriteLine($"Genero : {Genero}");
            Console.WriteLine($"Aprovado : {Aprovado}");
        }
    }
}
