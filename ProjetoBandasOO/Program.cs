/*
int duracao = 123;

TimeSpan teste = TimeSpan.FromSeconds(duracao);

string testeconvert = teste.ToString(@"hh\:mm\:ss");

Console.WriteLine(teste);*/










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
