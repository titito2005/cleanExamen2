using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Examen2.Domain.Core.CoreEntities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Examen2.Infrastructure.Core.EntityMappings
{
    public class GrupoInvestigacionMap : IEntityTypeConfiguration<GrupoInvestigacion>
    {
        public void Configure(EntityTypeBuilder<GrupoInvestigacion> builder) 
        {
            builder.ToTable("GrupoInvestigacion")
                .HasKey(Grupo => Grupo.Id);

            builder.Property(Grupo => Grupo.Id)
                .IsRequired()
                .HasMaxLength(10)
                .HasColumnName("Id");

            builder.Property(Grupo => Grupo.Nombre)
                .IsRequired()
                .HasMaxLength(50)
                .HasColumnName("Nombre");

            builder.Property(Grupo => Grupo.Descripcion)
                .IsRequired()
                .HasMaxLength(100)
                .HasColumnName("Descripcion");

            builder.Property(Grupo => Grupo.FechaCreacion)
                .IsRequired()
                .HasColumnName("FechaCreacion");

            builder.Property(Grupo => Grupo.IdCoordinador)
                .IsRequired()
                .HasMaxLength(10)
                .HasColumnName("IdCoordinador");
        }
    }
}