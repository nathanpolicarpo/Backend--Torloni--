﻿//arrays

//Arrays
using System.Net.WebSockets;

Console.Clear();

string [] nomes = new string [4];
int[] idades = new int[4];
int opcao = -1, totalAlunos = 0;




// nomes[0] = "Marcos";
// idades[0] = 20;

// nomes[1] = "Matheus";
// idades[1] = 16;

// nomes[2] = "Negueba";
// idades[2] = 17;

// nomes[3] = "João";
// idades[3] = 19;

// nomes[4] = "Josue";
// idades[4] = 50;





do
{
    System.Console.WriteLine("Escolha uma das opções abaixo");
    System.Console.WriteLine();
    Console.WriteLine($"1) Cadastrar Alunos");
    Console.WriteLine($"2) Listar Alunos");
    Console.WriteLine($"0) Sair");
   Console.WriteLine();
    Console.WriteLine($"Digite uma opção");

    opcao = int.Parse(Console.ReadLine());

    switch (opcao)
    {

        case 0:
            Console.WriteLine("Encessando...");
            Console.WriteLine("Pressione <ENTER> para encerrar");
            Console.WriteLine();
            break;

        case 1:
            CadastrarAluno();
            break;
            
        case 2:
           ListarAlunos();
            break;




        default:
            Console.WriteLine($"Opção Inválida, pressione <ENTER> para continuar");
            Console.WriteLine();
            break;
    }


} while (opcao != 0);


//================FUNÇÕES================


void CadastrarAluno()
{
    //Verificar se tem espaço no array para cadastrar (totalAlunos)

    if (totalAlunos >= 4)
    {
        Console.WriteLine($"Não: Limite de ocupação atingido");
        Console.WriteLine($"Pressione <ENTER> para continuar...");
        Console.ReadLine();
        return;
    }
    //Pedir os dados para o usuário (nome,idade)

    Console.WriteLine($"Digitre o nome do Aluno");
    string n = Console.ReadLine();

    Console.WriteLine($"Digitre a idade de {n}"); ;
    int i = int.Parse(Console.ReadLine());

    //Guardar/Cadatrar no Array
    nomes[totalAlunos] = n;
    idades[totalAlunos] = i;
    totalAlunos++;

    Console.WriteLine("Aluno Cadastrado com sucesso");
    Console.WriteLine($"Há {totalAlunos} aluno(s) cadastrado(s) no sistema");
    Console.WriteLine("Pressione <ENTER> para continuar");
    Console.ReadLine();//Parar o sistema e esperar o usuário da um <ENTER>
}










// Função para exibir os alunos
void ListarAlunos()
{

    Console.WriteLine();
    Console.WriteLine($"Resultado: ");


    for (int i = 0; i < nomes.Length; i++)
    {
        Console.WriteLine($" Nome: {nomes[i]}");
        Console.WriteLine($" Idade: {idades[i]}");
        Console.WriteLine();
    }

    Console.WriteLine("Pressione <ENTER> para continuar");
    Console.ReadLine();

}