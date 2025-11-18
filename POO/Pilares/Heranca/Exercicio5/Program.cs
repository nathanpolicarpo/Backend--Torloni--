﻿using Exercicio05;

ContaPoupanca cp = new ContaPoupanca();
cp.Numero = 2468;
cp.Depositar(2000);
System.Console.WriteLine($"O saldo da conta do rendimento: R${cp.Saldo}");

System.Console.WriteLine();

cp.CalcularRendimento();
System.Console.WriteLine($"Saldo após o rendimento: R${cp.Saldo}");