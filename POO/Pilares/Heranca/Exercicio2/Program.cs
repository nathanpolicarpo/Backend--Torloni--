
using System.Diagnostics.CodeAnalysis;
using Exercicio02;



Funcionario f1 = new Funcionario();
f1.Nome = "Matheus";
f1.SalarioBase = 3000;
f1.ExibirFuncionario();

System.Console.WriteLine("");

Gerente g1 = new Gerente();
g1.Nome = "João";
g1.SalarioBase = 5000;
g1.Bonus = 2000;
g1.ExibirGerente();
