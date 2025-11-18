

namespace MetodoConstrutor
{
    public class Pessoa
    {
        public string Nome = "";
        public int Idade;


        //Método Construtor de Pessoa, possui parametros
        //Parametros representam valores para suas respqctivas props
        //Estamos inicializando valores para os props nome e idade

        public Pessoa(string n, int i)
        {
            Nome = n; //inicializa com valor n
            Idade = i; //inicializa com valor i
        }
        
        public void ExibirDados()
        {
            Console.WriteLine($"Nome: {Nome}, Idade: {Idade}");
        }
        
    }
}