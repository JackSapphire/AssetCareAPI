using AssetCare_API.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace AssetCare_API.Data;

public class AppDbContext : IdentityDbContext<Tecnico>
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }
    public DbSet<Tecnico> Tecnicos => Set<Tecnico>();
    public DbSet<Maquina> Maquinas => Set<Maquina>();
    public DbSet<Manutencao> Manutencoes => Set<Manutencao>();

    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);

        // Garante nomes consistentes de tabelas Identity (evita queries para 'AspNetUsers' se você usa 'Tecnicos')
        builder.Entity<Tecnico>().ToTable("Tecnicos");
        builder.Entity<IdentityRole>().ToTable("Roles");
        builder.Entity<IdentityUserRole<string>>().ToTable("UserRoles");
        builder.Entity<IdentityUserClaim<string>>().ToTable("UserClaims");
        builder.Entity<IdentityUserLogin<string>>().ToTable("UserLogins");
        builder.Entity<IdentityRoleClaim<string>>().ToTable("RoleClaims");
        builder.Entity<IdentityUserToken<string>>().ToTable("UserTokens");
    }
}
