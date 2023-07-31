// Na interface e feito para garantir que determindas funções seja executadas

using System.Diagnostics.Metrics;

namespace ScreenSound.Modelos;

internal interface IAvaliavel
{
    void AdicionarNota(Avaliacao nota); // Método para adicionar uma nota à avaliação
    double Media { get; } // Propriedade para obter a média das notas da avaliação
}
