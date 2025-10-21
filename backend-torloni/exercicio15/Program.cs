double n1, n2, n3, n4, media;

Console.WriteLine("Digite a primeira nota");
n1 = double.Parse(Console.ReadLine());//pega o texto que o usuário digitar e transforma em número
Console.WriteLine("Digite a segunda nota");
n2 = double.Parse(Console.ReadLine());//pega o texto que o usuário digitar e transforma em número
Console.WriteLine("Digite a teceira nota");
n3 = double.Parse(Console.ReadLine());//pega o texto que o usuário digitar e transforma em número
Console.WriteLine("Digite a quarta nota");
n4 = double.Parse(Console.ReadLine());//pega o texto que o usuário digitar e transforma em número

media = (n1 + n2 + n3 + n4) / 4;

if (media >= 7)
{
    Console.WriteLine("O aluno esta APROVADO!");
    Console.WriteLine($"A media do aluno é: {media} ");
}
else if (media >= 5 && media < 7)
{
    Console.WriteLine("O aluno esta de RECUPERACAO!");
    Console.WriteLine($"A media do aluno é: {media} ");
}
else
{
    Console.WriteLine("O aluno esta REPROVADO!");
    Console.WriteLine($"A media do aluno é: {media} ");
}
