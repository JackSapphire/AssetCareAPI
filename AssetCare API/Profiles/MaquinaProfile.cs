using AssetCare_API.DTOs;
using AssetCare_API.Models;
using AutoMapper;

namespace AssetCare_API.Profiles;

public class MaquinaProfile : Profile
{
    public MaquinaProfile()
    {
        CreateMap<AddMaquinaDto, Maquina>();
        CreateMap<UpdateMaquinaDto, Maquina>();
        CreateMap<Maquina, GetMaquinaDto>();

    }
}
