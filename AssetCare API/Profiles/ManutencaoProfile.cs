using AssetCare_API.DTOs;
using AssetCare_API.Models;
using AutoMapper;

namespace AssetCare_API.Profiles;

public class ManutencaoProfile : Profile
{
    public ManutencaoProfile() 
    {

        CreateMap<AddManutencaoDto, Manutencao>();
        CreateMap<UpdateManutencaoDto, Manutencao>();
        CreateMap<Manutencao, GetManutencaoDto>();
    }
}
