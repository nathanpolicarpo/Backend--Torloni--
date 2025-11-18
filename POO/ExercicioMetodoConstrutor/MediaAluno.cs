

namespace ExerciciosMetodoConstrutor
{
    public class MediaAluno
    {
        public string Nome = "";
        public double N1, N2, N3;

        //Construtor com parâmetros
        public MediaAluno(double PARAM1, double PARAM2, double PARAM3)
        {
            //Define os valores iniciais para as minhas propriedades
            //N! = 0; FIXO
            N1 = PARAM1; //Parametro param1 representa o valor do N1 - valor dinâmico
            N2 = PARAM2;
            N3 = PARAM3;
        }

        public MediaAluno()
        {
            N1 = N2 = N3 = 0; //Atribuindo um valor fixo para as 3 propriedades deuma vez
        }

        public void Media()
        {
            double Media = (N1 + N2 + N3) / 3;
            System.Console.WriteLine($"A média do(a) {Nome} foi de {Media} 🏫🤔");
        }

    

    }
}