using AssetCare_API.Models;
using Microsoft.EntityFrameworkCore;

namespace AssetCare_API.Data;

public class AppDbContext(DbContextOptions<AppDbContext> options) : DbContext(options)
{
    public DbSet<Tecnico> Tecnicos => Set<Tecnico>();
    public DbSet<Maquina> Maquinas => Set<Maquina>();
    public DbSet<Manutencao> Manutencoes => Set<Manutencao>();
}
