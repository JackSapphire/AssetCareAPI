using System.ComponentModel.DataAnnotations;

namespace AssetCare_API.DTOs;

public class AddMaquinaDto
{
    [Required]
    public string Nome { get; set; } = string.Empty;
    public string Tipo { get; set; } = string.Empty;
    public string Fabricante { get; set; } = string.Empty;
    public DateTime DataCompra { get; set; }
    public string Status { get; set; } = string.Empty;

}
