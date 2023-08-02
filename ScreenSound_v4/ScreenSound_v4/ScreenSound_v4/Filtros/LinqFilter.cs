using ScreenSound_v4.Modelos;
using System.Linq;

namespace ScreenSound_v4.Filtros;

internal class LinqFilter
{
    public static void FiltrarTodosOsGenerosMusicais(List<Musica> musicas)
    {
        var todosOsGenerosMusicais = musicas.Select(generos => generos.Genero).Distinct().ToList();
        foreach(var genero in todosOsGenerosMusicais)
        {
            Console.WriteLine($"- {genero}");
        }
    }

    public static void FiltrarArtistasPorGeneroMusical(List<Musica> musicas, string genero)
    {
        var artistasPorGeneroMusical = musicas.Where(musica => musica.Genero.Contains(genero)).Select(musica => musica.Artista).Distinct().ToList();
        Console.WriteLine($"Exibindo os artistas por genero musical {genero}");
        foreach (var artista in artistasPorGeneroMusical)
        {
            Console.WriteLine($"- {artista}");
        }
    }

    public static void FiltrarMusicasDeUmArtista(List<Musica> musicas, string nomeDoArtista)
    {
        var musicasDoArtista = musicas.Where(musica => musica.Artista!.Equals(nomeDoArtista)).ToList();
        Console.WriteLine(nomeDoArtista);
        foreach(var musica in musicasDoArtista)
        {
            Console.WriteLine($"- {musica.Nome}");
        }
    }

    public static void FiltrarMusicasPorAno(List<Musica> musicas, int ano)
    {
        var musicasDoAno = musicas.Where(musica => musica.Ano!.Equals(ano)).OrderBy(musica => musica.Nome).Select(musica => musica.Nome).Distinct().ToList();
        Console.WriteLine($"Musicas de {ano}");
        foreach(var musica in musicasDoAno)
        {
            Console.WriteLine($"- {musica}");
        }
    }

    public static void FiltrarMusicasPorTonalidade(List<Musica> musicas, int chave)
    {
        Dictionary<int, string> tabelaTonalidade = new Dictionary<int, string>
        {
            { 0, "C" },
            { 1, "C#" },
            { 2, "D" },
            { 3, "D#" },
            { 4, "E" },
            { 5, "F" },
            { 6, "F#" },
            { 7, "G" },
            { 8, "G#" },
            { 9, "A" },
            { 10, "A#" },
            { 11, "B" }
        };

        var tonalidadeMusicas = musicas
            .Where(musica => musica.Chave.Equals(chave))
            .OrderBy(musica => musica.Nome)
            .Select(musica => musica.Nome)
            .Distinct()
            .ToList();
        //Console.WriteLine($"Musicas da tonalidade {tabelaTonalidade[chave]}");
        foreach (var musica in tonalidadeMusicas)
        {
            Console.WriteLine($"Música: {musica}");
            Console.WriteLine($"Tonalidade: {tabelaTonalidade[chave]}");
        }
    }    
}
    
