using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Herança
{
    public class Gato : Animal
    {
        public override void FazerSom()
        {
            Console.WriteLine($"Miau, Miau!!");
            
        }
    }
}