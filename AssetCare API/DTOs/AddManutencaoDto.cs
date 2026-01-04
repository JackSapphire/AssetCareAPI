using AssetCare_API.Models;
using System.ComponentModel.DataAnnotations;

namespace AssetCare_API.DTOs;

public class AddManutencaoDto
{
    [Required(ErrorMessage = "Informe o ID da máquina")]
    public int MaquinaId { get; set; }
    [Required(ErrorMessage = "Informe o ID do técnico")]
    public string TecnicoId { get; set; } = string.Empty;
    [Required(ErrorMessage = "Informe a data agendada para a manutenção")]
    public DateTime DataAgendada { get; set; }
    public string Descricao { get; set; } = string.Empty;
    public string Status { get; set; } = string.Empty;
}
