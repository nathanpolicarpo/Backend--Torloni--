
﻿using TheBasics;

Console.Clear();
// //arrays/Lista de pessoas
// List<Pessoa> peoples = new List<Pessoa>();



// //**************EDUARDO****************
// //Endereço
// Endereco enderecoEdu = new Endereco();
// enderecoEdu.Logradouro = "Rua Niterói";
// //pessoa com endereço
// Pessoa edu = new Pessoa(enderecoEdu);
// edu.Nome = "Eduardo Costa";
// edu.Idade = 43;

// //=============ALÉXIA==============
// //Endereço
// Endereco endAlexia = new Endereco();
// endAlexia.Logradouro = "Rua lá de casa";
// //pessoa com endereço
// Pessoa alexia = new Pessoa(endAlexia);
// alexia.Nome = "Alexia Santos";
// alexia.Idade = 24;



// //guardando os dados na lista
// peoples.Add(edu);//0
// peoples.Add(alexia);//1


// foreach (var p in peoples)
// {
//     System.Console.WriteLine($"Nome: {p.Nome}");
// }



// Endereco endEnzo = new Endereco();
// endEnzo.Logradouro = "Spínola Teixeira";
// endEnzo.Numero = 3960;
// Aluno PedroEnzo = new Aluno(endEnzo);
// PedroEnzo.Nome = "Pedro Enzo";
// PedroEnzo.Curso = "Desenvolvimento de Sistemas";
// PedroEnzo.RA = "1234-xpto";
// PedroEnzo.NotaFinal = 9.75f;

// //Professor
// Endereco endProfAlex = new Endereco();
// endProfAlex.Logradouro = "Rua lá de Casa";
// endProfAlex.Numero = 987;


// Professor profAlexia = new Professor(endProfAlex);
// profAlexia.Nome = "Aléxia Vitória";

// System.Console.WriteLine($"Aluno {PedroEnzo.Nome} estuda na turma {PedroEnzo.Curso} da profa. {profAlexia.Nome}");


Carro c1 = new Carro();
c1.Marca = "Honda";
c1.Modelo = "Civic G10";
c1.qtdRodas = 4;
c1.Ligar();
c1.Desligar();
c1.AbrirPortaMala();
c1.ExibirDadosCarro();



Moto dominar400 = new Moto();
dominar400.Marca = "Bajaj";
dominar400.Modelo = "Dominar 400";
dominar400.qtdRodas = 2;
dominar400.Ligar();
dominar400.Empinar();
dominar400.ExibirMoto();

Aviao av = new Aviao();
av.Marca = "Boeing";
av.Modelo = "737 MAX 9";
av.qtdRodas = 6;
av.qtdAcentos = 170;
av.qtdTurbina = 2;
av.companhia = "Gol";
av.Decolar();
av.ExibirAviao();
