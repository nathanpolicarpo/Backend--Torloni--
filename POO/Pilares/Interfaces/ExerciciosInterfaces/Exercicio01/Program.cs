
// Crie um novo projeto chamado ExerciciosInterface

using Exe3rcicio01;

// Exercício 1
// Crie uma interface chamada IForma com o método CalcularArea.
// Crie duas classes que implementem essa interface: Retangulo e Circulo.
// No programa, peça os valores necessários e exiba a área calculada para cada forma.
// No Retângulo utilizar o cálculo = Largura * Altura;
// No Círculo utilizar o cálculo = PI * Raio * Raio;

Console.Clear();


System.Console.WriteLine("===Bem vindo(a) ao programa CÁLCULOS DE GEOMETRIA===");

System.Console.WriteLine();

System.Console.WriteLine("Vamos cálcular a área do retângulo");

System.Console.Write("Digite a medida da largura do retângulo: ");
float l = float.Parse(Console.ReadLine());

System.Console.WriteLine();

System.Console.Write("Digite a medida da Altura do retângulo: ");
float a = float.Parse(Console.ReadLine());


Retangulo ret = new Retangulo();
ret. Altura = a;
ret.Largura = l;
ret.CalcularArea();


System.Console.WriteLine();
System.Console.WriteLine("Agora vamos calcular a área do círculo...");
System.Console.WriteLine();
System.Console.WriteLine("Informe o raio do círculo: ");
float r = float.Parse(Console.ReadLine());

Circulo cir = new Circulo();
cir.Raio = r;
cir.CalcularArea();
System.Console.WriteLine();
System.Console.WriteLine("Fim do programa...");
