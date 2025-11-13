
namespace MetodoConstrutor
{
    public class Pessoa3Sobrecargas
    {
        public string Nome = "";
        public int Idade = 0;

        public Pessoa3Sobrecargas()
        {
            Nome = "Desconhecido";
            Idade = 0;
        }


        public Pessoa3Sobrecargas(string n)
        {
            Nome = n;
            Idade = 0;
        }

        public Pessoa3Sobrecargas(string n, int i)
        {
            Console.WriteLine($"Digite o nome da primeira pessoa:");
            n = Console.ReadLine();
            Console.WriteLine($"Digite a idade da primeira pessoa:");
            i = int.Parse(Console.ReadLine());
            Nome = n;
            Idade = i;
        }

        public void ExibirDados()
        {
            Console.WriteLine($"Nome: {Nome}, Idade: {Idade}");
        }
    }
}
