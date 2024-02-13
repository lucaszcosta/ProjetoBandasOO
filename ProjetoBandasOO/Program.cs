Album albumTeste = new Album();

albumTeste.Nome = "Survival city";

Musica musica1 = new Musica();
musica1.Nome = "In the End";
musica1.Duracao = 123;

Musica musica2 = new Musica();
musica2.Nome = "Disturbed";
musica2.Duracao = 300;


albumTeste.AdicionarMusica(musica1);
albumTeste.AdicionarMusica(musica2);

albumTeste.ExibirMusicasAlbum();