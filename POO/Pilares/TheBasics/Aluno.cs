


namespace TheBasics
{
    public class Aluno : Pessoa
    {//Cria um construtor na classe Aluno que recebe o endereço
     //Chama o construtor da classe mãe (Base) e repassa o endereço para ela
        public Aluno(Endereco endereco) : base(endereco)
        {
        }

        public string RA;
        public float NotaFinal;
        public string Curso;
    }
}
