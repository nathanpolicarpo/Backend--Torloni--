

namespace PrimeiraClasse
{
    public class Carro
    {
        public int qtdRodas;
        public int qtdPortas;
        public string marca;
        public string modelo;
        public string cor;

        public void Acelerar()
        {
            Console.WriteLine($"Carro Acelerando");
        }

        public void Frear()
        {
            Console.WriteLine($"Carro Freando");
        }

        public void Ligar()
        {
            Console.WriteLine($"Carro Ligando");
        }
        public void Desligar()
        {
            Console.WriteLine($"Carro desligando");
        }
    }
}