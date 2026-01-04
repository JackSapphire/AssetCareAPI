using AssetCare_API.DTOs;
using AssetCare_API.Models;
using AssetCare_API.Services;
using Microsoft.AspNetCore.Mvc;

namespace AssetCare_API.Controllers;

[Route("[Controller]")]
[ApiController]
public class ManutencaoController(IManutencaoService _manutencaoServices) : ControllerBase
{

    [HttpGet("ListarManutencoes")]
    public async Task<IActionResult> ListarManutencoesAsync()
        => Ok(await _manutencaoServices.Listar());

    [HttpGet("BuscarManutencaoPorId/{Id}")]
    public async Task<IActionResult> BuscarManutencaoPorIdAsync(int Id)
    {
        var Manutencao = await _manutencaoServices.Buscar_Id(Id);
        if (Manutencao == null)
            return NotFound("Máquina não encontrada.");
        return Ok(Manutencao);
    }

    [HttpGet("BuscarManutencaoPorTecnicoId/{TecnicoId}")]
    public async Task<IActionResult> BuscarManutencaoPorTecnicoIdAsync(string TecnicoId)
    {
        var Manutencao = await _manutencaoServices.Buscar_Tecnico(TecnicoId);
        if (Manutencao == null)
            return NotFound("Máquina não encontrada.");
        return Ok(Manutencao);
    }

    [HttpGet("BuscarManutencaoPorMaquinaId/{MaquinaId}")]
    public async Task<IActionResult> BuscarManutencaoPorMaquinaIdAsync(int MaquinaId)
    {
        var Manutencao = await _manutencaoServices.Buscar_Maquina(MaquinaId);
        if (Manutencao == null)
            return NotFound("Manutenção não encontrada.");
        return Ok(Manutencao);
    }

    [HttpPost("CadastrarManutencao")]
    public async Task<IActionResult> CadastrarManutencaoAsync(AddManutencaoDto dto)
        => Ok(await _manutencaoServices.Cadastrar(dto));

    [HttpPut("AlterarManutencao/{Id}")]
    public async Task<IActionResult> AlterarManutencaoAsync(int Id, UpdateManutencaoDto dto)
    {
        var result = await _manutencaoServices.Alterar(Id, dto);
        if (result is null)
            return NotFound("Manutenção não encontrada.");
        return Ok(result);
    }

    [HttpDelete("DeletarManutencao/{Id}")]
    public async Task<IActionResult> DeletarManutencaoAsync(int Id)
    {
        var result = await _manutencaoServices.Deletar(Id);
        if (result is null)
            return NotFound("Manutenção não encontrada.");

        return Ok(result);
    }

}
