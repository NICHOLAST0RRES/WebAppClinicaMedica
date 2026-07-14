using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using WebApplication1.Models;

namespace WebApplication1.Infra.Configurations;



public class MedicoConfiguration : IEntityTypeConfiguration<Medico>
{
    public void Configure(EntityTypeBuilder<Medico> builder)
    {
        builder.ToTable("Medicos");
        
        builder.Property(p => p.Nome).
            HasMaxLength(128).
            IsRequired();
        
        builder.Property(p => p.Crm).
            HasMaxLength(128).IsRequired();
        
        builder.Property(p => p.DataNascimento)
            .IsRequired();
        
        
        
    }
    
}