namespace AssetCare_API.Models;

public class Equipmento
{
    public int Id { get; set; }
    public string Nome { get; set; } = string.Empty;
    public string Tipo { get; set; } = string.Empty;
    public string Fabricante { get; set; } = string.Empty;
    public DateTime DataCompra { get; set; }
    public string Status { get; set; } = string.Empty;
}
