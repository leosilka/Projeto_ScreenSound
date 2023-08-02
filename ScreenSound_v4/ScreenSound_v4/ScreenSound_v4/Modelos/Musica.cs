using System.Text.Json.Serialization;

namespace ScreenSound_v4.Modelos;

internal class Musica
{
    [JsonPropertyName("song")] // Usamos JsonPropertyName para que ele possa ser renomeado para a propriedade que escolhemos para ele
    public string? Nome { get; set; }

    [JsonPropertyName("artist")]
    public string? Artista { get; set; }

    [JsonPropertyName("duration_ms")]
    public int Duracao { get; set; }

    [JsonPropertyName("genre")]
    public string? Genero { get; set; }

    [JsonPropertyName("year")]
    public string? AnoString { get; set; }

    public int Ano 
    { 
        get
        {
            return int.Parse(AnoString!);
        }
    }

    [JsonPropertyName("key")]
    public int Chave { get; set; }

    public void ExibirDetalhesDaMusica()
    {
        Console.WriteLine($"Artista: {Artista}");
        Console.WriteLine($"Musica: {Nome}");
        Console.WriteLine($"Duração em segundos: {Duracao /1000}");
        Console.WriteLine($"Gênero musical: {Genero}");
        Console.WriteLine($"Ano: {Ano}");
        Console.WriteLine($"Chave: {Chave}");
    }
}
