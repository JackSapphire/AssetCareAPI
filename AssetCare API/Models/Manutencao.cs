namespace AssetCare_API.Models;

public class Manutencao
{
    public int Id { get; set; }
    public int EquipmentoId { get; set; }
    public int TecnicoId { get; set; }
    public DateTime DataAgendada { get; set; }
    public DateTime? DataExecucao { get; set; }
    public string Descricao { get; set; } = string.Empty;
    public string Status { get; set; } = string.Empty;
}
