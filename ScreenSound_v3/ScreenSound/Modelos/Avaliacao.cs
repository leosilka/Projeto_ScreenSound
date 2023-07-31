namespace ScreenSound.Modelos;

internal class Avaliacao
{
    public Avaliacao(int nota)
    {
        if (nota < 0) nota = 0;
        if (nota > 10) nota = 10;
        Nota = nota;  
    }
    public int Nota { get; }

    // Usamos metodo estatico para não precisarmos criar uma instancia
    public static Avaliacao Parse(string texto) // Função responsável por converter uma string em um objeto Avaliacao
    {
        int nota = int.Parse(texto);
        return new Avaliacao(nota);
    }
}
