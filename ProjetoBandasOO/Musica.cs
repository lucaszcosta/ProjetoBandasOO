
class Musica
{
    public string nome;
    public string artista;
    public int duracao;
    public bool Disponivel { get; set; }


    public void ExibirFichaTecnica()
    {
        Console.WriteLine($"Nome da musica: {nome}");
        Console.WriteLine($"Nome do artista: {artista}");
        Console.WriteLine($"Duração da musica: {duracao}");
        if (Disponivel)
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