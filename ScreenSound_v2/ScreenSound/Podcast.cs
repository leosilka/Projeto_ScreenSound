class Podcast
{
    private List<Episodio> episodios = new();
    public Podcast(string nome, string host)
    {
        Nome = nome;
        Host = host;
    }

    public string Nome { get; }
    public string Host { get; }
    public int TotalEpisodio => episodios.Count();

    public void AdicionarEpisodios(Episodio episodio)
    {
        episodios.Add(episodio);
    }

    public void ExibirDetalhes()
    {
        var episodiosOrdenados = episodios.OrderBy(episodios => episodios.Ordem); // aqui estou ordenando em forma crescente os episodios
        Console.WriteLine($"\nPodcast: {Nome} apresentado por {Host}\n");
        foreach(var episodio in episodiosOrdenados)
        {
            Console.WriteLine($"{episodio.Ordem} - Episodio: {episodio.Titulo} ({episodio.Duracao} min).");
        }
        Console.WriteLine($"Total de Episodios: {TotalEpisodio}");
    }
}