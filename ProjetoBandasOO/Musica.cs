
class Musica
{
    public string Nome { get; set; }
    public string Artista { get; set; }
    //public int Duracao { get; set; }

    public TimeSpan Duracao { get; set; }
    /*
TimeSpan teste = TimeSpan.FromSeconds(300);
    
string testeconvert = teste.ToString(@"hh\:mm\:ss");

Console.WriteLine(testeconvert);*/

    
    public bool Disponivel { get; set; }

    public Genero Genero { get; set; }

    public string DescricaoResumida =>
        $"A musica {Nome} pertence a banda {Artista}";

    public void ExibirFichaTecnica()
    {
        Console.WriteLine($"Nome da musica: {Nome}");
        Console.WriteLine($"Nome do artista: {Artista}");
        Console.WriteLine($"Duração da musica: {Duracao}");
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
        Console.WriteLine($"{Artista} - {Nome}");
    }

}