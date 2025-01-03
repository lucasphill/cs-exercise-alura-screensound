﻿namespace ScreenSound.Modelos;

public class Musica
{
    public Musica(string nome)
    {
        Nome = nome;
    }

    public string Nome { get; set; }
    public int Id { get; set; }
    public int? AnoLancamento { get; set; }
    public virtual Artista? Artista { get; set; }

    public void ExibirFichaTecnica()
    {
        Console.WriteLine($"Nome: {Nome}");
        Console.WriteLine($"Ano de lançamento: {AnoLancamento}");
        //Console.WriteLine($"Artista: {Artista}");

    }

    public override string ToString()
    {
        return @$"Id: {Id}
        Nome: {Nome}";
    }
}