﻿/*
Faça um programa que o usuário informe o salário recebido e o total gasto. 
Deverá ser exibido na tela “Gastos dentro do orçamento” caso o valor gasto 
não ultrapasse o valor do salário e “Orçamento estourado” se o valor gasto ultrapassar o valor do salário.
*/


double salario, gasto;





Console.WriteLine("Digite seu salário");
salario = double.Parse(Console.ReadLine());

Console.WriteLine("Digite seu Gasto");
gasto = double.Parse(Console.ReadLine());

if (gasto <= salario)
{
    Console.WriteLine("Gastos dentro do orçamento");
}

else
{
    Console.WriteLine("Orçamento estourado");
}