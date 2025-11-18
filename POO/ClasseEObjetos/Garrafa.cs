


namespace ClassesEObjetos
{
    public class Garrafa
    {
        
        public double Capacidade = 0;

        public string Marca = "";

        public string Modelo = "";

        public string Cor = "";



        public void Abrir()
        {
            Console.WriteLine("Clack - Abrindo");
        }

        public void Fechar()
        {
            Console.WriteLine("Click - Fechando");
        }

        public void Encher()
        {
            Console.WriteLine("Gloop Gloop - Enchendo");
        }
        
        public void Esvaziar()
        {
            System.Console.WriteLine("Glu Glu - Esvaziando");
        }

    }
}
