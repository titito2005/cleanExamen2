using Examen2.Domain.Core.CoreEntities;
using Examen2.Domain.InvestigadorContext.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen2.Application.InvestigadorContext.Implementations
{
    public class InvestigadorService : IInvestigadorService
    {
        private readonly IInvestigadorRepository _investigadorRepository;

        public InvestigadorService(IInvestigadorRepository InvestigadorRepository)
        {
            _investigadorRepository = InvestigadorRepository;
        }
        public async Task<IList<GrupoInvestigacion>> GetGrupoInvestigacionAsync() 
        {
            return await _investigadorRepository.GetGrupoInvestigacionAsync();
        }
        public IList<InvestigadoresPorProyecto> GetListInvestigadoreProyectoId(string id) 
        {
            return _investigadorRepository.GetListInvestigadoreProyectoId(id);
        }
        public async Task<IList<Investigador>> GetListInvestigadorAsync() 
        {
            return await _investigadorRepository.GetListInvestigadorAsync();
        }
        public bool crearInvestigador(Investigador _investigador) 
        {
            return _investigadorRepository.crearInvestigador(_investigador);
        }
        public void borrarInvestigador(Investigador _investigador) 
        {
            _investigadorRepository.borrarInvestigador(_investigador);
        }
        public Investigador getInvestigador(string id) 
        {
            return _investigadorRepository.getInvestigador(id);
        }
        public bool updateInvestigador(Investigador _investigador) 
        {
            return _investigadorRepository.updateInvestigador(_investigador);
        }
        public IList<PublicacionesPorProyecto> GetListPublicacionesProyectotId(string id) 
        {
            return _investigadorRepository.GetListPublicacionesProyectotId(id);
        }
        public Publicacion getPublicacion(string id) 
        {
            return _investigadorRepository.getPublicacion(id);
        }
    }
}
