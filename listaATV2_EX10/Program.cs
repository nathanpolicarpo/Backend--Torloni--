﻿/*
Baseado no programa do exercício número 9, crie um programa que contenha o menu para os exercícios de 1 a 6,
 onde cada programa/menu deve executar uma função.
*/


int opcao;

do
{
    Console.WriteLine("-------------------------------------------------------");
    Console.WriteLine("                Menu Exercícios (1 a 6)                ");
    Console.WriteLine("-------------------------------------------------------");

    Console.WriteLine("Exercicios para realizar:");
    Console.WriteLine("1");
    Console.WriteLine("2");
    Console.WriteLine("3");
    Console.WriteLine("4");
    Console.WriteLine("5");
    Console.WriteLine("6");
    Console.WriteLine("0 (Sair)");
    Console.WriteLine("");
    Console.WriteLine("Digite o exercicio que deseja realizar:");

    if (!int.TryParse(Console.ReadLine(), out opcao))
    {
        Console.WriteLine("Numero invalido");
        continue;
    }

    switch (opcao)
    {
        case 1:
            Exercicio1();
            break;
        case 2:
            Exercicio2();
            break;
        case 3:
            Exercicio3();
            break;
        case 4:
            Exercicio4();
            break;
        case 5:
            Exercicio5();
            break;
        case 6:
            Exercicio6();
            break;
        case 0:
            Sair();
            break;
        default:
            OpcaoInvalida();
            break;
    }

    if (opcao != 0)
    {
        Console.WriteLine("Voce saiu do menu");
        Console.ReadKey();
    }

} while (opcao != 0);


// --- Funções de cada exercício ---

 void Exercicio1()
{
    Console.WriteLine("Realizando o exercício 1...");
    Console.WriteLine("Digite seu salário");
double salario = double.Parse(Console.ReadLine());

Console.WriteLine("Digite seu Gasto");
double gasto = double.Parse(Console.ReadLine());

if (gasto <= salario)
{
    Console.WriteLine("Gastos dentro do orçamento");
}

else
{
    Console.WriteLine("Orçamento estourado");
}
}

void Exercicio2()
{
    int time1, time2;

    Console.WriteLine("Realizando o exercício 2...");
    Console.WriteLine("Digite a pontuação do time 1");
time1 = int.Parse(Console.ReadLine());

Console.WriteLine("Digite a pontuação do time 2");
time2 = int.Parse(Console.ReadLine());


if (time1 > time2)
{
    Console.WriteLine("Vitória do time 1");
}

else if (time1 < time2)
{
    Console.WriteLine("Vitória do time 2");
}

else
{
     Console.WriteLine("O jogo terminou empatado");
}
}

 void Exercicio3()
{
    double lado1, lado2, lado3;

    Console.WriteLine("Realizando o exercício 3...");
    Console.WriteLine("Digite a medida do primeiro lado");
lado1 = double.Parse(Console.ReadLine());

Console.WriteLine("Digite a medida do segundo lado");
lado2 = double.Parse(Console.ReadLine());

Console.WriteLine("Digite a medida do terceiro lado");
lado3 = double.Parse(Console.ReadLine());


if (lado1 == lado2 && lado2 == lado3)
{
    Console.WriteLine("Todos os lados são iguais, portanto o Triângulo é EQUILÁTERO");
}

else if (lado1 == lado2 || lado1 == lado3 || lado2 == lado3)
{
    Console.WriteLine("Temos dois lados iquais, portanto o Triângulo é ISÓSCELES");
}

else
{
    Console.WriteLine("Todos os lados são diferentes, portanto o Triângulo é ESCALENO");
}
}

 void Exercicio4()
{
    Console.WriteLine("Realizando o exercício 4...");
      int senha;

Console.WriteLine("Digite a senha");
senha = int.Parse(Console.ReadLine());

if (senha == 1234)
{
    Console.WriteLine("ACESSO PERMITIDO");
}

else
{
    Console.WriteLine("ACESSO NEGADO");
}
}

 void Exercicio5()
{
    Console.WriteLine("Realizando o exercício 5...");
    int macas;
double preco, total;

        Console.WriteLine("Digite o número de maçãs compradas:");
        macas = int.Parse(Console.ReadLine());

        if (macas < 12)
        {
            preco = 0.30;
        }
        else
        {
            preco = 0.25;
        }

        total = macas * preco;

        Console.WriteLine($"O valor total da compra é: R$ {total}");
}

 void Exercicio6()
{
    Console.WriteLine("Realizando o exercício 6...");
            double media, frequencia;


Console.WriteLine("Digite a Média do Aluno");
media = double.Parse(Console.ReadLine());


Console.WriteLine("Digite a frequência do Aluno");
frequencia = double.Parse(Console.ReadLine());


if(frequencia < 75)
{
    Console.WriteLine("Reprovado por falta");
}

else
{
        Console.WriteLine("Aprovado por presença");
}


if (media > 7)
{
    Console.WriteLine("APROVADO, nota alta");
}

else if (media >= 3)
{
    Console.WriteLine("RECUPERAÇÃO");
}

else
{
    Console.WriteLine("REPROVADO, nota baixa");
}
}

void Sair()
{
    Console.WriteLine("Saindo do menu...");
}

 void OpcaoInvalida()
{
    Console.WriteLine("Opção invalida.");
}


 while (opcao != 0);