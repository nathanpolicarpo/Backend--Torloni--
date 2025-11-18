﻿/*
Desenvolva um programa que recebe do usuário, o placar de um jogo de futebol 
(os gols de cada time) e informa se o resultado foi um empate,
 se a vitória foi do primeiro time ou do segundo time.

*/

int time1, time2;

Console.WriteLine("Digite a pontuação do time 1");
time1 = int.Parse(Console.ReadLine());

Console.WriteLine("Digite a pontuação do time 2");
time2 = int.Parse(Console.ReadLine());


if (time1 > time2)
{
    Console.WriteLine("Vitória do time 1");
}

else if (time1 < time2)
{
    Console.WriteLine("Vitória do time 2");
}

else
{
    Console.WriteLine("O jogo terminou empatado");
}