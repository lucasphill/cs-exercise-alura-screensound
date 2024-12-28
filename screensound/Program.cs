Console.Clear();
Episodio ep1 = new(1, "Primeiro episodio", 45);
ep1.AdicionarConvidados("Convidado 1");
ep1.AdicionarConvidados("Convidado 2");
// Console.WriteLine(ep1.Resumo);

Episodio ep2 = new(2, "Segundo episodio", 47);
ep2.AdicionarConvidados("Convidado 1");
ep2.AdicionarConvidados("Convidado 2");
// Console.WriteLine(ep2.Resumo);

Podcast podcast1 = new Podcast("nome do podcast", "host do podcast");
podcast1.AdicionarEpisodio(ep1);
podcast1.AdicionarEpisodio(ep2);
podcast1.ExibirDetalhes();


/*
Console.Clear();

Banda queen = new Banda("Queeeeeeen"); // Criando objeto banda

Album albumDoQueen = new Album("A night at the opera"); // Criando objeto album

Musica musica1 = new Musica(queen, "Love of my life") // Instanciando musica 1 com suas propriedades e atributos
{
    Duracao = 213,
    Disponivel = true
};
Musica musica2 = new Musica(queen, "Bohemian Rhapsody") // Instanciando musica 2 com suas propriedades e atributos
{
    Duracao = 354,
    Disponivel = false
};

albumDoQueen.AdicionarMusica(musica1); // Adicionando musica1 ao album
albumDoQueen.AdicionarMusica(musica2); // Adicionando musica2 ao album
queen.AdicionarAlbum(albumDoQueen); // Adicionando album à banda


queen.ExibirDiscografia(); // Chamando o metodo "Exibir discografia" do objeto queen que é uma instancia de Banda
Console.WriteLine("");
albumDoQueen.ListarMusicas(); // Chamando o metodo "Listar musicas" do objeto albumqueen que é uma instancia da classe album
Console.WriteLine("");
musica1.ExibirFichaTecnica();
musica2.ExibirFichaTecnica();

Podcast podcast1 = new Podcast("nome do podcast", "host do podcast");
podcast1.AdicionarEpisodio();
podcast1.ExibirDetalhes();
*/

// var musica = new Musica();
// musica.nome = "Bad Guy";
// musica.conjunto = "Billie Eilish";
// musica.duracao = 127;
// // musica.disponivel = true;
// musica.artistas.Add("Compositor(es)", "Billie Eilish, Finneas");
// musica.artistas.Add("Produtor(es)", "Finneas");
// musica.artistas.Add("Cantor(es)", "Billie Eilish");

// Console.WriteLine(musica.DescricaoResumida);

// foreach (KeyValuePair<string, string> artista in musica.artistas)
// {
//     Console.WriteLine("{0}: {1}", artista.Key, artista.Value);
// }

// ﻿Musica musica1 = new Musica();
// musica1.Nome = "Roxane";
// musica1.Artista = "The Police";
// musica1.Duracao = 273;
// musica1.Disponivel = true;
// Console.WriteLine(musica1.DescricaoResumida);

// Musica musica2 = new Musica();
// musica2.Nome = "Vertigo";
// musica2.Artista = "U2";
// musica2.Duracao = 367;
// musica2.Disponivel = false;

// musica1.ExibirFichaTecnica();
// musica2.ExibirFichaTecnica();