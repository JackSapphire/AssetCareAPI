using AssetCare_API.Data;
using AssetCare_API.Models;
using AssetCare_API.Services;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Scalar.AspNetCore;
using UsuariosAPI.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring OpenAPI at https://aka.ms/aspnet/openapi
builder.Services.AddOpenApi();

// DbContext deve ser registrado antes do Identity
builder.Services.AddDbContext<AppDbContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

// Configura Identity para a entidade Tecnico
builder.Services
    .AddIdentity<Tecnico, IdentityRole>()
    .AddEntityFrameworkStores<AppDbContext>()
    .AddDefaultTokenProviders();

// Registrar serviços de aplicação
builder.Services.AddScoped<TokenService>();
builder.Services.AddScoped<ITecnicoServices, TecnicoServices>();
builder.Services.AddScoped<IMaquinaService, MaquinaServices>();
builder.Services.AddScoped<IManutencaoService, ManutencaoServices>();

builder.Services.AddAutoMapper
    (AppDomain.CurrentDomain.GetAssemblies());

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
    app.MapScalarApiReference();
}

app.UseHttpsRedirection();

app.UseAuthentication();
app.UseAuthorization();

app.MapControllers();

app.Run();
