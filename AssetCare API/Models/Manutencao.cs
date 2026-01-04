namespace AssetCare_API.Models;

public class Manutencao
{
    public int MaquinaId { get; set; }
    public virtual Maquina? Maquina { get; set; }
    public string TecnicoId { get; set; } = string.Empty;
    public virtual Tecnico? Tecnico { get; set; }
    public DateTime DataAgendada { get; set; }
    public DateTime? DataExecucao { get; set; }
    public string Descricao { get; set; } = string.Empty;
    public string Status { get; set; } = string.Empty;
}