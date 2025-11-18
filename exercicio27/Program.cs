﻿/*Faça um programa que pergunte para o usuário a quantidade de números que ele quer digitar.
Após isso crie um laço que exiba o número que o usuário digitar apenas se for PAR.
Utilize a estrutura WHILE*/


//Pergunte quantos números o usuário quer digitar
int contador = 1;
int nDigitado =1;


        Console.WriteLine("Quantos números você deseja digitar?");
        nDigitado = int.Parse(Console.ReadLine());
        

    //Criar um laço while baseado na quantidade de números que o usuário quer digitar
    
        while (contador <= nDigitado)
        {
            Console.WriteLine($"Digite o {contador} número:");
            nDigitado = int.Parse(Console.ReadLine());
           

    //dentro do laço, verificar se é par e imprimir $"Número digitado é par: {nDigitado}"

    if (nDigitado % 2 == 0)
    {
        Console.WriteLine($"Número digitado é par: {nDigitado}");

    }
             contador++;
        }