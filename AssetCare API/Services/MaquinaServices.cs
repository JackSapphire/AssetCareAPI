using AssetCare_API.Data;
using AssetCare_API.DTOs;
using AssetCare_API.Models;
using AutoMapper;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

namespace AssetCare_API.Services;

public class MaquinaServices : IMaquinaService
{
    private AppDbContext _context;
    private IMapper _mapper;

    public MaquinaServices(IMapper mapper, AppDbContext context)
    {
        _mapper = mapper;
        _context = context;
    }

    public async Task<GetMaquinaDto> Cadastrar(AddMaquinaDto dto)
    {
        var maquina = _mapper.Map<Maquina>(dto);
        _context.Maquinas.Add(maquina);
        await _context.SaveChangesAsync();

        return _mapper.Map<GetMaquinaDto>(maquina);
    }

    public async Task<List<GetMaquinaDto>> Listar()
        => await _context.Maquinas
            .Select(c => _mapper.Map<GetMaquinaDto>(c)).ToListAsync();

    public async Task<GetMaquinaDto> BuscarID(int Id)
    {
        var result =  await _context.Maquinas.FindAsync(Id);
        return _mapper.Map<GetMaquinaDto>(result);
    }

    public async Task<List<GetMaquinaDto>> BuscarNome(string Nome)
        => await _context.Maquinas
            .Where(c => c.Nome.Contains(Nome))
            .Select(c => _mapper.Map<GetMaquinaDto>(c)).ToListAsync();

    public async Task<GetMaquinaDto?> Alterar(int Id, UpdateMaquinaDto dto)
    {
        var Maquina = await _context.Maquinas.FindAsync(Id);
        if (Maquina is null)
            return null;

        Maquina = _mapper.Map(dto, Maquina);
        await _context.SaveChangesAsync();

        return _mapper.Map<GetMaquinaDto>(Maquina);
    }

    public async Task<GetMaquinaDto?> Deletar(int Id)
    {
        var maquina = await _context.Maquinas.FindAsync(Id);

        if (maquina is null)
            return null;

        _context.Maquinas.Remove(maquina);
        await _context.SaveChangesAsync();

        return _mapper.Map<GetMaquinaDto>(maquina);
    }
}
