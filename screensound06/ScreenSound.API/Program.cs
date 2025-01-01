using ScreenSound.Modelos;
using ScreenSound.Banco;
using System.Text.Json.Serialization;
using Microsoft.AspNetCore.Mvc;

var builder = WebApplication.CreateBuilder(args);
builder.Services.Configure<Microsoft.AspNetCore.Http.Json.JsonOptions>(options => options.SerializerOptions.ReferenceHandler = ReferenceHandler.IgnoreCycles);
var app = builder.Build();

builder.Services.AddDbContext<ScreenSoundContext>();
builder.Services.AddTransient<DAL<Artista>>();

app.MapGet("/Artistas", ([FromServices] DAL<Artista> dal) =>
{
    return Results.Ok(dal.Listar());
});

app.MapGet("/Artistas/{nome}", ([FromServices] DAL<Artista> dal ,string nome) =>
{
    var artista = dal.RecuperarPor(a => a.Nome.ToUpper().Equals(nome.ToUpper()));
    if (artista is null)
    {
        return Results.NotFound();
    }
    return Results.Ok(artista);
});

//app.MapPost("/Artistas", ([FromServices] DAL<Artista> dal, [FromBody]Artista artista) =>
//{
//    dal.Adicionar(artista);
//    return Results.Ok(artista);
//});

//app.MapDelete("/Artistas/{id}", ([FromServices] DAL<Artista> dal, int id) => 
//{ 
//    var artista = dal.RecuperarPor(a => a.Id == id);
//    if (artista is null) 
//    {
//        return Results.NotFound();
//    }
//    dal.Deletar(artista);
//    return Results.NoContent();
//});

app.Run();
