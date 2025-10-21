int opcao;

do
{
    Console.WriteLine("-------------------------------------------------------");
    Console.WriteLine("                Menu Exercícios (1 a 6)                ");
    Console.WriteLine("-------------------------------------------------------");

    Console.WriteLine("Exercicios para realizar:");
    Console.WriteLine("1");
    Console.WriteLine("2");
    Console.WriteLine("3");
    Console.WriteLine("4");
    Console.WriteLine("5");
    Console.WriteLine("6");
    Console.WriteLine("0 (Sair)");
    Console.WriteLine("");
    Console.WriteLine("Digite o exercicio que deseja realizar:");

    if (!int.TryParse(Console.ReadLine(), out opcao))
    {
        Console.WriteLine("Numero invalido");
        continue;
    }

    switch (opcao)
    {
        case 1:
            Exercicio1();
            break;
        case 2:
            Exercicio2();
            break;
        case 3:
            Exercicio3();
            break;
        case 4:
            Exercicio4();
            break;
        case 5:
            Exercicio5();
            break;
        case 6:
            Exercicio6();
            break;
        case 0:
            Sair();
            break;
        default:
            OpcaoInvalida();
            break;
    }

    if (opcao != 0)
    {
        Console.WriteLine("Voce saiu do menu");
        Console.ReadKey();
    }

} while (opcao != 0);


// --- Funções de cada exercício ---

static void Exercicio1()
{
    Console.WriteLine("Realizando o exercício 1...");
    double salario = 0.0, gasto = 0.0;

    Console.WriteLine("Informe o salário recebido");
    salario = double.Parse(Console.ReadLine());

    Console.WriteLine("Informe o total gasto");
    gasto = double.Parse(Console.ReadLine());

    if (salario > gasto)
    {
        Console.WriteLine("Gastos dentro do orçamento");
    }
    else
    {
        Console.WriteLine("Orçamento estourado");
    }
}

static void Exercicio2()
{
    Console.WriteLine("Realizando o exercício 2...");
    int time1, time2;

    Console.Write("Gols do time 1: ");
    time1 = int.Parse(Console.ReadLine());

    Console.Write("Gols do time 2: ");
    time2 = int.Parse(Console.ReadLine());

    if (time1 > time2)
        Console.WriteLine("Time 1 venceu!");
    else if (time2 > time1)
        Console.WriteLine("Time 2 venceu!");
    else
        Console.WriteLine("Empate!");
}

static void Exercicio3()
{
    Console.WriteLine("Realizando o exercício 3...");
    double lado1, lado2, lado3;

    Console.WriteLine("Digite o primeiro lado do triângulo:");
    lado1 = double.Parse(Console.ReadLine());

    Console.WriteLine("Digite o segundo lado do triângulo:");
    lado2 = double.Parse(Console.ReadLine());

    Console.WriteLine("Digite o terceiro lado do triângulo:");
    lado3 = double.Parse(Console.ReadLine());

    if ((lado1 < lado2 + lado3) && (lado2 < lado1 + lado3) && (lado3 < lado1 + lado2))
    {
        if (lado1 == lado2 && lado2 == lado3)
        {
            Console.WriteLine("Triângulo Equilátero");
        }
        else if (lado1 == lado2 || lado1 == lado3 || lado2 == lado3)
        {
            Console.WriteLine("Triângulo Isósceles");
        }
        else
        {
            Console.WriteLine("Triângulo Escaleno");
        }
    }
    else
    {
        Console.WriteLine("As medidas informadas não formam um triângulo.");
    }
}

static void Exercicio4()
{
    Console.WriteLine("Realizando o exercício 4...");
       Console.Write("Digite a senha: ");
        int senha = int.Parse(Console.ReadLine());

        if (senha == 134)
            Console.WriteLine("Acesso permitido");
        else
            Console.WriteLine("Acesso negado");
}

static void Exercicio5()
{
    Console.WriteLine("Realizando o exercício 5...");
    Console.Write("Digite o número de maçãs compradas: ");
        int quantidade = int.Parse(Console.ReadLine());

        double preco;

        if (quantidade >= 12)
        {
            preco = 0.25;
        }
        else
        {
            preco = 0.30;
        }
        
        double total = quantidade * preco;

    
        Console.WriteLine($"O valor total da compra é: R$ {total:F2}");
}

static void Exercicio6()
{
    Console.WriteLine("Realizando o exercício 6...");
            Console.Write("Digite a média do aluno: ");
        double media = double.Parse(Console.ReadLine());

        Console.Write("Digite a frequência do aluno em %: ");
        double frequencia = double.Parse(Console.ReadLine());

        // Estruturas de decisão
        if (frequencia < 75)
        {
            Console.WriteLine("Aluno reprovado por FREQUENCIA");
        }
        else if (media >= 7.0)
        {
            Console.WriteLine("Aluno APROVADO");
        }
        else if (media >= 3.0)
        {
            Console.WriteLine("Aluno em RECUPERAÇÃO.");
        }
        else
        {
            Console.WriteLine("Aluno reprovado por MEDIA.");
        }
}

static void Sair()
{
    Console.WriteLine("Saindo do menu...");
}

static void OpcaoInvalida()
{
    Console.WriteLine("Opção invalida.");
}


 while (opcao != 0);