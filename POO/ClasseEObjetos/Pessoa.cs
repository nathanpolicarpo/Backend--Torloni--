namespace ClassesEObjetos
{
    public class Pessoa
    {
        public string Nome = "";
        public int Idade = 0;

        public void Falar()
        {
        Console.WriteLine($"Olá meu nome é {Nome}");
        }

        public int Envelhecer(int _anos)
        {
            if (_anos <= 0)
            {
                Console.WriteLine($"Idade tem que ser positiva!");
                return -1;//para o código aqui não lê abaixo
            }

            Idade += _anos;//atualiza a idade

            return Idade;// retorna a idade atualizada
        }
    }// fim da class
}//fim do namespace