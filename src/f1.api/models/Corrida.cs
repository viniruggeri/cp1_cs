namespace F1.Api.Entities;

public class Corrida
{
    public int CorridaId { get; set; }  // PK
    public string Nome { get; set; } = null!;
    public string Local { get; set; } = null!;
    public DateTime Data { get; set; }

    // Relacionamento N:N
    public ICollection<Resultado> Resultados { get; set; } = new List<Resultado>();
}
