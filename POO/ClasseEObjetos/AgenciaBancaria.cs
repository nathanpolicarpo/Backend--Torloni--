


using System.Security.Cryptography.X509Certificates;

namespace ClassesEObjetos
{
    public class  AgenciaBancaria
    {
        public string Titular = "";
        public double Saldo;

        public AgenciaBancaria(string titular, double saldoInicial = 0)
        {
            Titular = titular;
            Saldo = saldoInicial;
        }

        public void Depositar(double valor)
        {
            if (valor > 0)
            {
                Saldo += valor;
                Console.WriteLine($"Depósito de valor: {valor} Realizada com Sucesso!!!");
            }

            else
            {
                System.Console.WriteLine("Valor inválido, não será possível fazer o Depósito...");
            }


        }
        
        public void Sacar(double valor)
        {
            if (valor > 0 && valor <= Saldo)
            {
                Saldo -= valor;
                Console.WriteLine($"Saque de R$ {valor} Realizado com sucesso!!!");
            }

            else
            {
                Console.WriteLine("Valor insuficiente para saque...");
            }

        }

    }
}
