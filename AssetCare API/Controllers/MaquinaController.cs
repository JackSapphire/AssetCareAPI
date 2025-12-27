using Microsoft.AspNetCore.Mvc;

namespace AssetCare_API.Controllers;

[Route("[Controller]")]
[ApiController]
public class MaquinaController : ControllerBase
{
    [HttpGet("ListarEquipamentos")]
    public IActionResult ListarEquipamentos()
    {
        // Lógica para listar equipamentos
        throw new NotImplementedException();
    }

    [HttpGet("BuscarEquipamento/{id}")]
    public IActionResult BuscarEquipamento(int id)
    {
        // Lógica para buscar um equipamento por ID
        throw new NotImplementedException();
    }

    [HttpPost("CadastrarEquipamento")]
    public IActionResult CadastrarEquipamento()
    {
        // Lógica para cadastrar um novo equipamento
        throw new NotImplementedException();
    }

    [HttpPut("AlterarEquipamento/{id}")]
    public IActionResult AlterarEquipamento(int id)
    {
        // Lógica para alterar um equipamento existente
        throw new NotImplementedException();
    }

    [HttpDelete("DeletarEquipamento/{id}")]
    public IActionResult DeletarEquipamento(int id)
    {
        // Lógica para deletar um equipamento
        throw new NotImplementedException();
    }
}
