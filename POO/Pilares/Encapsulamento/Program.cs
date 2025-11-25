using Encapsulamento;

// float dinheiro = 200;

// ContaBancaria contaNathan = new ContaBancaria();
// ContaBancaria contaBar = new ContaBancaria(dinheiro);
// contaNathan.Depositar(dinheiro);
// Console.WriteLine($"Saldo de nathan conta: R$:{contaNathan.GetSaldo()}");
// contaBar.sacar(50);
// Console.WriteLine($"Saldo atualizado da conta: R$:{contaNathan.GetSaldo()}");
// Console.WriteLine($"Saldo da conta de Bar: R$:{contaBar.GetSaldo()}");

Carros carro1 = new Carros();
carro1.DefinirMarca("Ferrari");
carro1.DefinirModelo("F40");
carro1.Acelerar(210);
Console.WriteLine($"Marca: {carro1.ObterMarca()}");
Console.WriteLine($"Modelo: {carro1.ObterModelo()}");
Console.WriteLine($"Velocidade Atual: {carro1.ObterVelocidade()} km/h");
carro1.Frear(50);
Console.WriteLine($"Velocidade Atual apos frear: {carro1.ObterVelocidade()} km/h");
carro1.Frear(40);
Console.WriteLine($"Velocidade Atual apos frear novamente: {carro1.ObterVelocidade()} km/h");
