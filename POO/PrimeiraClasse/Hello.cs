

namespace PrimeiraClasse
{
    public class Hello
    {

        public string TextoHello = "";

        public void SaldarUsuario()
        {
            Console.WriteLine(this.TextoHello);
        }
        public void SaldarComNome(string n)
        {
            Console.WriteLine($"ola {n}");
        }
    }
}