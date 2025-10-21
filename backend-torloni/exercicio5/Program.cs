Console.Write("Digite o número de maçãs compradas: ");
        int quantidade = int.Parse(Console.ReadLine());

        double preco;

        // Verifica se foram compradas pelo menos 12 maçãs
        if (quantidade >= 12)
        {
            preco = 0.25;
        }
        else
        {
            preco = 0.30;
        }

        // Calcula o valor total
       	 double total = quantidade * preco;

        // Exibe o resultado
        Console.WriteLine($"O valor total da compra é: R$ {total:F2}");