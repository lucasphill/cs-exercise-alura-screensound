using screensound04.Models;

namespace screensound04.Filtros;
internal class LinqFilter
{
    public static void FiltrarTodosOsGeneros(List<Musica> musicas)
    {
        var todosGenerosMusicas = musicas.Select(generos => generos.Genero).Distinct().ToList();
        foreach(var genero in todosGenerosMusicas)
        {
            Console.WriteLine(genero);
        }
    }

    public static void FiltrarArtistasPorGenero(List<Musica> musicas, string genero)
    {
        var artistasPorGenero = musicas.Where(musica => musica.Genero!.Contains(genero)).Select(musica => musica.Artista).Distinct().ToList();
        foreach(var artista in artistasPorGenero)
        {
            Console.WriteLine(artista);
        }
    }

    public static void FiltrarMusicasPorArtista(List<Musica> musicas, string artista)
    {
        var musicasPorArtista = musicas.Where(musica => musica.Artista!.Equals(artista)).ToList();
        foreach(var musica in musicasPorArtista)
        {
            musica.ExibirDetalhesMusica();
        }
    }

    public static void FiltrarMusicasPorAno(List<Musica> musicas, int ano)
    {
        var musicasPorAno = musicas.Where(musica => musica.Ano!.Equals(ano)).ToList();
        foreach(var musica in musicasPorAno)
        {
            musica.ExibirDetalhesMusica();
        }
    }

    public static void FiltrarMusicasPorTom(List<Musica> musicas, int key)
    {
        var musicasPorTom = musicas.Where(musica => musica.KeyInt.Equals(key)).ToList();
        foreach(var musica in musicasPorTom)
        {
            musica.ExibirDetalhesMusica();
        }
    }
}
