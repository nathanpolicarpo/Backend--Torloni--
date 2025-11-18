﻿

Console.Clear();
Console.WriteLine("Digite seu nome");
string nome = Console.ReadLine();
Console.WriteLine("Digite seu sobrenome");
string sobrenome = Console.ReadLine();

Console.WriteLine($"ok, {nome}! Agora vamos dar as boas vindas a você!!");

Console.WriteLine($"Por Favor escolha uma opção abaixo");
Console.WriteLine($"    1 - Saudar com nome");
Console.WriteLine($"    2 - Saudar com sobrenome");
Console.WriteLine($"    3 - Saudar com nome e Sobrenome");
Console.WriteLine($"    0 - Apenas Saudação Genérica");


int opcao = 0;

switch (opcao)
{
    case 0:
        SaudacaoGenerica();
    break;

    case 1:
        SaudacaoNome(nome);
     break;

    case 2:
        SaudacaoSobrenome(sobrenome);
    break;

    case 3:
        string nomeCompleto = SaudacaoCompleto(nome, sobrenome);
        Console.WriteLine($"Seja Bem vindo {nomeCompleto}");
     break;


    default:
     break;
}



void SaudacaoGenerica()
{
    Console.WriteLine("Olá, seja bem vindo ao nosso programa, tenha um ótimo dia");
}

void SaudacaoNome(string nome)
{
    Console.WriteLine($"Olá {nome} seja bem vindo ao nosso programa, tenha um ótimo dia");
}


void SaudacaoSobrenome(string sobrenomeRecebido)
{
    Console.WriteLine($"Olá, seja bem-vindo {sobrenomeRecebido}");
}


string SaudacaoCompleto(string nome, string sobrenome)
{
    return $"{nome} {sobrenome}";
}