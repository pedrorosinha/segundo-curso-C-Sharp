﻿Musica musica1 = new Musica();

musica1.Nome = "Roxanne";
musica1.Artista = "The Police";
musica1.Duracao = 187;
musica1.Disponivel = true;
Console.WriteLine(musica1.DescricaoResumida);

Musica musica2  = new Musica();

musica2.Nome = "Vertigo";
musica2.Artista = "U2";
musica2.Duracao = 186;
musica2.Disponivel = false;

musica1.ExibirFichaTecnica();
musica2.ExibirFichaTecnica();