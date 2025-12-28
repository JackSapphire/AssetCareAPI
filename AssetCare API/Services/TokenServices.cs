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
            new Claim("Username", usuario.UserName),
            new Claim("Id", usuario.Id),
            new Claim("Nome", usuario.Nome),
            new Claim("RegistroProfissional", usuario.RegistroProfissional.ToString()),
            new Claim("Area", usuario.Area),
            new Claim("Formacao", usuario.Formacao),
            new Claim("LoginTimeStamp", DateTime.UtcNow.ToString())
        };

        var chave = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_configuration["SymmetricSecurityKey"]));  //Chave totalmente aleatória

        var SignInCredentials = new SigningCredentials(chave, SecurityAlgorithms.HmacSha256);

        var Token = new JwtSecurityToken
            (
            expires: DateTime.Now.AddMinutes(10),
            claims: claims,
            signingCredentials: SignInCredentials
            );

        return new JwtSecurityTokenHandler().WriteToken(Token);
    }
}