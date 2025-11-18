﻿/*
Crie um menu de console igual ao exibido abaixo, utilizando a estrutra switch do c#:

-------------------------------------------------------
        Bem Vindo, Usuário
-------------------------------------------------------


Escolha uma opção no menu abaixo:

   1) Opção 1
   2) Opção 2
   3) Opção 3
   0) Sair

O programa deve exibir uma mensagem informando a opção que o usuário escolheu ou uma mensagem de opção Inválida.
*/

int opcao;

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
        Console.WriteLine("Escolheu a opção 1");
        break;
    
    case 2:
        Console.WriteLine("Escolheu a opção 2");
        break;
    
    case 3:
        Console.WriteLine("Escolheu a opção 3");
     break;
    
    case 0:
        Console.WriteLine("Escolheu a opção 0, Saindo...");
        break;

    default:
        Console.WriteLine("Opção inválida, escolha as opções visíveis no menu");
        break;

}