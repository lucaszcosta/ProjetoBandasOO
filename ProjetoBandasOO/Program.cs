
Musica musica1 = new Musica();
musica1.Nome = "In the End";
musica1.Artista = "Linkin park";
musica1.Duracao = 300;
musica1.Disponivel = true;
Console.WriteLine(musica1.Disponivel);


Musica musica2  = new Musica();
musica2.Nome = "Vermillion";
musica2.Artista = "Slipknot";
musica1.Duracao = 400;
musica1.Disponivel = false;


musica1.ExibirFichaTecnica();
musica2.ExibirFichaTecnica();

