using System.Dynamic;
using Microsoft.VisualBasic;

// class Musica
// {
//     public string nome = "";
//     public int duracao = 0;
//     public string conjunto = "";
//     public Dictionary<string, string> artistas = new Dictionary<string, string>();
//     // public Dictionary<string, string> Artistas { get; set; }
//     public bool Disponivel { get; set; }
//     public string DescricaoResumida => $"A musica {nome} pertence ao conjunto {conjunto} e tem duração de {duracao} segundos";
// }

class Musica
{
    public Musica(Banda artista, string nome)
    {
        Artista = artista;
        Nome = nome;

    }
    public string Nome { get; }
    public Banda Artista { get; }
    public int Duracao { get; set; }
    public bool Disponivel { get; set; }
    public string DescricaoResumida =>
        $"A música {Nome} pertence à banda {Artista}";




    public void ExibirFichaTecnica()
    {
        Console.WriteLine($"Nome: {Nome}");
        Console.WriteLine($"Artista: {Artista.Nome}");
        Console.WriteLine($"Duração: {Duracao}");
        if (Disponivel)
        {
            Console.WriteLine("Disponível no plano.");
        }
        else
        {
            Console.WriteLine("Adquira o plano Plus+");
        }
    }
}