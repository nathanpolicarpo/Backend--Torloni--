

namespace Exercicio04
{
    public class Professor : Pessoa
    {
        public string Disciplina = "";

        public void MostrarProfessor()
        {
            System.Console.WriteLine($"Nome: {Nome} / Idade: {idade} / Disciplina: {Disciplina}");
        }

    }
}