using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Encapsulamento
{
    public class ContaBancaria
    {
        private float saldo;

public ContaBancaria()
        {
            saldo = 0;
        }

        public ContaBancaria(float saldoInicial)
        {
            if (saldoInicial <=0)
            {
                saldoInicial = 0;
            }
            else
            {
                saldo = saldoInicial;
            }
            
        }

        public void Depositar(float valor)
        {
            if (valor >=0)
            {
                saldo += valor;
                return;
            }

            Console.WriteLine($"Valor para deposito invalido!");
        }

        public void sacar(float valor)
        {
            if (valor > saldo || valor < 0)
            {
                Console.WriteLine($"Saldo insuficiente para saque ou valor invalido para saque!");
                return;
            }
            saldo -= valor;
        }

// Metodo publico que retorna o saldo
        public float GetSaldo()
        {
            return saldo;
        }
    }
}