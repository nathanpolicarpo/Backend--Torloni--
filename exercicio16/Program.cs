﻿/*Uma empresa decide dar aumento aos funcionários de acordo com o seu cargo, disposto na tabela abaixo

de acordo com a tabela acima faça um programa que receba o cargo e o salario de um funcionário e 
calcule e imprima o salário reajustado*/

string cargo;
double salario, salario2;

Console.WriteLine("Escolha um dos cargos");
Console.WriteLine();
Console.WriteLine(" *producao ");
Console.WriteLine(" *administrativo ");
Console.WriteLine(" *diretoria ");

cargo = Console.ReadLine();


Console.WriteLine("Digite seu salário atual");
salario = double.Parse(Console.ReadLine());



if (cargo == "producao")
{
    salario2 = salario * 1.065;
}

else if (cargo == "administrativo")
{
    salario2 = salario * 1.075;
}

else if (cargo == "diretoria")
{
    salario2 = salario * 1.12;
}


else
{
    salario2 = salario;
    Console.WriteLine("Cargo inválido, sem diretiro a reajustes");
}

Console.WriteLine($"Seu novo salário é: {salario2}");