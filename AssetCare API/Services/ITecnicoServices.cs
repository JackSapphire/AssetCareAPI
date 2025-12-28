using AssetCare_API.DTOs;

namespace AssetCare_API.Services;

public interface ITecnicoServices
{
    Task<List<GetTecnicoDto>> Listar();
    Task<GetTecnicoDto> Buscar(int id);
    Task<GetTecnicoDto> Cadastrar(AddTecnicoDto tecnico);
    Task<GetTecnicoDto> Alterar(int id, AddTecnicoDto tecnico);
    Task<GetTecnicoDto> Deletar(int id);
}
