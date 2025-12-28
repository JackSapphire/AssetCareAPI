using System.ComponentModel.DataAnnotations;

namespace AssetCare_API.DTOs;

public class AddTecnicoDto
{
    [Required]
    public string UserName { get; set; }

    [Required]
    [DataType(DataType.Password)]
    public string Password { get; set; }

    [Required]
    [Compare("Password")]
    public string RePassword { get; set; }

    public string Nome { get; set; }

    public int RegistroProfissional { get; set; }

    public string Area { get; set; } = string.Empty;

    public string Formacao { get; set; } = string.Empty;
}
