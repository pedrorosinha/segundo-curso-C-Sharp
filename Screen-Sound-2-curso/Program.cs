﻿Musica musica1 = new Musica();

musica1.nome = "Roxanne";
musica1.artista = "The Police";
musica1.duracao = 187;
musica1.EscreveDisponivel(true);

Musica musica2  = new Musica();

musica2.nome = "Vertigo";
musica2.artista = "U2";
musica2.duracao = 186;
musica2.EscreveDisponivel(false);

musica1.ExibirFichaTecnica();
musica2.ExibirFichaTecnica();