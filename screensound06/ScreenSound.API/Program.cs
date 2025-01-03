using ScreenSound.Modelos;
using ScreenSound.Banco;
using System.Text.Json.Serialization;
using Microsoft.AspNetCore.Mvc;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDbContext<ScreenSoundContext>();
builder.Services.AddTransient<DAL<Artista>>();
builder.Services.AddTransient<DAL<Musica>>();


builder.Services.Configure<Microsoft.AspNetCore.Http.Json.JsonOptions>(options => options.SerializerOptions.ReferenceHandler = ReferenceHandler.IgnoreCycles);
var app = builder.Build();

app.MapGet("/Artistas", ([FromServices] DAL<Artista> dal) =>
{
    return Results.Ok(dal.Listar());
});

app.MapGet("/Artistas/{nome}", ([FromServices] DAL<Artista> dal, string nome) =>
{
    var artista = dal.RecuperarPor(a => a.Nome.ToUpper().Equals(nome.ToUpper()));
    if (artista is null)
    {
        return Results.NotFound();
    }
    return Results.Ok(artista);
});

app.MapPost("/Artistas", ([FromServices] DAL<Artista> dal, [FromBody] Artista artista) =>
{
    dal.Adicionar(artista);
    return Results.Ok(artista);
});

app.MapDelete("/Artistas/{id}", ([FromServices] DAL<Artista> dal, int id) =>
{
    var artista = dal.RecuperarPor(a => a.Id == id);
    if (artista is null)
    {
        return Results.NotFound();
    }
    dal.Deletar(artista);
    return Results.NoContent();
});

app.MapPut("/Artistas/", ([FromServices] DAL<Artista> dal, [FromBody] Artista artista) =>{
    var artistaAtualiza = dal.RecuperarPor(a => a.Id == artista.Id);
    if(artistaAtualiza is null)
    {
        return Results.NotFound();
    }
    artistaAtualiza.Nome = artista.Nome;
    artistaAtualiza.Bio = artista.Bio;
    artistaAtualiza.FotoPerfil = artista.FotoPerfil;

    dal.Atualizar(artistaAtualiza);
    return Results.Ok(artistaAtualiza);
});

app.MapGet("/Musicas", ([FromServices] DAL<Musica> dal) =>
{
    return Results.Ok(dal.Listar());
});

app.MapGet("/Musicas/{nome}", ([FromServices] DAL<Musica> dal, string nome) =>
{
    var musica = dal.RecuperarPor(a => a.Nome.ToUpper().Equals(nome.ToUpper()));
    if (musica is null)
    {
        return Results.NotFound();
    }
    return Results.Ok(musica);
});

app.MapPost("/Musicas", ([FromServices] DAL<Musica> dal, [FromBody] Musica musica) =>
{
    dal.Adicionar(musica);
    return Results.Ok(musica);
});

app.MapDelete("/Musicas/{id}", ([FromServices] DAL<Musica> dal, int id) =>
{
    var musica = dal.RecuperarPor(a => a.Id == id);
    if (musica is null)
    {
        return Results.NotFound();
    }
    dal.Deletar(musica);
    return Results.NoContent();
});

app.MapPut("/Musicas/", ([FromServices] DAL<Musica> dal, [FromBody] Musica musica) => {
    var musicaAtualiza = dal.RecuperarPor(a => a.Id == musica.Id);
    if (musicaAtualiza is null)
    {
        return Results.NotFound();
    }
    musicaAtualiza.Nome = musica.Nome;
    musicaAtualiza.AnoLancamento = musica.AnoLancamento;

    dal.Atualizar(musicaAtualiza);
    return Results.Ok(musicaAtualiza);
});

app.Run();
