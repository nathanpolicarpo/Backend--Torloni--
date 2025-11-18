


namespace Exercicio02
{
    public class Funcionario
    {
        public string Nome = "";
        public double SalarioBase;

        public virtual double CalcularSalario()
        {
            return SalarioBase;
        }
        
        public void ExibirFuncionario()
        {
            System.Console.WriteLine($"Nome: {Nome}, Salário: R${SalarioBase}");
        }
    }
}
