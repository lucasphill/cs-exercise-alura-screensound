using screensound04.Models;

namespace screensound04.Filtros;

internal class LinqOrder
{
    public static void OrdenarTodosOsArtistas(List<Musica> musicas)
    {
        var artistasOrdenados = musicas.OrderBy(musica => musica.Artista).Select(musica => musica.Artista).Distinct().ToList();
        foreach(var artistas in artistasOrdenados)
        {
            Console.WriteLine(artistas);
        }
    }
}
