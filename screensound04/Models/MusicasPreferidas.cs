using System.Text.Json;

namespace screensound04.Models;

internal class MusicasPreferidas
{
    public string? Nome { get; set; }
    public List<Musica> ListaDeMusicasPreferidas { get; }

    public MusicasPreferidas(string nome)
    {
        Nome = nome;
        ListaDeMusicasPreferidas = [];
    }

    public void AdicionarMusicasFavoritas(Musica musica)
    {
        ListaDeMusicasPreferidas.Add(musica);
    }

    public void ExibirMusicasFavoritas()
    {
        foreach (var musica in ListaDeMusicasPreferidas)
        {
            musica.ExibirDetalhesMusica();
        }
    }

    public void GerarArquivoJson()
    {
        var json = JsonSerializer.Serialize(new
        {
            nome = Nome,
            musicas = ListaDeMusicasPreferidas,
            dataCriacao = DateTime.Now
        });
        string nomeDoArquivo = $"{DateTime.Now:yyyy-MM-dd}-{Nome}.json";
        File.WriteAllText(nomeDoArquivo, json);
        Console.WriteLine($"Json criado com sucesso! {Path.GetFullPath(nomeDoArquivo)}");
    }
}