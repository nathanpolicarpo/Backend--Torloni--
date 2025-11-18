

namespace TheBasics
{
    public class Moto : Veiculo
    {
        public void Empinar()
        {
            System.Console.WriteLine("Empinando a moto - who who who...");
        }
        

        public void ExibirMoto()
        {
            System.Console.WriteLine(@$"Marca: {Marca} / Modelo: {Modelo} / Quantidade de Rodas: {qtdRodas} ");
            System.Console.WriteLine();
        }
    }
}