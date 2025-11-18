﻿/*Faça um programa que imprima os números ímpares de 0 a 50*/

int n = 0;

for (n = 0; n <= 50; n ++)
{
    if (n % 2 == 1)
    {
        Console.WriteLine($"Imprimindo os números: {n}");
    }
    
}