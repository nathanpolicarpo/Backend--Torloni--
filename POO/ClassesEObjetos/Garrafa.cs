using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ClassesEObjetos
{
    public class Garrafa
    {
        
        public string marca = "";

        public string modelo = "";

        public int capacidade = 0;

        public string cor = "";

        //Métodos
        public void Abrir()
        {
            Console.WriteLine($"Garrafa abrindo");
        }
        public void Encher()
        {
            Console.WriteLine($"Garrafa enchendo");
        }

        public void Esvaziar()
        {
            Console.WriteLine($"Garrafa Esvaziando");
        }

        public void Fechar()
        {
            Console.WriteLine($"Garrafa fechando");
        }
    }
}