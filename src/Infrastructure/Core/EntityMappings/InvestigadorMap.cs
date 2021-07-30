using Examen2.Domain.Core.CoreEntities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen2.Infrastructure.Core.EntityMappings
{
    public class InvestigadorMap : IEntityTypeConfiguration<Investigador>
    {
        public void Configure(EntityTypeBuilder<Investigador> builder)
        {
            builder.ToTable("Investigador")
                .HasKey(investigador => new { investigador.Id});

            builder.Property(investigador => investigador.Id)
                .IsRequired()
                .HasMaxLength(10)
                .HasColumnName("Id");

            builder.Property(investigador => investigador.Nombre)
                .IsRequired()
                .HasMaxLength(50)
                .HasColumnName("Nombre");

            builder.Property(investigador => investigador.MaxGrado)
                .IsRequired()
                .HasMaxLength(10)
                .HasColumnName("MaxGrado");
        }
    }
}