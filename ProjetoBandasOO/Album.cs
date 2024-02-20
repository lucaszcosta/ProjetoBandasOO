class Album
{

    public Album(string nome)
    {
        Nome = nome;
    }

    private List<Musica> musicas = new List<Musica>();



    public string Nome { get; set; }
    //public int DuracaoTotal => musicas.Sum(m => m.Duracao);
    public TimeSpan DuracaoTotal => TimeSpan.FromSeconds(musicas.Sum(m => m.Duracao));

    public void AdicionarMusica(Musica musica)
    {
        musicas.Add(musica);
    }

    public void ExibirMusicasAlbum()
    {
        Console.WriteLine($"\nLista de musicas do album {Nome}:\n");
        foreach (var musica in musicas)
        {
            Console.WriteLine($"Musica: {musica.Nome}");
        }


        Console.WriteLine($"Duracao total do album: {DuracaoTotal}");
    }
}