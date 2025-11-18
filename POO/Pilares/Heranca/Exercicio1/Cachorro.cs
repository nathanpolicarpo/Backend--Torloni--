

namespace Exercicio01
{
    public class Cachorro : Animal
    {
        public override void FazerSom()
        {
            System.Console.WriteLine("Au Au Au Au");
        }

        public void ExibirCachorro()
        {
            System.Console.WriteLine($"O animal é um: {TipoAnimal}");
        }
    }
}