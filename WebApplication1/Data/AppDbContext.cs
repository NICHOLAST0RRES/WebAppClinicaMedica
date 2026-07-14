using Microsoft.EntityFrameworkCore;
using WebApplication1.Models;

namespace WebApplication1.Infra;

public class AppDbContext : DbContext
{
    //ctor
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
    {
    }
    
    //on model create que chama o Configuration que pega os detalhes de cada entidade
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfigurationsFromAssembly(typeof(AppDbContext).Assembly);
    }
    
    // tables 
    public DbSet<Medico> Medicos => Set<Medico>();
    public DbSet<Especialidade> Especialidades => Set<Especialidade>();
    public DbSet<Paciente> Pacientes => Set<Paciente>();

        

}

    
