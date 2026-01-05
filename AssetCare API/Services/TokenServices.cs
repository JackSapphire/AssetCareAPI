using AssetCare_API.Models;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace UsuariosAPI.Services;

public class TokenService
{
    private IConfiguration _configuration;

    public TokenService(IConfiguration configuration)
    {
        _configuration = configuration;
    }
    public string GerarToken(Tecnico usuario)
    {
        Claim[] claims = new Claim[]
        {
        new Claim(ClaimTypes.Name, usuario.UserName),
        new Claim(ClaimTypes.NameIdentifier, usuario.Id),
        new Claim("Nome", usuario.Nome),
        new Claim("RegistroProfissional", usuario.RegistroProfissional.ToString()),
        new Claim("Area", usuario.Area),
        new Claim("Formacao", usuario.Formacao),
        new Claim("LoginTimeStamp", DateTime.UtcNow.ToString())
        };

        var key = _configuration["Jwt:Key"];

        if (string.IsNullOrEmpty(key))
            throw new Exception("JWT Key não configurada");

        var chave = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(key));
        var credenciais = new SigningCredentials(chave, SecurityAlgorithms.HmacSha256);

        var token = new JwtSecurityToken(
            issuer: _configuration["Jwt:Issuer"],
            audience: _configuration["Jwt:Audience"],
            claims: claims,
            expires: DateTime.UtcNow.AddMinutes(10),
            signingCredentials: credenciais
        );

        return new JwtSecurityTokenHandler().WriteToken(token);
    }

}