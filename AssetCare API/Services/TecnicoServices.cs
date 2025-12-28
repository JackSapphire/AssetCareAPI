using AssetCare_API.DTOs;
using AssetCare_API.Models;
using AutoMapper;
using Microsoft.AspNetCore.Identity;
using UsuariosAPI.Services;

namespace AssetCare_API.Services;

public class TecnicoServices : ITecnicoServices
{
    private UserManager<Tecnico> _userManager;
    private SignInManager<Tecnico> _signInManager;
    private TokenService _tokenService;
    private IMapper _mapper;

    public TecnicoServices(UserManager<Tecnico> userMaganer, SignInManager<Tecnico> signInManager, TokenService tokenService, IMapper mapper)
    {
        _userManager = userMaganer;
        _signInManager = signInManager;
        _tokenService = tokenService;
        _mapper = mapper;
    }

    public Task<GetTecnicoDto> Alterar(int id, AddTecnicoDto tecnico)
    {
        throw new NotImplementedException();
    }

    public Task<GetTecnicoDto> Buscar(int id)
    {
        throw new NotImplementedException();
    }

    public async Task<GetTecnicoDto> Cadastrar(AddTecnicoDto dto)
    {
        Tecnico NewTecnico = _mapper.Map<Tecnico>(dto);

        IdentityResult Result = await _userManager.CreateAsync(NewTecnico, dto.Password);

        if (!Result.Succeeded)
            throw new Exception("Falha ao cadastrar técnico.");

        return new GetTecnicoDto
        {
            Username = NewTecnico.UserName,
            Nome = NewTecnico.Nome,
            RegistroProfissional = NewTecnico.RegistroProfissional,
            Area = NewTecnico.Area,
            Formacao = NewTecnico.Formacao
        };
    }

public Task<GetTecnicoDto> Deletar(int id)
    {
        throw new NotImplementedException();
    }

    public Task<List<GetTecnicoDto>> Listar()
    {
        throw new NotImplementedException();
    }
}
