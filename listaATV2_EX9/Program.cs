﻿/*
altere o exercício anterior para que cada opção escolhida pelo usuário seja respondida por uma função,
 ou seja, cada opção deve dar um Console.WriteLine() da opção escolhida.
*/

int opcao = -1;

while (opcao != 0)
{
    


Console.WriteLine("-----------------------------------");
Console.WriteLine("         Bem Vindo, Usuário        ");
Console.WriteLine("-----------------------------------");


Console.WriteLine("Escolha uma opção abaixo:");


Console.WriteLine("1) Opção 1");
Console.WriteLine("2) Opção 2");
Console.WriteLine("3) Opção 3");
Console.WriteLine("0) Sair");


Console.WriteLine("Digite sua escolha");
opcao = int.Parse(Console.ReadLine());



    switch (opcao)
    {
        case 1:
            Opcao1();
            break;

        case 2:
            Opcao2();
            break;

        case 3:
            Opcao3();
            break;

        case 0:
            Sair();
            break;

        default:
            invalid();
            break;

    }


}

void Opcao1()
{
    Console.WriteLine("Você escolheu a Opção 1.");
}

void Opcao2()
{
    Console.WriteLine("Você escolheu a Opção 2.");
}

void Opcao3()
{
    Console.WriteLine("Você escolheu a Opção 3.");
}

void Sair()
{
    Console.WriteLine("Você escolheu a Opção 0. Saindo do programa...");
}

void invalid()
{
    Console.WriteLine("Não temos esta opcão");
}