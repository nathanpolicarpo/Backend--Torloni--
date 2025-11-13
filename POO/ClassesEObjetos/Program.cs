using ClassesEObjetos;

Pessoa joao = new Pessoa();

joao.Nome = "joão Silva";

Console.WriteLine($"{joao.Nome} tem {joao.Idade} anos");

joao.Envelhecer(17);

Console.WriteLine($"{joao.Nome} tem {joao.Idade} anos");

