using AssetCare_API.DTOs;

namespace AssetCare_API.Services;

public interface IManutencaoService
{
    Task<List<GetManutencaoDto>> Listar();
    Task<GetManutencaoDto> Buscar_Id(int Id);
    Task<List<GetManutencaoDto>> Buscar_Maquina(int MaquinaId);
    Task<List<GetManutencaoDto>> Buscar_Tecnico(string TecnicoId);
    Task<GetManutencaoDto> Cadastrar(AddManutencaoDto dto);
    Task<GetManutencaoDto> Alterar(int Id, UpdateManutencaoDto dto);
    Task<GetManutencaoDto> Deletar(int Id);
}
