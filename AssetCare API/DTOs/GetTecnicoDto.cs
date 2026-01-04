namespace AssetCare_API.DTOs;

public class GetTecnicoDto
{
    public string Id { get; set; } = string.Empty;
    public string Username { get; set; } = string.Empty;
    public string Nome { get; set; } = string.Empty;
    public int RegistroProfissional { get; set; }
    public string Area { get; set; } = string.Empty;
    public string Formacao { get; set; } = string.Empty;

}
