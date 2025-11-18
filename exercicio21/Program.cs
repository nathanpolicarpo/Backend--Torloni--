﻿/*Faça um programa que receba 3 números inteiros e imprima na tela
a somatória total dos números*/


int soma = 0, numero;


for (int i = 1; i <= 3; i++)
{
    Console.WriteLine($"Digite o {i} número: ");
    numero = int.Parse(Console.ReadLine());
    soma += numero;
}

Console.WriteLine($"A soma do total dos números é: {soma}");