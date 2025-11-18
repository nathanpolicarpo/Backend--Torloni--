
// Classe base (pai)
public abstract class Pessoa
{
    public string Nome = "";
    public int Idade;

    public void Falar()
    {
        Console.WriteLine("Olá, eu sou uma pessoa!");
    }
}

// Classe derivada (filha) herda de Pessoa
public class Aluno : Pessoa
{
    public string Curso = "Desenvolvimento de Sistemas";

    public void Estudar()
    {
        Console.WriteLine("Estou estudando!");
    }
}
