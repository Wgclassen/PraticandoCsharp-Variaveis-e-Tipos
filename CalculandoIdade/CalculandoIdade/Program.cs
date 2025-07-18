Console.WriteLine(@"
█▀▀ ▄▀█ █░░ █▀▀ █░█ █░░ ▄▀█ █▀▄ █▀█ █▀█ ▄▀█   █▀▄ █▀▀   █ █▀▄ ▄▀█ █▀▄ █▀▀
█▄▄ █▀█ █▄▄ █▄▄ █▄█ █▄▄ █▀█ █▄▀ █▄█ █▀▄ █▀█   █▄▀ ██▄   █ █▄▀ █▀█ █▄▀ ██▄");

int anoAtual = DateTime.Now.Year;

do
{
    Console.Write("\nDigite seu ano de nascimento: ");
    if (int.TryParse(Console.ReadLine(), out int anoNascimento))
    {
        do
        {
            Console.WriteLine("\nVocê já fez aniversário esse ano?");
            Console.WriteLine("\n1- Sim\n2- Não");
            string aniversario = Console.ReadLine()!;
            int idadeAtual = anoAtual - anoNascimento;
            switch (aniversario)
            {
                case "1":
                    Console.WriteLine($"\nSua idade atual é: {idadeAtual}");
                    break;
                case "2":
                    Console.WriteLine($"\nSua idade atual é: {idadeAtual-1}");
                    break;
                default:
                    Console.WriteLine("\nErro. Por favor responda com 1 ou 2.");
                    continue;
            }
            break;
        }
        while (true);
        break;
    }
    else
    {
        Console.WriteLine("\nErro. Por favor digite seu ano de nascimento apenas com números.");
    }
}
while (true);
