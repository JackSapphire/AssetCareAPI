using System.ComponentModel.DataAnnotations;

namespace AssetCare_API.DTOs;

public class UpdateTecnicoDto
{
    [Required]
    public string Username { get; set; } = string.Empty;

    public string Nome { get; set; } = string.Empty;

    public int RegistroProfissional { get; set; }

    public string Area { get; set; } = string.Empty;

    public string Formacao { get; set; } = string.Empty;

}
