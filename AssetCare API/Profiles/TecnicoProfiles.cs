using AssetCare_API.DTOs;
using AssetCare_API.Models;
using AutoMapper;

namespace UsuariosAPI.Profiles;

public class TecnicoProfile : Profile
{
    public TecnicoProfile()
    {
        CreateMap<AddTecnicoDto, Tecnico>();
        CreateMap<UpdateTecnicoDto, Tecnico>();
        CreateMap<Tecnico, GetTecnicoDto>();
    }
}
