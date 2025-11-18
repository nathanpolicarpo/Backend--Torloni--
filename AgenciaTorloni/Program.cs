﻿//Crie um menu da seguinte forma em loop que chame as funções:
// 1. Cadastrar cliente
// 2. Depositar
// 3. Sacar
// 4. Transferir
// 5. Listar Clientes
// 0. Sair

//Por enquanto, as funções apenas devem exibir uma mensagem "Função em Desenvolvimento"

using System.Data.Common;
using System.Diagnostics;

int opcao = -1, totalClientes = 0;
string[] nomes = new string[3];
double[] saldos = new double[3];


Console.Clear();




do
{

    System.Console.WriteLine("=========AGÊNCIA BANCARIA, BEM VINDO(A)=========");
    System.Console.WriteLine();
    System.Console.WriteLine("Bem vindo(a) a nossa agência Bancaria, o que deseja realizar?");
    System.Console.WriteLine();
    System.Console.WriteLine(" 1. Cadastrar cliente");
    System.Console.WriteLine(" 2. Depositar");
    System.Console.WriteLine(" 3. Sacar");
    System.Console.WriteLine(" 4. Transferir");
    System.Console.WriteLine(" 5. Listar Clientes");
    System.Console.WriteLine(" 0. Sair");

    opcao = int.Parse(Console.ReadLine());


    switch (opcao)
    {
        case 0:
            Console.WriteLine("Obrigado por usar nosso Sistema Bancario, Encessando...");
            break;

        case 1:
            CadastrarCliente();
            break;

        case 2:
            Depositar();
            break;

        case 3:
            Sacar();
            break;

        case 4:
            Transferir();
            break;

        case 5:
            ListarClientes();
            break;



        default:
            Console.WriteLine($"Opção Inválida, pressione <ENTER> para continuar");
            Console.WriteLine();
            break;
    }

Console.WriteLine("Aperte <ENTER> para continuar...");
    Console.ReadLine();

} while (opcao != 0);

void CadastrarCliente()
{
//Verificar se tem espaço no array para cadastrar
    if (totalClientes >= 3)
    {
        
        Console.ReadLine();
        return;
    }
   
   //Cadastra o cliente
      Console.Write($"Nome do Cliente: ");
    nomes[totalClientes] = Console.ReadLine();
    saldos[totalClientes] = 0;
    totalClientes++;

    Console.WriteLine("Cadastrado com sucesso...");
    Console.WriteLine();


}

void Depositar()
{

    int idCliente = BuscarCliente();

    if (idCliente == -1)
    {
        return;
    }

    System.Console.WriteLine($"Valor para depósito: ");
    double valorDeposito = double.Parse(Console.ReadLine());
    saldos[idCliente] += valorDeposito;
    System.Console.WriteLine($"Depósito de R$ {valorDeposito} realizado!");


}

void Sacar()
{

    //Buscar o cliente
    int idCliente = BuscarCliente();
    if (idCliente == -1)
    {
        return;
    }

    //Pedir o valor do saque
    System.Console.Write($"Valor do saque: ");
    double valor = double.Parse(Console.ReadLine());

    //Validar se pode sacar ou não
    if (saldos[idCliente] >= valor)
    {//saldo permite saque


        //atualizar o saldo da conta
        saldos[idCliente] -= valor;
        System.Console.WriteLine($"Saque realizado com sucesso");

    }

    else
    {
        System.Console.WriteLine("Saldo insuficiente!");
    }



}

void Transferir()
{

    //Buscar cliente - conta de origem
    //Buscar cliente - conta de destino
    //pedir o valor do saque
    //verificar se a conta de origem tem saldo para transferir
    //se tiver, transfere (debita saldo na conta de origem e adiciona saldo na conta)

    System.Console.WriteLine($"===Trasferência===");
    System.Console.WriteLine($"Conta de origem: ");
    int idClienteOrigem = BuscarCliente();

    if (idClienteOrigem == -1)
    {
        return;
    }

    System.Console.WriteLine($"Conta de Origem: ");
    int idClienteDestino = BuscarCliente();
    if (idClienteDestino == -1)
    {
        return;
    }

    Console.Write($"Valor para trasferir: ");
    double valor = double.Parse(Console.ReadLine());


    if (saldos[idClienteOrigem] >= valor)
    {//tem saldo para transferir
        saldos[idClienteOrigem] -= valor;
        saldos[idClienteDestino] += valor;
        System.Console.WriteLine("Tranferência concluida com sucesso!!");
    }


    else
    {
System.Console.WriteLine("Saldo insuficiente!");
    }
    
}

void ListarClientes()
{

    System.Console.WriteLine("======LISTA DE CLIENTES======");

    for (int i = 0; i < totalClientes; i++)
    {
        Console.WriteLine($" {i} - {nomes[i]} | Saldo: R${saldos[i]}");
        Console.WriteLine();
    }


}


int BuscarCliente()
{
    ListarClientes();//Desenha a lista de clientes
    System.Console.Write($"Digite o numero do cliente: ");
    int idCliente = int.Parse(Console.ReadLine());

    if (idCliente < 0 || idCliente >= totalClientes)
    {
        System.Console.WriteLine($"Cliente não encontrado");
        return -1;
    }

    return idCliente;//Aqui vai ser devolvido do id do cliente (Indice do array onde ele está cadastrado)
}