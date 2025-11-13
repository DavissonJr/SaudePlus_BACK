namespace SAUDEPLUS_BACK.Domain;

public class TipoConsulta
{
    public Guid Id { get; set; }
    public string Nome { get; set; }
    public string Descricao { get; set; }
    public int DuracaoMinutos { get; set; }
    public bool Ativo { get; set; }
    public DateTime DataCriacao { get; set; }
}
