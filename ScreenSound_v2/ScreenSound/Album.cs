class Album
{
    private List<Musica> musicas = new List<Musica>(); // campo privado, variavel apenas disponivel na classe album

    public Album(string nome)
    {
        Nome = nome;
    }

    public string Nome { get; }
    public int DuracaoTotal => musicas.Sum(m => m.Duracao); // para cada duracao, ira somar a duracao das musicas

    public void AdicionarMusica(Musica musica)
    {
        musicas.Add(musica); // relacao entre album e musica
    }

    public void ExibirMusicasDoAlbum()
    {
        Console.WriteLine($"Lista de musicas do album {Nome}:\n");
        foreach (var musica in musicas)
        {
            Console.WriteLine($"Musica: {musica.Nome}");
        }
        Console.WriteLine($"\nPara ouvir este album inteiro voce precisa de {DuracaoTotal}");
    }
}