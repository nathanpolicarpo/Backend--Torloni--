


using System.Dynamic;

namespace Exe3rcicio01
{
    public class Retangulo : IForma
    {

        public float Largura;
        public float Altura;


        public void CalcularArea()
        {
           System.Console.WriteLine($"A área do retângulo é: {Largura * Altura}");
        }
    }
}
