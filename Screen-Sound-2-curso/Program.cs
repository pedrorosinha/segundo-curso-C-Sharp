﻿//Musica musica1 = new Musica();

//musica1.Nome = "Roxanne";
//musica1.Artista = "The Police";
//musica1.Duracao = 187;
//musica1.Disponivel = true;
//Console.WriteLine(musica1.DescricaoResumida);

//Musica musica2  = new Musica();

//musica2.Nome = "Vertigo";
//musica2.Artista = "U2";
//musica2.Duracao = 186;
//musica2.Disponivel = false;

//musica1.ExibirFichaTecnica();
//musica2.ExibirFichaTecnica();

Album albumDoQueen = new Album();
albumDoQueen.Nome = "A night at the opera";

Musica musica1 = new Musica();
musica1.Nome = "Love of my Life";
musica1.Duracao = 213;

Musica musica2 = new Musica();
musica2.Nome = "Bohemian Rhapsody";
musica2.Duracao = 354;

albumDoQueen.AdicionarMusica(musica1);
albumDoQueen.AdicionarMusica(musica2);

//albumDoQueen.ExibirMusicasDoAlbum();

Banda queen = new Banda();
queen.Nome = "Queen";
queen.AdicionarAlbum(albumDoQueen);
queen.ExibirDiscografia();