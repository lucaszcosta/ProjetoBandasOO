

class Podcast
{

    private List<Episodio> episodios = new List<Episodio>();

    public Podcast(string host, string nome, int totalEpisodios)
    {
        Host = host;
        Nome = nome;
        TotalEpisodios = totalEpisodios;
    }

    public string Host { get; }
    public string Nome { get; }
    public int TotalEpisodios { get; }


    void AdicionarEpisodio(Episodio episodio)
    {
        episodios.Add(episodio);
    }


    void ExibirDetalhes()
    {

    }


}