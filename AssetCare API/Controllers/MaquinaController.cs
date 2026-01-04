using AssetCare_API.DTOs;
using AssetCare_API.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace AssetCare_API.Controllers;

[Route("[Controller]")]
[ApiController]
public class MaquinaController(IMaquinaService _maquinaServices) : ControllerBase
{
    [HttpGet("ListarEquipamentos")]
    public async Task<IActionResult> ListarEquipamentosAsync()
        => Ok(await _maquinaServices.Listar());

    [HttpGet("BuscarEquipamentoId/{id}")]
    public async Task<IActionResult> BuscarEquipamentoId(int id)
    {
        var Maquina = await _maquinaServices.BuscarID(id);
        if (Maquina == null)
            return NotFound("Máquina não encontrada.");
        return Ok(Maquina);
    }

    [HttpGet("BuscarEquipamentoNome/{Nome}")]
    public async Task<IActionResult> BuscarEquipamentoNomeAsync(string Nome)
    {
        var Maquina = await _maquinaServices.BuscarNome(Nome);
        if (Maquina == null || !Maquina.Any())
            return NotFound("Máquina não encontrada.");
        return Ok(Maquina);
    }

    [HttpPost("CadastrarEquipamento")]
    public async Task<IActionResult> CadastrarEquipamento(AddMaquinaDto dto)
        => Ok(await _maquinaServices.Cadastrar(dto));

    [HttpPut("AlterarEquipamento/{id}")]
    public async Task<IActionResult> AlterarEquipamento(int id, UpdateMaquinaDto dto)
    {
        var result = await _maquinaServices.Alterar(id, dto);
        if (result is null)
            return NotFound("Máquina não encontrada.");
        return Ok(result);
    }

    [HttpDelete("DeletarEquipamento/{id}")]
    public async Task<IActionResult> DeletarEquipamento(int id)
    {
        var result = await _maquinaServices.Deletar(id);
        if (result is null)
            return NotFound("Máquina não encontrada.");

        return Ok(result);
    }
}
