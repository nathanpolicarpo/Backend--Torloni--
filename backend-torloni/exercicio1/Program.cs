int salario, totalGasto;

Console.WriteLine("Digite o seu salário: ");
salario = int.Parse(Console.ReadLine());

Console.WriteLine("Digite o total gasto: ");
totalGasto = int.Parse(Console.ReadLine());

int dinheiroSobrando = salario - totalGasto;

if (salario >= totalGasto)
{
    Console.WriteLine("Gastos dentro do orçamento!");
    Console.WriteLine($"Dinheiro sobrando {dinheiroSobrando}");
} 
else
{
    Console.WriteLine("Orçamento estourado!");
}

