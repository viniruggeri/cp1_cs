namespace F1.Api.Entities;

public class Equipe
{
    public int EquipeId { get; set; }  // PK
    public string Nome { get; set; } = null!;
    public string Pais { get; set; } = null!;
    public int? AnoFundacao { get; set; }

    // Relacionamento 1:N
    public ICollection<Piloto> Pilotos { get; set; } = new List<Piloto>();
}
