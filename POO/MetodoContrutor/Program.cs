
using MetodoConstrutor;

Pessoa fontes = new Pessoa("João", 17);
fontes.Nome = "Lorenzo";
fontes.Idade = 20;
//Console.WriteLine($"O objeto Pessoa que criei é o {fontes.Nome} com a idade de {fontes.Idade} anos");

//fontes.Nome = "Gustavo Oliveira";

//System.Console.WriteLine($"{fontes.Nome}");

//fontes.Nome = "Henrique";

//fontes.ExibirDados();
//System.Console.WriteLine($"{fontes.Nome}");


//Primeiro construtor
Pessoa3SobreCargas PrimeiraPessoa = new Pessoa3SobreCargas();

System.Console.WriteLine(@$"Primeira Pessoa Cadastrada:
                            Nome: {PrimeiraPessoa.Nome}
                            Idade: {PrimeiraPessoa.Idade}
");
System.Console.WriteLine();
//Segundo construtor
Pessoa3SobreCargas SegundaPessoa = new Pessoa3SobreCargas("Matheus Felix");

System.Console.WriteLine(@$"Segunda Pessoa Cadastrada:
                            Nome: {SegundaPessoa.Nome}
                            Idade: {SegundaPessoa.Idade}
");
System.Console.WriteLine();
//Terceiro construtor
Pessoa3SobreCargas TerceiraPessoa = new Pessoa3SobreCargas("Felipe Silva", 16);

System.Console.WriteLine("Digite o nome da Terceira Pessoa");
TerceiraPessoa.Nome =Console.ReadLine();

System.Console.WriteLine("Digite a idade da Terceira Pessoa");
TerceiraPessoa.Idade = int.Parse(Console.ReadLine());
Console.ReadLine();

System.Console.WriteLine(@$"Terceira Pessoa Cadastrada:
                            Nome: {TerceiraPessoa.Nome}
                            Idade: {TerceiraPessoa.Idade}
");
System.Console.WriteLine();
