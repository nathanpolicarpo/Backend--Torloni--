
using ClassesEstaticas;

Console.WriteLine("Bem vindo ao programa");
System.Console.WriteLine();

Console.WriteLine($"Digite um numero: ");
float a = float.Parse(Console.ReadLine());
Console.WriteLine($"Digite outro numero");
float b = float.Parse(Console.ReadLine());

float maior = Math.Max(a, b);
float menor = Math.Min(a, b);
if (maior == menor)
{
    Console.WriteLine("Os numeros sao iguais");
}
else
{
    Console.WriteLine($"O maior numero e: {maior}");
    Console.WriteLine($"O menor numero e: {menor}");
}



// uso da classe estatica de forma auxiliar
// float r = CalculosMatematicos.Somar(a, b);
// System.Console.WriteLine($"O resultado da soma e: {r}");

// r = CalculosMatematicos.Subtrair(a, b);
// System.Console.WriteLine($"O resultado da subtracao e: {r}");

// r = CalculosMatematicos.Multiplicar(a, b);
// System.Console.WriteLine($"O resultado da multiplicacao e: {r}");

// r = CalculosMatematicos.Dividir(a, b);
// System.Console.WriteLine($"O resultado da divisao e: {r}");

// solicitar ao usuario 2 numeros reais e informar qual e p maior e qual e o menor dos numeros. para isso voce deve utilizar a classe math, utilizando do c#

