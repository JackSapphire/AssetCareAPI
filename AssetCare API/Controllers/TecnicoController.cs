using AssetCare_API.DTOs;
using AssetCare_API.Services;
using Microsoft.AspNetCore.Mvc;

namespace AssetCare_API.Controllers;

[Route("[Controller]")]
[ApiController]

public class TecnicoController(ITecnicoServices _tecnicoServices) : ControllerBase
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
    public async Task<IActionResult> CadastrarTecnico(AddTecnicoDto dto)
    {
        return Ok(await _tecnicoServices.Cadastrar(dto));
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
