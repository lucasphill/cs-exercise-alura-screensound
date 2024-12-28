using Microsoft.VisualBasic;

class Banda
{
    private List<Album> albuns = [];
    public Banda(string nome)
    {
        Nome = nome;
    }
    public string Nome { get; }

    public void AdicionarAlbum(Album album)
    {
        albuns.Add(album);
    }

    public void ExibirDiscografia()
    {
        Console.WriteLine($"Exibindo discografia da banda {Nome}");
        foreach (Album album in albuns)
        {
            Console.WriteLine($"Album: {album.Nome} ({album.DuracaoTotal}s)");
        }
    }
}