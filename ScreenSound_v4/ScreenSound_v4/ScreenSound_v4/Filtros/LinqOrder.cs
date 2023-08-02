using ScreenSound_v4.Modelos;
using System.Linq;

namespace ScreenSound_v4.Filtros;

internal class LinqOrder
{
    public static void ExibirListaDeArtistasOrdenados(List<Musica> musicas)
    {
        var artistasOrdenados = musicas.OrderBy(musicas => musicas.Artista).Select(musicas => musicas.Artista).Distinct().ToList();
        Console.WriteLine("Lista de Artistas Ordenados");
        foreach (var artista in artistasOrdenados)
        {
            Console.WriteLine($"- {artista}");
        }

        var artistasOrdenadosDesc = musicas.OrderByDescending(musica => musica.Artista).Select(musica => musica.Artista).Distinct().ToList();
        Console.WriteLine("Lista de Artistas Ordenados Decrecente");
        foreach (var artista in artistasOrdenados)
        {
            Console.WriteLine($"- {artista}");
        }
    }
}
