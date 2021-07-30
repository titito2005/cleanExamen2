using Examen2.Domain.Core.CoreEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen2.Application.InvestigadorContext
{
    public interface IInvestigadorService
    {
        Task<IList<GrupoInvestigacion>> GetGrupoInvestigacionAsync();
        IList<InvestigadoresPorProyecto> GetListInvestigadoreProyectoId(string id);
        Task<IList<Investigador>> GetListInvestigadorAsync();
        bool crearInvestigador(Investigador _investigador);
        void borrarInvestigador(Investigador _investigador);
        Investigador getInvestigador(string id);
        bool updateInvestigador(Investigador _investigador);
        IList<PublicacionesPorProyecto> GetListPublicacionesProyectotId(string id);
        Publicacion getPublicacion(string id);
    }
}