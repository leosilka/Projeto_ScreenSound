namespace ScreenSound.Modelos;

internal class Banda : IAvaliavel
{
    // Ambas as listas receberam o tipo de suas respectivas classes
    private List<Album> albuns = new List<Album>(); 
    private List<Avaliacao> notas = new List<Avaliacao>();

    public Banda(string nome) //construtor, usado para definir e inicializar os objetos
    {
        Nome = nome;
    }

    public string Nome { get; }
    public double Media // propriedade Media do tipo double
    {
        get
        {
            if (notas.Count == 0) return 0; // se a nota for vazia retorna 0
            else return notas.Average(a => a.Nota); // se houver nota retorna a media
        }
    }

    public string? Resumo { get; set; }
    public List<Album> Albuns => albuns; // propriedade Albuns que retorna a lista albuns, propriedade do tipo List<>

    public void AdicionarAlbum(Album album) 
    { 
        albuns.Add(album);
    }

    public void AdicionarNota(Avaliacao nota)
    {
        notas.Add(nota);
    }

    public void ExibirDiscografia()
    {
        Console.WriteLine($"Discografia da banda {Nome}");
        foreach (Album album in albuns)
        {
            Console.WriteLine($"Álbum: {album.Nome} ({album.DuracaoTotal})");
        }
    }
}