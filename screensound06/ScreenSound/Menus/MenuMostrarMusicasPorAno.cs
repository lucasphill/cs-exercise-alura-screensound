using ScreenSound.Banco;
using ScreenSound.Modelos;

namespace ScreenSound.Menus;

internal class MenuMostrarMusicasPorAno : Menu
{
    public override void Executar(DAL<Artista> artistaDAL)
    {
        base.Executar(artistaDAL);
        ExibirTituloDaOpcao("Exibir musicas por ano de lançamento");
        Console.WriteLine("Digite o ano que deseja mostrar as musicas: ");
        string anoDaMusica = Console.ReadLine()!;
        var musicaDAL = new DAL<Musica>(new ScreenSoundContext());
        var listaAnoLancamento = musicaDAL.ListarPor(a => a.AnoLancamento == Convert.ToInt32(anoDaMusica));
        if (listaAnoLancamento.Any())
        {
            Console.WriteLine($"\nMusicas do Ano {anoDaMusica}:");
            foreach (var musica in listaAnoLancamento)
            {
                musica.ExibirFichaTecnica();
            }
            Console.WriteLine("\nDigite uma tecla para voltar ao menu principal");
            Console.ReadKey();
            Console.Clear();
        }
        else
        {
            Console.WriteLine($"\nO ano {anoDaMusica} não foi encontrada!");
            Console.WriteLine("Digite uma tecla para voltar ao menu principal");
            Console.ReadKey();
            Console.Clear();
        }
    }
}
