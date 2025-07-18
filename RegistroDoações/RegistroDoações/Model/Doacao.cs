namespace RegistroDoações.Model;
internal class Doacao
{
    public Doacao(int valor, bool anonima, char tipoConta)
    {
        Valor = valor;
        Anonima = anonima;
        TipoConta = tipoConta;
    }

    public int Valor { get; }
    public bool Anonima { get; }
    public char TipoConta { get; }
    public string DetalhesDoacao => $"Valor recebido: R${Valor}\nDoação anônima: {Anonima}\nTipo de conta: {TipoConta}";
}
