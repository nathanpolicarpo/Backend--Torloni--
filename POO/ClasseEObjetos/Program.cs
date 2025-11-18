

using ClassesEObjetos;
//Criar uma classe para representar uma garrafa
//Propriedades
//Métodos


// Garrafa g1 = new Garrafa();

//             Console.Clear();
//             Console.WriteLine("=== Garrafa ===");
//             Console.WriteLine("----------------------------");

//             Console.Write("Digite a marca da garrafa: ");
//             g1.Marca = Console.ReadLine();

//             Console.Write("Digite o modelo da garrafa: ");
//             g1.Modelo = Console.ReadLine();

//             Console.Write("Digite a cor da garrafa: ");
//             g1.Cor = Console.ReadLine();

//             Console.Write("Digite a capacidade (em ml): ");
//             g1.Capacidade = double.Parse(Console.ReadLine());

//             Console.Clear();
//             Console.WriteLine("=== Sua Garrafa ===");
//             Console.WriteLine($"Marca: {g1.Marca}");
//             Console.WriteLine($"Modelo: {g1.Modelo}");
//             Console.WriteLine($"Cor: {g1.Cor}");
//             Console.WriteLine($"Capacidade: {g1.Capacidade}L");
//             Console.WriteLine("----------------------------");

//             // Testando os métodos
//             Console.WriteLine("\nAgora vamos testar as funções da garrafa:");
//             g1.Abrir();
//             g1.Encher();
//             g1.Fechar();
//             g1.Abrir();
//             g1.Esvaziar();
//             g1.Fechar();

//-----------------------------------------------------------------------------------------


//--------------------------------------------------PESSOA---------------------------------

// Pessoa joao = new Pessoa();

// joao.Nome = "João Silva";
// Console.WriteLine($"{joao.Nome} tem {joao.Idade} anos");

// joao.Envelhecer(17);
// Console.WriteLine($"{joao.Nome} tem {joao.Idade} anos");

// int novaIdade = joao.Envelhecer(17);//atualizaa idade e devolve a idade
// Console.WriteLine($"{joao.Nome} tem {joao.Idade} anos");

// joao.Envelhecer(-50);//devolve a idade antiga: 17
// Console.WriteLine($"{joao.Nome} tem {joao.Idade} anos");









//------------------------------------------------------------------------------------------

// Crie uma classe ContaBancaria com os atributos titular e saldo.
// Crie os métodos Depositar(valor) e Sacar(valor).
// Mostre o saldo atual após cada operação no console.

// O objeto ContaBancaria representa uma conta real.
// Quando o método Depositar for chamado, o saldo aumenta.
// Quando o método Sacar for chamado, o saldo diminui.
// No final, o programa deve mostrar o saldo atualizado.

// Criação do objeto Produto
Produto produto = new Produto();

// Pede informações ao usuário
Console.Write("Digite o nome do produto: ");
produto.nome = Console.ReadLine();

Console.Write("Digite o preço do produto: ");
produto.preco = double.Parse(Console.ReadLine());

Console.Write("Digite o percentual de desconto (%): ");
double percentual = double.Parse(Console.ReadLine());

Console.WriteLine();
Console.WriteLine($"Produto: {produto.nome}");
Console.WriteLine($"Preço original: R${produto.preco:F2}");
Console.WriteLine();

// Aplica o desconto
produto.AplicarDesconto(percentual);

// Mostra o preço final
Console.WriteLine($"Preço final do produto {produto.nome}: R${produto.preco:F2}");
