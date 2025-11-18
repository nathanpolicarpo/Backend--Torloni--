﻿//Pessa ao usuário dois numeros, e mostre qual é o maior

int n1, n2;

Console.WriteLine("Digite o primeiro número");
n1 = int.Parse(Console.ReadLine());//pega o texto que o usuário digitar e transforma em número

Console.WriteLine("Digite o segundo número");
n2 = int.Parse(Console.ReadLine());

if (n1 > n2)
{
    Console.WriteLine("O Primeiro número é o maior: " + n1);
}

else if (n1 < n2)
{
    Console.WriteLine($"O segundo número é o maior: {n2}");
}

else if (n1 == n2)
{
        Console.WriteLine($"Os dois números são iguais: {n1} e {n2}");
}