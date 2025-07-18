
decimal salarioAtual = 100.32m;
decimal percentualAumento = 1.5m;
decimal novoSalario = salarioAtual + (salarioAtual *  percentualAumento / 100);

Console.WriteLine($"Novo salário: {novoSalario:F2}");