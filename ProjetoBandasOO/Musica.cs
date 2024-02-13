
class Musica
{
    public string nome;
    public string artista;
    public int duracao;
    private bool disponivel;


    public void EscreveDisponivel(bool value)
    {
        disponivel = value;
    }

    public void LeituraDisponivel(bool value)
    {
        disponivel = value;
    }

    public void ExibirFichaTecnica()
    {
        Console.WriteLine($"Nome da musica: {nome}");
        Console.WriteLine($"Nome do artista: {artista}");
        Console.WriteLine($"Duração da musica: {duracao}");
        if (disponivel)
        {
            Console.WriteLine("Disponivel no plano atual");
        }
        else
        {
            Console.WriteLine("Não disponivel no plano atual.\nAdquira o plano Plus+");
        }

    }

    public void ExibirNomeEArtista()
    {
        Console.WriteLine($"{artista} - {nome}");
    }

}