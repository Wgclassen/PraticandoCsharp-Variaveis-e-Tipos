Console.WriteLine(@"
█▀▀ ▄▀█ █░░ █▀▀ █░█ █░░ ▄▀█ █▀▄ █▀█ █▀█ ▄▀█   █▀▄ █▀▀   ▄▀█ █▀█ █▀▀ ▄▀█
█▄▄ █▀█ █▄▄ █▄▄ █▄█ █▄▄ █▀█ █▄▀ █▄█ █▀▄ █▀█   █▄▀ ██▄   █▀█ █▀▄ ██▄ █▀█");
calculaArea();
static void calculaArea()
{
    double largura = escreveLargura();
    double comprimento = escreveComprimento();
    Console.WriteLine($"\nLargura: {largura}");
    Console.WriteLine($"Comprimento: {comprimento}");
    double area = largura * comprimento;
    Console.WriteLine($"\nA área do terreno é: {area} metros quadrados.");
}

static double escreveLargura()
{
    double largura;
    while (true)
    {
        Console.Write("\nEscreva a largura do terreno: ");
        if (double.TryParse(Console.ReadLine(), out largura))
        {
            Console.WriteLine($"\nLargura: {largura}");
            return largura;
        }
        else
        {
            Console.WriteLine("\nErro. Por favor escreva um número para a largura do terreno.");
        }
    }
}

static double escreveComprimento()
{
    double comprimento;
    while (true)
    {
        Console.Write("\nEscreva o comprimento do terreno: ");
        if (double.TryParse(Console.ReadLine(), out comprimento))
        {
            return comprimento;
        }
        else
        {
            Console.WriteLine("\nErro. Por favor escreva um número para o comprimento do terreno.");
        }
    }
}