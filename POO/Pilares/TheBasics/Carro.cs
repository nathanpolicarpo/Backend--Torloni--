

namespace TheBasics
{
    public class Carro : Veiculo
    {
        public void AbrirPortaMala()
        {
            System.Console.WriteLine("Porta-Malas aberto");
        }

        public void ExibirDadosCarro()
        {
            System.Console.WriteLine(@$"Marca: {Marca} / Modelo: {Modelo} / Quantidade de Rodas: {qtdRodas} ");
            System.Console.WriteLine();
        }
    }
}