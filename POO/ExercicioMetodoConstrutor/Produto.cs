

namespace ExerciciosMetodoConstrutor
{
    public class Produto
    {
        public string Nome = "";
        public double Preco;
        public int Estoque;

        public Produto(string no, double pre, int es)
        {
            Nome = no;
            Preco = pre;
            Estoque = es;
        }

        public void MostrarDados()
    {
        Console.WriteLine("-------- Dados do Produto --------");
        Console.WriteLine($"Nome: {Nome}");
        Console.WriteLine($"Preço: R$ {Preco}");
        Console.WriteLine($"Estoque: {Estoque} unidades");
    }

    }
}