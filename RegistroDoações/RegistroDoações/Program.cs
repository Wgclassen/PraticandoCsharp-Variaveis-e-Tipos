using RegistroDoações.Model;

Console.WriteLine(@"
█▀█ █▀▀ █▀▀ █ █▀ ▀█▀ █▀█ █▀█   █▀▄ █▀▀   █▀▄ █▀█ ▄▀█ █▀▀ █▀█ █▀▀ █▀
█▀▄ ██▄ █▄█ █ ▄█ ░█░ █▀▄ █▄█   █▄▀ ██▄   █▄▀ █▄█ █▀█ █▄▄ █▄█ ██▄ ▄█");

Doacao doacao = new(valor: 500, anonima: true, tipoConta: 'P');
Console.WriteLine($"\n{doacao.DetalhesDoacao}");