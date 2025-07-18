static void converterHoras()
{
    Console.WriteLine(@"
█▀▀ █▀█ █▄░█ █░█ █▀▀ █▀█ █▀ █▀█ █▀█   █▀▄ █▀▀   ▀█▀ █▀▀ █▀▄▀█ █▀█ █▀█
█▄▄ █▄█ █░▀█ ▀▄▀ ██▄ █▀▄ ▄█ █▄█ █▀▄   █▄▀ ██▄   ░█░ ██▄ █░▀░█ █▀▀ █▄█");
    Console.Write("\nEscreva a quantidade de minutos para convertes em horas: ");
    if (int.TryParse(Console.ReadLine(), out int minutosTotal))
    {
        int horas = minutosTotal / 60;
        int minutosRestantes = minutosTotal % 60;
        Console.WriteLine($"\nTempo: {horas} horas e {minutosRestantes} minutos");
    }
    else
    {
        Console.WriteLine("Erro. Por favor escreva um número inteiro para quantidade de minutos.");
        Thread.Sleep(2000);
        Console.Clear();
        converterHoras();
    }
}

converterHoras();