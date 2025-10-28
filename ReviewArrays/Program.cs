using System.Linq.Expressions;
using System.Net.WebSockets;

string[] Nomes = new string[4];
int[] Idades = new int[4];
int opcao = -1, totalAlunos = 0;

// Nomes[0] = "Maria";
// Idades[0] = 20;

// Nomes[1] = "Matheus";
// Idades[1] = 16;

// Nomes[2] = "Eloysa";
// Idades[2] = 17;

// Nomes[3] = "Felipe";
// Idades[3] = 17;


do
{
    Console.Clear();
    Console.WriteLine($"1) Cadastrar Alunos");
    Console.WriteLine($"2) Listar Alunos");
    Console.WriteLine($"0) Sair");
    Console.Write($"Digite uma opção:");
    opcao = int.Parse(Console.ReadLine());

    switch (opcao)
    {
        case 0:
            Console.WriteLine($"Encerrando ...");
            Console.WriteLine($"Pressione <Enter> para encerrar");
            Console.ReadLine();
            break;

        case 1:
            CadastrarAluno();
            break;

        case 2:
            ListarAlunos();
            break;

        default:
            Console.WriteLine($"opção invalida, presione <enter> para continuar ...");
            Console.ReadLine();
            break;
    }
} while (opcao != 0);

void CadastrarAluno()

{
    if (totalAlunos >= 4)
    {
        Console.WriteLine($"Não Limite de ocupação atingido");
        return;
    }

    Console.WriteLine($"Digite o nome do aluno");
    string n = Console.ReadLine();
    Console.WriteLine($"Digite a idade de {n}");
    int i = int.Parse(Console.ReadLine());

    Nomes[totalAlunos] = n;
    Idades[totalAlunos] = i;
    totalAlunos++;

    Console.WriteLine($"Aluno cadastrado com sucesso");
    Console.WriteLine($"Ha {totalAlunos} alunos(s) cadastrado(s) no sistema!");
    Console.WriteLine($"Precione <enter> para continuar");
    Console.ReadLine();
}



void ListarAlunos()
{
    Console.WriteLine();
    Console.WriteLine($"Resultado: ");

for (int i = 0; i < Nomes.Length; i++)
{
    Console.WriteLine($" Nome: {Nomes[i]}");
    Console.WriteLine($" Idade: {Idades[i]} anos");
    Console.WriteLine();
}
}
    