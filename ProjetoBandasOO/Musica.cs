
class Musica
{


    public Musica(Banda artista, string nome)
    {
        Artista = artista;
        Nome = nome;
    }

    public string Nome { get; set; }
    public Banda Artista { get; }
    public int Duracao { get; set; }

    public TimeSpan duracaoSpan = new TimeSpan();



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
        Console.WriteLine($"Nome do artista: {Artista.Nome}");
        TimeSpan duracaoSpan = TimeSpan.FromSeconds(Duracao);
        Console.WriteLine($"Duração da musica: {duracaoSpan}");
        if (Disponivel)
        {
            Console.WriteLine("Disponivel no plano atual");
        }
        else
        {
            Console.WriteLine("Não disponivel no plano atual.\nAdquira o plano Plus+");
        }

    }

}