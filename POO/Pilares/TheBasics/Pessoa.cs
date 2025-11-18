
//namespace pode ser considerado como a pasta do projeto
//namespace é o modulo do sistema
//namespace é como um pacote,
namespace TheBasics
{
    public class Pessoa 
    {
        public string Nome = "";
        public int Idade;
        public Endereco EnderecoCompleto;

        
        public Pessoa(Endereco endereco){
            EnderecoCompleto = endereco;
        }
    


        public void Falar()
        {
            System.Console.WriteLine($"Olá, eu sou o {Nome} e tenho {Idade} anos");
        }


        public void Evelhecer()
        {
            Idade++;
        }

    }
}