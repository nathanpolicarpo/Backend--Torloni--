

namespace TheBasics
{
    public class Veiculo
    {
        
            public string Marca;
            public string Modelo;
            public void Ligar()
            {
                System.Console.WriteLine($"Ligando Veiculo");
            }
            public void Desligar()
            {
                System.Console.WriteLine($"Veiculo Desligado");
            } 
    }
}