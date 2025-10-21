
double Lado1, Lado2, Lado3;

 Console.WriteLine("Digite o primeiro lado do triângulo:");
        Lado1 = double.Parse(Console.ReadLine());

Console.WriteLine("Digite o segundo lado do triângulo:");
        Lado2 = double.Parse(Console.ReadLine());

Console.WriteLine("Digite o terceiro lado do triângulo:");
        Lado3 = double.Parse(Console.ReadLine());

if (Lado1 == Lado2 && Lado2 == Lado3)
{
     Console.WriteLine("Triângulo Equilátero");
}
 else if (Lado1 == Lado2 || Lado1 == Lado3 || Lado2 == Lado3)
{
    Console.WriteLine("Triângulo Isósceles");
}
else
{
    Console.WriteLine("Triângulo Escaleno");
}
    
