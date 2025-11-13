using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ClassesEObjetos
{
    public class Pessoa
    {
        public string Nome = "";
        public int Idade;
        public void Falar()
        {
            Console.WriteLine($"Ola, meu nome e {Nome}");
        }

        public void Envelhecer(int _anos)
        {
            Idade += _anos; 
        }
    }
}