using System.ComponentModel.DataAnnotations;

namespace AssetCare_API.DTOs;

public class LoginTecnicoDto
{
    [Required]
    public string Username { get; set; } = string.Empty;

    [Required]
    public string Password { get; set; } = string.Empty;
}
