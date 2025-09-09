namespace F1.Api.Entities;

public class Resultado
{
    public int ResultadoId { get; set; }  // PK

    // FKs
    public int PilotoId { get; set; }
    public Piloto Piloto { get; set; } = null!;

    public int CorridaId { get; set; }
    public Corrida Corrida { get; set; } = null!;

    // Atributos
    public int Posicao { get; set; }
    public int Pontos { get; set; }
}
