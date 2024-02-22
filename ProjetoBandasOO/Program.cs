/*
int duracao = 123;

TimeSpan teste = TimeSpan.FromSeconds(duracao);

string testeconvert = teste.ToString(@"hh\:mm\:ss");

Console.WriteLine(teste);*/









/*
Banda slipknot = new Banda("Slipknot");



Album albumTeste = new Album("Survival city");


Musica musica1 = new Musica(slipknot, "In the End")
{
    Disponivel = true,
    Duracao = 300
};


Musica musica2 = new Musica(slipknot, "Disturbed")
{
    Duracao = 100,
    Disponivel = false
};


albumTeste.AdicionarMusica(musica1);
albumTeste.AdicionarMusica(musica2);
slipknot.AdicionarAlbum(albumTeste);


musica1.ExibirFichaTecnica();
musica2.ExibirFichaTecnica();
slipknot.ExibirDiscografia();
*/




Episodio ep1 = new (2, "Tecnica1", 452);
Episodio ep2 = new(3, "Tecnica2", 451);
Episodio ep3 = new(1, "Tecnica3", 452);
Episodio ep4 = new(5, "Tecnica4", 453);
Episodio ep5 = new(4, "Tecnica5", 453);
Podcast teste = new("Lucas", "cCast");
teste.AdicionarEpisodio(ep1);
teste.AdicionarEpisodio(ep3);
teste.ExibirDetalhes();

Console.ReadKey();