using AssetCare_API.DTOs;

namespace AssetCare_API.Services;

public interface ITecnicoServices
{
    Task<List<GetTecnicoDto>> Listar();
    Task<List<GetTecnicoDto>> Buscar(string Nome);
    Task<GetTecnicoDto> Cadastrar(AddTecnicoDto tecnico);
    Task<GetTecnicoDto> Alterar(string id, UpdateTecnicoDto tecnico);
    Task<GetTecnicoDto> Deletar(string id);
}
