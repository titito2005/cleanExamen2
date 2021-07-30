using System;
namespace Examen2.Domain.Core.CoreEntities
{
    public class GrupoInvestigacion
    {
        public string Id { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public DateTime FechaCreacion { get; set; }
        public string IdCoordinador { get; set; }
    }
}
