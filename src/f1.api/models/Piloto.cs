namespace F1.Api.Entities;

public class Piloto
{
    public int PilotoId { get; set; }  // PK
    public string Nome { get; set; } = null!;
    public string Nacionalidade { get; set; } = null!;
    public DateTime? DataNascimento { get; set; }

    // FK
    public int EquipeId { get; set; }
    public Equipe Equipe { get; set; } = null!;

    // Relacionamento N:N
    public ICollection<Resultado> Resultados { get; set; } = new List<Resultado>();
}
