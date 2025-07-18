Console.WriteLine(@"
███╗░░░███╗███████╗██████╗░██╗░█████╗░  ██████╗░███████╗  ███╗░░██╗░█████╗░████████╗░█████╗░░██████╗
████╗░████║██╔════╝██╔══██╗██║██╔══██╗  ██╔══██╗██╔════╝  ████╗░██║██╔══██╗╚══██╔══╝██╔══██╗██╔════╝
██╔████╔██║█████╗░░██║░░██║██║███████║  ██║░░██║█████╗░░  ██╔██╗██║██║░░██║░░░██║░░░███████║╚█████╗░
██║╚██╔╝██║██╔══╝░░██║░░██║██║██╔══██║  ██║░░██║██╔══╝░░  ██║╚████║██║░░██║░░░██║░░░██╔══██║░╚═══██╗
██║░╚═╝░██║███████╗██████╔╝██║██║░░██║  ██████╔╝███████╗  ██║░╚███║╚█████╔╝░░░██║░░░██║░░██║██████╔╝
╚═╝░░░░░╚═╝╚══════╝╚═════╝░╚═╝╚═╝░░╚═╝  ╚═════╝░╚══════╝  ╚═╝░░╚══╝░╚════╝░░░░╚═╝░░░╚═╝░░╚═╝╚═════╝░");

calculaMedia();

void calculaMedia()
{
    float nota1 = escreveNota(1);
    float nota2 = escreveNota(2);
    float nota3 = escreveNota(3);
    float mediaNotas = (nota1 + nota2 + nota3) / 3;
    Console.WriteLine($"\nNOTAS:");
    Console.WriteLine($"\n1o Trimestre: {nota1:F1}");
    Console.WriteLine($"2o Trimestre: {nota2:F1}");
    Console.WriteLine($"3o Trimestre: {nota3:F1}");
    Console.WriteLine($"\nA média das notas é: {mediaNotas:F1}");
}

float escreveNota(int trimestre)
{
    float nota;
    while (true)
    {
        Console.Write($"\nEscreva a nota do {trimestre}o trimestre: ");
        if (float.TryParse(Console.ReadLine(), out nota))
        {
            if (nota >= 0 && nota <= 10)
            {
                Console.WriteLine($"\n{trimestre}o trimestre: {nota:F1}");
                return nota;
            }
            else
            {
                Console.WriteLine("\nErro. A nota deve ser entre 0 e 10. Tente novamente.");
            }
            
        }
        else
        {
            Console.WriteLine($"\nErro. Por favor escreva um número de 0 a 10 para a nota do {trimestre}o trimestre.");
        }
    }
}
