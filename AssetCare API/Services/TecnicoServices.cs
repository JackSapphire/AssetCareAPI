using AssetCare_API.Data;
using AssetCare_API.DTOs;
using AssetCare_API.Models;
using AutoMapper;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using UsuariosAPI.Services;

namespace AssetCare_API.Services;

public class TecnicoServices : ITecnicoServices
{
    private AppDbContext _context;
    private UserManager<Tecnico> _userManager;
    private SignInManager<Tecnico>? _signInManager;
    private TokenService _tokenService;
    private IMapper _mapper;

    public TecnicoServices(AppDbContext context, IMapper mapper, TokenService tokenService, UserManager<Tecnico> userManager, SignInManager<Tecnico>? signInManager)
    {
        _context = context;
        _mapper = mapper;
        _tokenService = tokenService;
        _userManager = userManager;
        _signInManager = signInManager;
    }

    public async Task<List<GetTecnicoDto>> Listar()
        => await _context.Tecnicos
            .Select(c => _mapper.Map<GetTecnicoDto>(c)).ToListAsync();

    public async Task<List<GetTecnicoDto>> Buscar(string Nome)
        => await _context.Tecnicos
            .Where(c => c.Nome.Contains(Nome))
            .Select(c => _mapper.Map<GetTecnicoDto>(c)).ToListAsync();

    public async Task<GetTecnicoDto> Cadastrar(AddTecnicoDto dto)
    {
        Tecnico NewTecnico = _mapper.Map<Tecnico>(dto);

        IdentityResult Result = await _userManager.CreateAsync(NewTecnico, dto.Password);

        if (!Result.Succeeded)
            throw new Exception("Falha ao cadastrar técnico.");

        return _mapper.Map<GetTecnicoDto>(NewTecnico);
    }

    public async Task<GetTecnicoDto?> Alterar(string id, UpdateTecnicoDto tecnico)
    {
        var TecnicoOriginal = await _context.Tecnicos.FindAsync(id);
        if(TecnicoOriginal is null)
            return null;

        TecnicoOriginal = _mapper.Map(tecnico, TecnicoOriginal);
        await _context.SaveChangesAsync();

        return _mapper.Map<GetTecnicoDto>(TecnicoOriginal);
    }

    public async Task<GetTecnicoDto?> Deletar(string id)
    {
        var tecnico = await _context.Tecnicos.FindAsync(id);

        if (tecnico is null)
            return null;

        _context.Tecnicos.Remove(tecnico);
        await _context.SaveChangesAsync();

        return _mapper.Map<GetTecnicoDto>(tecnico);
    }

    public async Task<string> LogIn(LoginTecnicoDto tecnico)
    {
        var Result = await _signInManager.PasswordSignInAsync(tecnico.Username, tecnico.Password, false, false);

        if (!Result.Succeeded)
            throw new ApplicationException("Usuário Não Autenticado");

        var usuario = _signInManager
            .UserManager
            .Users
            .FirstOrDefault(user => user.NormalizedUserName == tecnico.Username.ToUpper());

        return _tokenService.GerarToken(usuario);
    }
}
