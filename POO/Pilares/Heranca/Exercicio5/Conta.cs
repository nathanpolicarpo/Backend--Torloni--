

using System.Diagnostics.Contracts;

namespace Exercicio05
{
    public class Conta
    {
        public double Numero;
        public double Saldo;

        public void Depositar(double valor)
        {
            Saldo += valor;
        }



        public void Sacar(double valor)
        {
            if (valor <= Saldo)
            {
                Saldo -= valor;
            }

            else
            {
                System.Console.WriteLine("Saldo Insuficiente");
            }
        }
    }
}