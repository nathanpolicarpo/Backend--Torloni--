﻿/* Escreva um programa que leia as medidas dos lados de um triângulo e escreva se ele é 
Equilátero, Isósceles ou Escaleno. Sendo que:     

   − Triângulo    Equilátero:    possui    os    3    lados    iguais.     
   − Triângulo    Isóscele:    possui    2    lados    iguais.     
   − Triângulo    Escaleno:    possui    3    lados    diferentes.
   */

double lado1, lado2, lado3;

Console.WriteLine("Digite a medida do primeiro lado");
lado1 = double.Parse(Console.ReadLine());

Console.WriteLine("Digite a medida do segundo lado");
lado2 = double.Parse(Console.ReadLine());

Console.WriteLine("Digite a medida do terceiro lado");
lado3 = double.Parse(Console.ReadLine());


if (lado1 == lado2 && lado2 == lado3)
{
    Console.WriteLine("Todos os lados são iguais, portanto o Triângulo é EQUILÁTERO");
}

else if (lado1 == lado2 || lado1 == lado3 || lado2 == lado3)
{
    Console.WriteLine("Temos dois lados iquais, portanto o Triângulo é ISÓSCELES");
}

else
{
    Console.WriteLine("Todos os lados são diferentes, portanto o Triângulo é ESCALENO");
}