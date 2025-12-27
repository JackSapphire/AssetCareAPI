using System.ComponentModel.DataAnnotations;

namespace AssetCare_API.DTOs;

public class CadastrarTecnicoDto
{
    [Required]
    public string Username { get; set; }

    [Required]
    [DataType(DataType.Password)]
    public string Password { get; set; }

    [Required]
    [Compare("Password")]
    public string RePassword { get; set; }

    public int RegistroProfissional { get; set; }

    public string Area { get; set; } = string.Empty;

    public string Formacao { get; set; } = string.Empty;
}
