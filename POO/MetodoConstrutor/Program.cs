
using MetodoConstrutor;
// Pessoa p1 = new Pessoa("João", 17);
// // p1.Nome = "Felipe Fontes";
// // p1.Idade = 17;
// Console.WriteLine(@$"O objeto pessoa que criei é o {p1.Nome} com a idade {p1.Idade}.");

// // p1.Nome = "Gustavo Oliveira";
// // p1.Nome = "Henrique";
// // Console.WriteLine($"{p1.Nome}");
// // Console.WriteLine($"{p1.Nome}");
// p1.ExibirDados();

Pessoa3Sobrecargas PrimeiraPessoa = new Pessoa3Sobrecargas();
Console.WriteLine($"Digite o nome da primeira pessoa:");
PrimeiraPessoa.Nome = Console.ReadLine();
Console.WriteLine($"Digite a idade da primeira pessoa:");
PrimeiraPessoa.Idade = int.Parse(Console.ReadLine());

Console.WriteLine(@$"Primeira Pessoa cadastrada:
                    Nome: {PrimeiraPessoa.Nome}
                    Idade: {PrimeiraPessoa.Idade}
                    
                    ");

Pessoa3Sobrecargas SegundaPessoa = new Pessoa3Sobrecargas("Matheus Felix");
Console.WriteLine($"Digite a idade da segunda pessoa:");
SegundaPessoa.Idade = int.Parse(Console.ReadLine());
Console.WriteLine(@$"Segunda Pessoa cadastrada:
                    Nome: {SegundaPessoa.Nome}
                    Idade: {SegundaPessoa.Idade}
                    
                    ");

Pessoa3Sobrecargas TerceiraPessoa = new Pessoa3Sobrecargas("Felipe Silva", 16);

Console.WriteLine($"Digite o nome da terceira pessoa:");
TerceiraPessoa.Nome = Console.ReadLine();
Console.WriteLine($"Digite a idade da terceira pessoa:");
TerceiraPessoa.Idade = int.Parse(Console.ReadLine());

Console.WriteLine(@$"Terceira Pessoa cadastrada:
                    Nome: {TerceiraPessoa.Nome}
                    Idade: {TerceiraPessoa.Idade}
                    ");
