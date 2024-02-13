
Musica musica1 = new Musica();
musica1.nome = "In the End";
musica1.artista = "Linkin park";
musica1.duracao = 300;
musica1.Disponivel = true;
Console.WriteLine(musica1.Disponivel);


Musica musica2  = new Musica();
musica2.nome = "Vermillion";
musica2.artista = "Slipknot";
musica1.duracao = 400;
musica1.Disponivel = false;


musica1.ExibirFichaTecnica();
musica2.ExibirFichaTecnica();