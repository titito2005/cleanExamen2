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
    public class PublicacionMap : IEntityTypeConfiguration<Publicacion>
    {
        public void Configure(EntityTypeBuilder<Publicacion> builder)
        {
            builder.ToTable("Publicacion")
                .HasKey(Publicacion => Publicacion.Id);

            builder.Property(Publicacion => Publicacion.Id)
                .IsRequired()
                .HasMaxLength(10)
                .HasColumnName("Id");

            builder.Property(Publicacion => Publicacion.Nombre)
                .IsRequired()
                .HasMaxLength(50)
                .HasColumnName("Nombre");

            builder.Property(Publicacion => Publicacion.Resumen)
                .IsRequired()
                .HasMaxLength(100)
                .HasColumnName("Resumen");

            builder.Property(Publicacion => Publicacion.Tipo)
                .IsRequired()
                .HasMaxLength(20)
                .HasColumnName("Tipo");

            builder.Property(Publicacion => Publicacion.Referencia)
                .IsRequired()
                .HasMaxLength(20)
                .HasColumnName("Referencia");
        }
    }
}