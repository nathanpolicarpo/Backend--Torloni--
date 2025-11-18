


namespace Exercicio02
{
    public class Gerente : Funcionario
    {
        public double Bonus;

        public override double CalcularSalario()
        {
            return SalarioBase + Bonus;
        }

        public void ExibirGerente()
        {
            System.Console.WriteLine($"Nome: {Nome}, Salário: R${SalarioBase}, Bonus: R${Bonus}, Reajuste com Bonus: R${SalarioBase + Bonus}");
        }
    }

    }
