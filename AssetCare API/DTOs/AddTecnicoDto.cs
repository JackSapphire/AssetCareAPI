using System.ComponentModel.DataAnnotations;

namespace AssetCare_API.DTOs;

public class AddTecnicoDto
{
    [Required]
    public string UserName { get; set; } = string.Empty;

    [Required]
    [DataType(DataType.Password)]
    public string Password { get; set; } = string.Empty;

    [Required]
    [Compare("Password")]
    public string RePassword { get; set; } = string.Empty;

    public string Nome { get; set; } = string.Empty;

    public int RegistroProfissional { get; set; }

    public string Area { get; set; } = string.Empty;

    public string Formacao { get; set; } = string.Empty;
}
