class Musica
{
    // para poder usar em outro arquivo, precisa estar como public
    // get e set permite e informa que possui leitura e escrita
    // get e leitura
    // set e escrita
    public Musica(Banda artista, string nome)
    {
        Artista = artista;
        Nome = nome;
    }

    public string Nome { get; }
    public Banda Artista { get; }
    public int Duracao { get; set; }
    public bool Disponivel { get; set; }
    public string DescricaoResumida => $"A musica {Nome} pertence a banda {Artista}."; // aqui usamos a lambda pois existe apenas o metodo get aqui

    public void ExibirFichaTecnica()
    {
        Console.WriteLine($"Nome: {Nome}");
        Console.WriteLine($"Artista: {Artista.Nome}");
        Console.WriteLine($"Duracao: {Duracao}");
        if (Disponivel)
        {
            Console.WriteLine("Disponivel no plano.\n");
        } else 
        {
            Console.WriteLine("Adquira o plano plus.\n");
        }
    }
}