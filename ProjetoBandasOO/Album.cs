

using System.ComponentModel;

class Album
{
    private List<Musica> musicas = new List<Musica>();
    private TimeSpan duracaoSpan;


    public string Nome { get; set; }
    //public int DuracaoTotal => musicas.Sum(m => m.Duracao);

    public int DuracaoTotal => musicas.Sum(m => m.Duracao);
    public void AdicionarMusica(Musica musica)
    {
        musicas.Add(musica);
    }

    public void ExibirMusicasAlbum()
    {
        Console.WriteLine($"Lista de musicas do album {Nome}:\n");
        foreach (var musica in musicas)
        {
            Console.WriteLine($"Musica: {musica.Nome}");
        }

        /*
TimeSpan teste = TimeSpan.FromSeconds(300);

string testeconvert = teste.ToString(@"hh\:mm\:ss");

Console.WriteLine(testeconvert);*/
        Console.WriteLine($"Duracao total do album: {DuracaoTotal}");
    }
}