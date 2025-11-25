
namespace Exe3rcicio01
{
    public class Circulo : IForma
    {
        public float Raio;
        private float PI = 3.14f;

        public void CalcularArea()
        {
            System.Console.WriteLine($"A área do circulo é: {PI * Raio * Raio}");
        }
    }
}