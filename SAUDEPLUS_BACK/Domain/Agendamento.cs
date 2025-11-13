namespace SAUDEPLUS_BACK.Domain;
public class Agendamento
{
    public Guid Id { get; set; }
    public string Nome { get; set; }
    public string Email { get; set; }
    public string Telefone { get; set; }
    public Guid TipoConsultaId { get; set; }
    public string PreferenciaHorario { get; set; }
    public string Modalidade { get; set; }
    public string Mensagem { get; set; }
    public string Status { get; set; } = "pendente";
    public DateTime DataCriacao { get; set; }
    public DateTime DataAtualizacao { get; set; }

    public virtual TipoConsulta TipoConsulta { get; set; }
}
