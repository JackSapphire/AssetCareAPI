using Microsoft.AspNetCore.Identity;

namespace AssetCare_API.Models;

public class Tecnico : IdentityUser
{
    public Tecnico() : base()
    {

    }
    public int RegistroProfissional { get; set; }
    public string Area { get; set; } = string.Empty;
    public string Formacao { get; set; } = string.Empty;
}
