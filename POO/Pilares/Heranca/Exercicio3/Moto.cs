


namespace Exercicio03
{
    public class Moto : Veiculo
    {
        public string ModeloCapacete = "";

        public override void MostrarInfo()
        {
            System.Console.WriteLine($"Marca: {Marca} / Modelo: {Modelo} / Modelo do Capacete: {ModeloCapacete}");
        }
    }
}
