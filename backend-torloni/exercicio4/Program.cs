int senha = 1234;
int SenhaDigitada = 0;

Console.WriteLine("Digite a senha correta:");
SenhaDigitada = int.Parse(Console.ReadLine());

if (senha == SenhaDigitada)
{
    Console.WriteLine("Senha Correta!");
}
else
{
    Console.WriteLine("Senha Incorreta!");
}