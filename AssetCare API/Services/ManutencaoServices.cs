using AssetCare_API.Data;
using AssetCare_API.DTOs;
using AssetCare_API.Models;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace AssetCare_API.Services;

public class ManutencaoServices : IManutencaoService
{
    private AppDbContext _context;
    private IMapper _mapper;

    public ManutencaoServices(IMapper mapper, AppDbContext context)
    {
        _mapper = mapper;
        _context = context;
    }

    public async Task<GetManutencaoDto> Cadastrar(AddManutencaoDto dto)
    {
        var manutencao = _mapper.Map<Manutencao>(dto);
        _context.Manutencoes.Add(manutencao);
        await _context.SaveChangesAsync();

        return _mapper.Map<GetManutencaoDto>(manutencao);
    }

    public async Task<List<GetManutencaoDto>> Listar()
        => await _context.Manutencoes
            .Select(c => _mapper.Map<GetManutencaoDto>(c)).ToListAsync();

    public async Task<GetManutencaoDto> Buscar_Id(int Id)
    {
        var result = await _context.Manutencoes.FindAsync(Id);
        return _mapper.Map<GetManutencaoDto>(result);
    }

    public async Task<List<GetManutencaoDto>> Buscar_Maquina(int MaquinaId)
        => await _context.Manutencoes
            .Where(c => c.MaquinaId == MaquinaId)
            .Select(c => _mapper.Map<GetManutencaoDto>(c)).ToListAsync();

    public async Task<List<GetManutencaoDto>> Buscar_Tecnico(string TecnicoId)
        => await _context.Manutencoes
            .Where(c => c.TecnicoId.Equals(TecnicoId))
            .Select(c => _mapper.Map<GetManutencaoDto>(c)).ToListAsync();

    public async Task<GetManutencaoDto?> Alterar(int Id, UpdateManutencaoDto dto)
    {
        var manutencao = await _context.Manutencoes.FindAsync(Id);

        if (manutencao is null)
            return null;

        manutencao = _mapper.Map(dto, manutencao);
        await _context.SaveChangesAsync();

        return _mapper.Map<GetManutencaoDto>(manutencao);
    }

    public async Task<GetManutencaoDto?> Deletar(int Id)
    {
        var manutencao = await _context.Manutencoes.FindAsync(Id);

        if (manutencao is null)
            return null;

        _context.Manutencoes.Remove(manutencao);
        await _context.SaveChangesAsync();

        return _mapper.Map<GetManutencaoDto>(manutencao);
    }
}
