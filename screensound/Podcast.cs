class Podcast
{
    public Podcast(string nome, string host)
    {
        Host = host;
        Nome = nome;
    }

    private List<Episodio> episodios = [];
    public string Host { get; }
    public string Nome { get; }
    public int TotalEpisodios => episodios.Count();

    public void AdicionarEpisodio(Episodio episodio)
    {
        episodios.Add(episodio);
    }

    public void ExibirDetalhes()
    {
        Console.WriteLine($"Nome do podcast: {Nome} hosteado por {Host} e possui {TotalEpisodios} episodios");
        foreach(Episodio episodio in episodios.OrderBy(e => e.Ordem))
        {
            Console.WriteLine(episodio.Resumo);
        }
    }
}