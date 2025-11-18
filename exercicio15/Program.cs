
﻿/*Faça um programa onde receba 4 notas de um aluno, calcule e imprima a média
aritmética das notas e a mensagem de APROVADO para a média superior ou igual a 7,0 RECUPERAÇÃO
para notas entre 5.0 e 7,0 ou a mensagem de REPROVADO para média inferior a 5,0*/

float nota1, nota2, nota3, nota4, media;
 


Console.WriteLine("Digite a primeira nota");
nota1 = float.Parse(Console.ReadLine());

Console.WriteLine("Digite a segunda nota");
nota2 = float.Parse(Console.ReadLine());

Console.WriteLine("Digite a terceira nota");
nota3 = float.Parse(Console.ReadLine());

Console.WriteLine("Digite a quarta nota");
nota4 = float.Parse(Console.ReadLine());



media = (nota1 + nota2 + nota3 + nota4) / 4;
Console.WriteLine($"Media da nota {media}");


if (media >= 7)
    Console.WriteLine($"APROVADO: {media}");

else if (media >= 5)
    Console.WriteLine($"RECUPERAÇÃO: {media}");

else 
    Console.WriteLine($"REPROVADO: {media}");
