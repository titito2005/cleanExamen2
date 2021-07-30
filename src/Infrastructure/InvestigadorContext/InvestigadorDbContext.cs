using Examen2.Domain.Core.CoreEntities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Examen2.Infrastructure.Core;
using Examen2.Infrastructure.Core.EntityMappings;
using Microsoft.Extensions.Logging;
using System.Diagnostics;

namespace Examen2.Infrastructure.InvestigadorContext
{
    public partial class InvestigadorDbContext : AplicationDbContext
    {
        public InvestigadorDbContext(DbContextOptions<InvestigadorDbContext> options, ILogger<InvestigadorDbContext> logger)
        : base(options, logger)
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.LogTo(message => Debug.WriteLine(message));
        }

        public virtual DbSet<GrupoInvestigacion> GrupoInvestigacion { get; set; }
        public virtual DbSet<Investigador> Investigador { get; set; }
        public virtual DbSet<InvestigadoresPorProyecto> InvestigadoresPorProyecto { get; set; }
        public virtual DbSet<Publicacion> Publicacion { get; set; }
        public virtual DbSet<PublicacionesPorProyecto> PublicacionesPorProyecto { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfiguration(new GrupoInvestigacionMap());
            modelBuilder.ApplyConfiguration(new InvestigadorMap());
            modelBuilder.ApplyConfiguration(new InvestigadoresPorProyectoMap());
            modelBuilder.ApplyConfiguration(new PublicacionMap());
            modelBuilder.ApplyConfiguration(new PublicacionesPorProyectoMap());
        }
    }
}