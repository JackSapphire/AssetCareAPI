using AssetCare_API.DTOs;
using AssetCare_API.Models;
using AssetCare_API.Services;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace AssetCare_API.Controllers;

[Route("[Controller]")]
[ApiController]

public class TecnicoController(ITecnicoServices _tecnicoServices) : ControllerBase
{

    [HttpGet("ListarTecnicos")]
    public async Task<IActionResult> ListarTecnicosAsync()
        => Ok(await _tecnicoServices.Listar());

    [HttpGet("BuscarTecnico/{Nome}")]
    public async Task<IActionResult> BuscarTecnico(string Nome)
    {
        var Tecnico = await _tecnicoServices.Buscar(Nome);
        if(Tecnico == null || !Tecnico.Any())
            return NotFound("Técnico não encontrado.");
        return Ok(Tecnico);
    }

    [HttpPost("CadastrarTecnico")]
    public async Task<IActionResult> CadastrarTecnico(AddTecnicoDto dto)
    {
        return Ok(await _tecnicoServices.Cadastrar(dto));
    }

    [HttpPut("AlterarTecnico/{id}")]
    public async Task<IActionResult> AlterarTecnicoAsync(string id, UpdateTecnicoDto character)
    {
        var result = await _tecnicoServices.Alterar(id, character);
        if(result is null)
            return NotFound("Técnico não encontrado.");
        return Ok(result);
    }

    [HttpDelete("DeletarTecnico/{id}")]
    public async Task<IActionResult> DeletarTecnicoAsync(string id)
    {
        var result = await _tecnicoServices.Deletar(id);
        if(result is null)
            return NotFound("Técnico não encontrado.");

        return Ok(result);
    }
}
