
﻿/*
As maçãs custam R$ 0,30 cada se forem compradas menos do que uma dúzia, 
e R$ 0,25 se forem compradas pelo menos doze. Escreva um programa que leia o número de maçãs compradas, 
calcule e escreva o valor total da compra.
*/

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
