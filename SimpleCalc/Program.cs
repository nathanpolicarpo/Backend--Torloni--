﻿/*
Pedir o nome do usuário,
pedir dois números e mostrar a soma dos números no final
*/

string nome;
int numero1;
int numero2;

// pedir os nomes pro usuário
Console.WriteLine("Digite seu nome");//exibe o nome do usuário

nome = Console.ReadLine();//pede o nome do usuário


//pedir os dois numeros
Console.WriteLine();
Console.WriteLine("Digite o primeiro número");
numero1 = int.Parse(Console.ReadLine());

Console.WriteLine();

Console.WriteLine("Digite o segundo número");
numero2 = int.Parse(Console.ReadLine());


//somar os dois numeros
int soma = numero1 + numero2;

//exibir nome e a soma
Console.WriteLine(nome);
Console.WriteLine(soma);
Console.WriteLine();