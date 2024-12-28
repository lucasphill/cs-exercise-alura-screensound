using System.Text.Json.Serialization;

namespace screensound04.Models;

internal class Musica
{
    private string[] tonalidades = { "C", "C#", "D", "Eb", "E", "F", "F#", "G", "Ab", "A", "Bb", "B" };
    /* artista / nome / duração / genero*/
    [JsonPropertyName("song")] //atributo que referencia metadado para a propriedade nome
    public string? Nome { get; set; }
    [JsonPropertyName("artist")]
    public string? Artista { get; set; }
    [JsonPropertyName("duration_ms")]
    public int? Duracao { get; set; }
    [JsonPropertyName("genre")]
    public string? Genero { get; set; }
    [JsonPropertyName("year")]
    public string? AnoString { get; set; }
    public int Ano
    {
        get
        {
            return int.Parse(AnoString!);
        }
    }
    [JsonPropertyName("key")]
    public int KeyInt { get; set; }
    public string KeyList
    {
        get
        {
            return tonalidades[KeyInt];
        }
    }
    public string KeySwitch
    {
        get
        {
            switch (KeyInt)
            {
                case 0: return "C";
                case 1: return "C#";
                case 2: return "D";
                case 3: return "D#";
                case 4: return "E";
                case 5: return "F";
                case 6: return "F#";
                case 7: return "G";
                case 8: return "G#";
                case 9: return "A";
                case 10: return "A#";
                case 11: return "B";
                default: return "erro";
            }
        }
    }

    public void ExibirDetalhesMusica()
    {
        Console.WriteLine($"Artista: {Artista}");
        Console.WriteLine($"Nome: {Nome}");
        Console.WriteLine($"Duração: {Duracao/1000}s");
        Console.WriteLine($"Gênero Musical: {Genero}");
        Console.WriteLine($"Ano de lançamento: {Ano}");
        Console.WriteLine($"Tom: {KeyList}");
        Console.WriteLine("");
    }
}
