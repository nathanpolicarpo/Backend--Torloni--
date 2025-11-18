

namespace Exercicio04
{
    public class Aluno : Pessoa
    {
        public string Curso = "";

        public void MostrarAluno()
        {
            System.Console.WriteLine($"Nome: {Nome} / Idade: {idade} / Curso: {Curso}");
        }

    }

    
}