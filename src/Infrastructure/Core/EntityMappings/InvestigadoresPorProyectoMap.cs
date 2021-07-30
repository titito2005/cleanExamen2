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
    public class InvestigadoresPorProyectoMap : IEntityTypeConfiguration<InvestigadoresPorProyecto>
    {
        public void Configure(EntityTypeBuilder<InvestigadoresPorProyecto> builder)
        {
            builder.ToTable("InvestigadoresPorProyecto")
                .HasKey(proyecto => new { proyecto.IdGrupo, proyecto.IdInvestigador });

            builder.Property(proyecto => proyecto.IdGrupo)
                .IsRequired()
                .HasMaxLength(10)
                .HasColumnName("IdGrupo");

            builder.Property(proyecto => proyecto.IdInvestigador)
                .IsRequired()
                .HasMaxLength(10)
                .HasColumnName("IdInvestigador");
        }
    }
}