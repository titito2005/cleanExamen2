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

        public GrupoInvestigacion(string id, string nombre, string descripcion, DateTime fechaCreacion, string idCoordinador) 
        {
            Id = id;
            Nombre = nombre;
            Descripcion = descripcion;
            FechaCreacion = fechaCreacion;
            IdCoordinador = idCoordinador;
        }

        public GrupoInvestigacion() 
        { 
        }
    }
}
