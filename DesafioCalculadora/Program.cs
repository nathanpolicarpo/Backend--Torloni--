double n1, n2, operacao, continuar;

do
{
    Console.WriteLine("Digite o número da operação:");
    Console.WriteLine("1-Soma");
    Console.WriteLine("2-Subtração");
    Console.WriteLine("3-Multiplicação");
    Console.WriteLine("4-Divisão");
    Console.WriteLine("0-Sair");
    Console.WriteLine("");
   
    operacao = double.Parse(Console.ReadLine());
    Console.WriteLine("");

    if (operacao == 0)
    {
        sair();
    }
    else
    {
        Console.WriteLine("Digite o primeiro número:");
        n1 = double.Parse(Console.ReadLine());
        Console.WriteLine("Digite o segundo número:");
        n2 = double.Parse(Console.ReadLine());
        
        switch (operacao)
        {
            case 1:
                soma();
                break;
            case 2:
                subtração();
                break;
            case 3:
                multiplicação();
                break;
            case 4:
                divisão();
                break;
            default:
                invalida();
                break;
        }
    Thread.Sleep(1000);
    }
} while (operacao != 0);

void sair()
{
    Console.WriteLine("Ate mais!");
}

void soma()
{
    double resultado = n1 + n2;
    Console.WriteLine((n1) + " + " + (n2) + " = " + (resultado));
}

void subtração()
{
    double resultado = n1 - n2;
    Console.WriteLine((n1) + " - " + (n2) + " = " + (resultado));
}

void multiplicação()
{
    double resultado = n1 * n2;
    Console.WriteLine((n1) + " * " + (n2) + " = " + (resultado));
}

void divisão()
{
    if (n2 == 0 || n1 == 0)
    {
        Console.WriteLine("WOW!!! se e burro? não tem como dividir por zero animal");
    }
    else
    {
        double resultado = n1 / n2;
        Console.WriteLine((n1) + " / " + (n2) + " = " + (resultado));
    }
}

void invalida()
{
    Console.WriteLine("WOW!!! parece que não foi");
}