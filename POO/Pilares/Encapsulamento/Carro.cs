using System.Runtime.InteropServices;
// Exercício Desafio:

// Crie um programa em C# para representar um carro usando o conceito de encapsulamento, porém sem utilizar propriedades com get e set. Utilize somente atributos privados e métodos públicos para acessar e modificar os dados. Siga as instruções:

// Crie uma classe chamada Carro.

// Dentro da classe, crie três atributos privados:

// marca (string)

// modelo (string)

// velocidadeAtual (int)

// Crie métodos públicos para definir e obter a marca:

// DefinirMarca(string valor)

// ObterMarca()

// Crie métodos públicos para definir e obter o modelo:

// DefinirModelo(string valor)

// ObterModelo()

// Crie um método público para obter a velocidade atual:

// ObterVelocidade()

// Crie dois métodos públicos que alterem a velocidade do carro:

// Acelerar(int valor): aumenta a velocidade.

// Frear(int valor): diminui a velocidade, mas nunca pode ficar abaixo de zero.

// No método Main, crie um objeto da classe Carro, defina sua marca e modelo usando os métodos criados, acelere e freie algumas vezes.
// Após as operações, mostre na tela a marca, o modelo e a velocidade atual do carro usando os métodos de leitura.

namespace Encapsulamento
{
    public class Carros
    {
        private string modelo = "";
        private string marca = "";
        private int VelocidadeAtual;

        public void DefinirMarca(string M)
        {
            marca = M;
        }

        public string ObterMarca()
        {
            return marca;
        }

        public void DefinirModelo(string Mo)
        {
            modelo = Mo;
        }

        public string ObterModelo()
        {
            return modelo;
        }

        public void Acelerar(int quantidade)
        {
            VelocidadeAtual += quantidade;
        }

        public int ObterVelocidade()
        {
            return VelocidadeAtual;
        }
        public void Frear(int quantidade)
        {
            VelocidadeAtual -= quantidade;
            if (VelocidadeAtual < 0)
            {
                VelocidadeAtual = 0;
            }
        }


    }
}