using AssetCare_API.DTOs;
using Microsoft.AspNetCore.Mvc;

namespace AssetCare_API.Controllers;

[Route("[Controller]")]
[ApiController]

public class TecnicoController : ControllerBase
{
    [HttpGet("ListarTecnicos")]
    public IActionResult ListarTecnicos()
    {
        // Lógica para listar técnicos
        throw new NotImplementedException();
    }

    [HttpGet("BuscarTecnico/{id}")]
    public IActionResult BuscarTecnico(int id)
    {
        // Lógica para buscar um técnico por ID
        throw new NotImplementedException();
    }

    [HttpPost("CadastrarTecnico")]
    public IActionResult CadastrarTecnico(CadastrarTecnicoDto dto)
    {
        // Lógica para cadastrar um novo técnico
        throw new NotImplementedException();
    }

    [HttpPut("AlterarTecnico/{id}")]
    public IActionResult AlterarTecnico(int id)
    {
        // Lógica para alterar um técnico existente
        throw new NotImplementedException();
    }

    [HttpDelete("DeletarTecnico/{id}")]
    public IActionResult DeletarTecnico(int id)
    {
        // Lógica para deletar um técnico
        throw new NotImplementedException();
    }
}
