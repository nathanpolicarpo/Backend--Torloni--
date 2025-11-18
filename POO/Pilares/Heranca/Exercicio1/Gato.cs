
namespace Exercicio01
{
    public class Gato : Animal
    {
        public override void FazerSom()
        {
            System.Console.WriteLine("Miau Miau Miau");
        }

        public void ExibirGato()
        {
            System.Console.WriteLine($"O animal é um: {TipoAnimal}");
        }
    }
}
