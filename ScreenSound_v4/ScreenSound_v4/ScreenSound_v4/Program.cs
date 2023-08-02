using ScreenSound_v4.Modelos;
using System.Text.Json;
using ScreenSound_v4.Filtros;

using (HttpClient client = new HttpClient()) // Aqui criamos uma instância do HttpClient para fazer a requisição
{
    try // Usamos try para tentarmos realizar a primeisa requisão
    {
        // Aqui fazemos a requisição GET para a URL especifica e armazena a resposta em uma string
        // Usamos await para que ele aguarde a conclusão da operação
        string resposta = await client.GetStringAsync("https://guilhermeonrails.github.io/api-csharp-songs/songs.json");
        //Console.WriteLine(resposta); // Aqui imprimimos o resultado da requisição
        var musicas = JsonSerializer.Deserialize<List<Musica>>(resposta)!;
        //LinqFilter.FiltrarTodosOsGenerosMusicais(musicas);
        //LinqOrder.ExibirListaDeArtistasOrdenados(musicas);
        //LinqFilter.FiltrarMusicasDeUmArtista(musicas, "Michel Teló");
        //LinqFilter.FiltrarMusicasPorAno(musicas, 2014);
        LinqFilter.FiltrarMusicasPorTonalidade(musicas, 5);

        //// *** CAMPOS ABAIXO USADO PARA CRIAÇÃO DO ARQUIVO
        ////var musicasPreferidasDoDaniel = new MusicasPreferidas("Daniel");
        ////musicasPreferidasDoDaniel.AdicionarMusicasFavoritas(musicas[10]);
        ////musicasPreferidasDoDaniel.AdicionarMusicasFavoritas(musicas[20]);
        ////musicasPreferidasDoDaniel.AdicionarMusicasFavoritas(musicas[30]);
        ////musicasPreferidasDoDaniel.AdicionarMusicasFavoritas(musicas[40]);
        ////musicasPreferidasDoDaniel.AdicionarMusicasFavoritas(musicas[50]);
        ////musicasPreferidasDoDaniel.ExibirMusicasFavoritas();

        //Console.WriteLine();

        //var musicasPreferidasDoJunior = new MusicasPreferidas("Junior");
        //musicasPreferidasDoJunior.AdicionarMusicasFavoritas(musicas[11]);
        //musicasPreferidasDoJunior.AdicionarMusicasFavoritas(musicas[22]);
        //musicasPreferidasDoJunior.AdicionarMusicasFavoritas(musicas[33]);
        //musicasPreferidasDoJunior.AdicionarMusicasFavoritas(musicas[44]);
        //musicasPreferidasDoJunior.AdicionarMusicasFavoritas(musicas[55]);
        //musicasPreferidasDoJunior.ExibirMusicasFavoritas();

        //musicasPreferidasDoJunior.GerarArquivoJson();
    }
    catch (Exception ex) // Caso try não funcione, tentaremos uma exceção, por isso usamos catch
    {
        Console.WriteLine($"Temos um problema: {ex.Message}");
    }
}