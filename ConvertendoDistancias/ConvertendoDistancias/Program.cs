static void converteMilhas()
{
    Console.WriteLine(@"
█▀▀ █▀█ █▄░█ █░█ █▀▀ █▀█ █▀ █▀█ █▀█   █▀▄ █▀▀   █▀▄ █ █▀ ▀█▀ ▄▀█ █▄░█ █▀▀ █ ▄▀█ █▀
█▄▄ █▄█ █░▀█ ▀▄▀ ██▄ █▀▄ ▄█ █▄█ █▀▄   █▄▀ ██▄   █▄▀ █ ▄█ ░█░ █▀█ █░▀█ █▄▄ █ █▀█ ▄█");
    Console.Write("\nDigite o valor em milhas que deseja converter para quilometros: ");
    if (double.TryParse(Console.ReadLine(), out double milhas))
    {
        double quilometros = milhas * 1.60934;
        string textoMilhas = "";
        textoMilhas = (milhas == 1) ? "milha equivale" : "milhas equivalem";
        Console.WriteLine($"\n{milhas} {textoMilhas} a {quilometros} quilometros.");
    }
    else
    {
        Console.WriteLine("\nErro, por favor escreva um número de quilometros!");
        Thread.Sleep(2000);
        Console.Clear();
        converteMilhas();
    }
}

converteMilhas();