

namespace ClassesEObjetos
{
    public class Produto
    {
        // Atributos
        public string nome = "";
        public double preco;

        // Método para aplicar desconto
        public void AplicarDesconto(double percentual)
        {
            double desconto = preco * (percentual / 100);
            preco -= desconto;

            Console.WriteLine($"Desconto de {percentual}% aplicado com sucesso!");
            Console.WriteLine($"Valor do desconto: R${desconto:F2}");
            Console.WriteLine($"Novo preço do produto: R${preco:F2}");
            Console.WriteLine();
        }
    }
}
