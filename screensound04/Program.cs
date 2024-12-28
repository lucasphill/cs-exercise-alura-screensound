using System.Text.Json;
using screensound04.Models;
using screensound04.Filtros;

using (HttpClient client = new HttpClient())
{
    try
    {
        string response = await client.GetStringAsync("https://guilhermeonrails.github.io/api-csharp-songs/songs.json");
        
        var musicas = JsonSerializer.Deserialize<List<Musica>>(response)!;

        //LinqFilter.FiltrarTodosOsGeneros(musicas);
        //LinqOrder.OrdenarTodosOsArtistas(musicas);
        //LinqFilter.FiltrarArtistasPorGenero(musicas, "rock");
        //LinqFilter.FiltrarMusicasPorArtista(musicas, "Billie Eilish");
        //LinqFilter.FiltrarMusicasPorAno(musicas, 2012);
        LinqFilter.FiltrarMusicasPorTom(musicas, 1);

        //for (int i = 0; i < musicas.Count; i++)
        //{
        //    musicas[i].ExibirDetalhesMusica();
        //}

        //var listaMusicasPreferidas = new MusicasPreferidas("Lucas");
        //listaMusicasPreferidas.AdicionarMusicasFavoritas(musicas[1]);
        //listaMusicasPreferidas.AdicionarMusicasFavoritas(musicas[871]);
        //listaMusicasPreferidas.AdicionarMusicasFavoritas(musicas[1990]);
        //listaMusicasPreferidas.AdicionarMusicasFavoritas(musicas[1348]);
        //listaMusicasPreferidas.AdicionarMusicasFavoritas(musicas[566]);

        //listaMusicasPreferidas.ExibirMusicasFavoritas();

        //listaMusicasPreferidas.GerarArquivoJson();

    }
    catch (Exception ex)
    {
        Console.WriteLine($"Temos um problema: {ex.Message}");
    }
    
}