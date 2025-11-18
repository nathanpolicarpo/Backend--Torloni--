using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Exercicio2
{
    public class Fatura : IImprimivel
    {
        public String Devedor = "";
        public String Credor = "";
        public float Valor = 0;
        public int DiasDeAtraso = 0;
        private float Juros = 0.10f;

        public Fatura(string dev, string cred, float valFat, int qtdAtraso)
        {
            Devedor = dev;
            Credor = cred;
            Valor = valFat;
            DiasDeAtraso = qtdAtraso;
        }

        public void Imprimir()
        {
            CalcularValorDivida();
            Console.WriteLine($"Credor: {Credor}");
            Console.WriteLine($"Devedor: {Devedor}");
            Console.WriteLine($"Dias de atraso: {DiasDeAtraso} dia(s)");
            Console.WriteLine($"Júros: R${Juros * DiasDeAtraso}");
            Console.WriteLine($"Total Com Júros: R${Valor}");
            Console.WriteLine($"---------------------------------");

        }
        public void CalcularValorDivida()
        {
            if (DiasDeAtraso > 0)
            {
                Valor = Valor + DiasDeAtraso * Juros;
            }
            if (DiasDeAtraso >= 5)
            {
                Console.WriteLine($"Dívida encaminhada para o SERASA");
            }
        }
    }
}