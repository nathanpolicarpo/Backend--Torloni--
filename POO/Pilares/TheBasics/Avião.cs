

namespace TheBasics
{
    public class Aviao : Veiculo
    {
        public double qtdTurbina;
        public double qtdAcentos;
        public string companhia = "";


        public void Decolar()
        {
            System.Console.WriteLine("Avião decolando - xiiiuuuuuu");
        }

        public void ExibirAviao()
        {
        System.Console.WriteLine(@$"Marca: {Marca} / Modelo: {Modelo} / Quantidade de Rodas: {qtdRodas} / qtdAcentos: {qtdAcentos} / qtdTurbinas: {qtdTurbina} / Companhia: {companhia}");

        }
    }
}
