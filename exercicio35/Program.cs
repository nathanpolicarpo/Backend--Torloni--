﻿/*Faça um programa que solicite ao usuário um número de repetições "x". Para cada
repetição solicite dois números e imprima qual é o maior deles.*/

int n = 0, contador = 0;
double n1, n2;

Console.WriteLine("Digite um número de repetição");
n = int.Parse(Console.ReadLine());

while (contador < n)
{
    
    Console.WriteLine("Digite o primeiro número");
    n1 = double.Parse(Console.ReadLine());

    Console.WriteLine("Digite o segundo número");
    n2 = double.Parse(Console.ReadLine());

    if (n1 > n2)
    {
        Console.WriteLine($"O primeiro número é maior: {n1}");
    }


    else if (n1 < n2)
    {
        Console.WriteLine($"O Segundo número é maior: {n2}");
    }

    else 
    {
        Console.WriteLine($"Os dois números são iguais: {n1} = {n2}");
    }

    contador++;
}