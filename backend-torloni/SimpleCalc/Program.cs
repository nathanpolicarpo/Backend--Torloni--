string nome;
int numero1;
int numero2;

Console.WriteLine("Digite seu nome");
nome = Console.ReadLine();

Console.WriteLine("Digite o primeiro numero");
numero1 = int.Parse(Console.ReadLine());
Console.WriteLine("Digite o segundo numero");
numero2 = int.Parse(Console.ReadLine());

int soma = numero1 + numero2;

Console.WriteLine(nome);
Console.WriteLine(soma);

