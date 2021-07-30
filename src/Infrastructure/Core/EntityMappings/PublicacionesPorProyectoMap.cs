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
    public class PublicacionesPorProyectoMap : IEntityTypeConfiguration<PublicacionesPorProyecto>
    {
        public void Configure(EntityTypeBuilder<PublicacionesPorProyecto> builder)
        {
            builder.ToTable("PublicacionesPorProyecto")
               .HasKey(Publicacion => new { Publicacion.IdGrupo, Publicacion.IdPublicacion});

            builder.Property(Publicacion => Publicacion.IdGrupo)
                .IsRequired()
                .HasMaxLength(10)
                .HasColumnName("IdGrupo");

            builder.Property(Publicacion => Publicacion.IdPublicacion)
                .IsRequired()
                .HasMaxLength(10)
                .HasColumnName("IdPublicacion");
        }
    }
}