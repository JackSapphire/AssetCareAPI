using System.ComponentModel.DataAnnotations;

namespace AssetCare_API.DTOs;

public class GetManutencaoDto
{
    public int Id { get; set; }
    public int MaquinaId { get; set; }
    public string TecnicoId { get; set; } = string.Empty;
    public DateTime DataAgendada { get; set; }
    public DateTime? DataExecucao { get; set; }
    public string Descricao { get; set; } = string.Empty;
    public string Status { get; set; } = string.Empty;
}
