using AssetCare_API.DTOs;

namespace AssetCare_API.Services;

public interface IMaquinaService
{
    Task<List<GetMaquinaDto>> Listar();
    Task<List<GetMaquinaDto>> BuscarNome(string Nome);
    Task<GetMaquinaDto> BuscarID(int Id);
    Task<GetMaquinaDto> Cadastrar(AddMaquinaDto maquina);
    Task<GetMaquinaDto> Alterar(int Id, UpdateMaquinaDto maquina);
    Task<GetMaquinaDto> Deletar(int Id);
}
