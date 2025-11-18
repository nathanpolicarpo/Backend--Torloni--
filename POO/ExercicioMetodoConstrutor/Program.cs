﻿
using System.IO.Pipes;
using ExerciciosMetodoConstrutor;


//EXERCICIO CLASSE CARRO

// Carro PrimeiroCarro = new Carro();

// System.Console.WriteLine(@$"Primeiro Carro:
//                             Marca: {PrimeiroCarro.Marca}
//                             Modelo: {PrimeiroCarro.Modelo}
//                             Ano: {PrimeiroCarro.Ano}
// "); 

// Carro SegundoCarro = new Carro("Honda", "CivicG10");

// System.Console.WriteLine(@$"Segundo Carro:
//                             Marca: {SegundoCarro.Marca}
//                             Modelo: {SegundoCarro.Modelo}
//                             Ano: {SegundoCarro.Ano}
// "); 

// Carro TerceiroCarro = new Carro("Porshe", "GT3", 1999);

// System.Console.WriteLine(@$"Terceiro Carro:
//                             Marca: {TerceiroCarro.Marca}
//                             Modelo: {TerceiroCarro.Modelo}
//                             Ano: {TerceiroCarro.Ano}
// "); 

//---------------------------------------------------------------------

//EXERCICIO CLASSE ALUNO

// Aluno PrimeiroAluno = new Aluno();

// System.Console.WriteLine(@$"Primeiro Aluno:
//                             Nome: {PrimeiroAluno.Nome}
//                             Nota: {PrimeiroAluno.Nota}

//  "); 

// Aluno SegundoAluno = new Aluno();

// System.Console.WriteLine("Digite o nome do Segundo Aluno");
// SegundoAluno.Nome = Console.ReadLine();

// System.Console.WriteLine("Digite a nota do Segundo Aluno");
// SegundoAluno.Nota = double.Parse (Console.ReadLine());



// System.Console.WriteLine(@$"Segundo Aluno:
//                             Nome: {SegundoAluno.Nome}
//                             Nota: {SegundoAluno.Nota}

//  "); 

//------------------------------------------------------------------------

//EXERCICIO CLASSE PRODUTO

//Produto p1 = new Produto("Mouse", 200.0, 15);

//p1.MostrarDados();

//-------------------------------------------------------------------------

//EXERCICIO CLASSE CONTA BANCARIA



//-------------------------------------------------------------------------

//EXERCICIO CLASSE MEDIA ALUNO

// MediaAluno a1 = new MediaAluno(6, 7, 2);

// a1.Nome = "Lucas";
// a1.Media();

// MediaAluno a2 = new MediaAluno();
// a2.Nome = "Samuel";
// a2.Media();

//-----------------------------------------------------------------------------

//Atividade  em Grupo

// Programa principal

    
        Aluno aluno = new Aluno();
        aluno.Nome = "Marcos";
        aluno.Idade = 17;
        aluno.Curso = "Desenvolvimento de Sistemas";

        aluno.Falar();   // Método herdado da classe Pessoa
        aluno.Estudar(); // Método da própria classe Aluno
    
        Console.WriteLine($"Nome: {aluno.Nome}, Idade: {aluno.Idade}, Curso: {aluno.Curso}");


Aluno edu = new Aluno();
