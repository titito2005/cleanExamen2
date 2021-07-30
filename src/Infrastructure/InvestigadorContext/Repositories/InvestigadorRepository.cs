using Examen2.Domain.Core.CoreEntities;
using Examen2.Domain.Core.Repositories;
using Examen2.Domain.InvestigadorContext.Repositories;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen2.Infrastructure.InvestigadorContext.Repositories
{
    public class InvestigadorRepository : IInvestigadorRepository
    {
        private readonly InvestigadorDbContext _dbContext;
        public IUnitOfWork UnitOfWork => _dbContext;

        public InvestigadorRepository(InvestigadorDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<IList<GrupoInvestigacion>> GetGrupoInvestigacionAsync() 
        {
            return await _dbContext.GrupoInvestigacion.ToListAsync();
        }

        public IList<InvestigadoresPorProyecto> GetListInvestigadoreProyectoId(string id)
        {
            return _dbContext.InvestigadoresPorProyecto.FromSqlRaw("SELECT * FROM InvestigadoresPorProyecto WHERE IdGrupo =" + id).ToArray();
        }

        /*Lista todos los investigadores*/
        public async Task<IList<Investigador>> GetListInvestigadorAsync()
        {
            return await _dbContext.Investigador.ToListAsync();
        }

        /*Crea un nuevo investigador*/
        public bool crearInvestigador(Investigador _investigador)
        {
            bool creado = false;
            /*Verifica que el investigador no exista*/
            Investigador investigador = _dbContext.Investigador.FirstOrDefault(c => c.Id.Equals(_investigador.Id));
            if (investigador == null)
            {
                _dbContext.Investigador.Add(_investigador);
                _dbContext.SaveChanges();
                creado = true;
            }
            return creado;
        }

        /*Borra un investigador*/
        public void borrarInvestigador(Investigador _investigador)
        {
            _dbContext.Investigador.Remove(_investigador);
            _dbContext.SaveChanges();
        }

        /*Retorna un investigador según el id*/
        public Investigador getInvestigador(string id)
        {
            return _dbContext.Investigador.FirstOrDefault(c => c.Id.Equals(id));
        }

        /*Update un investigador*/
        public bool updateInvestigador(Investigador _investigador)
        {
            bool updated = false;
            /*Verifica que el investigador existe*/
            Investigador investigador = _dbContext.Investigador.FirstOrDefault(c => c.Id.Equals(_investigador.Id));
            if (investigador != null)
            {
                investigador.Nombre = _investigador.Nombre;
                investigador.MaxGrado = _investigador.MaxGrado;
                _dbContext.Investigador.Update(investigador);
                _dbContext.SaveChanges();
                updated = true;
            }
            return updated;
        }

        public IList<PublicacionesPorProyecto> GetListPublicacionesProyectotId(string id)
        {
            return _dbContext.PublicacionesPorProyecto.FromSqlRaw("SELECT * FROM PublicacionesPorProyecto WHERE IdGrupo =" + id).ToArray();
        }

        public Publicacion getPublicacion(string id)
        {
            return _dbContext.Publicacion.FirstOrDefault(c => c.Id.Equals(id));
        }
}
}
