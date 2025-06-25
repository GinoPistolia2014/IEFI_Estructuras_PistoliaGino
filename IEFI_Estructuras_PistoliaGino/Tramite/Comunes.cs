using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IEFI_Estructuras_PistoliaGino.Tramite
{
    public class Comunes
    {
        public string DNI { get; set; }
        public string NombreCompleto { get; set; }
        public string TipoTramite { get; set; }

        public DateTime FechaHoraIngreso { get; set; }

        public Comunes Siguiente;

        public Comunes(string dni, string nombrecompleto, string tipotramite, DateTime fechahoraingreso)
        {
            this.NombreCompleto = nombrecompleto;
            this.TipoTramite = tipotramite;
            this.FechaHoraIngreso = fechahoraingreso;
            this.Siguiente = null;
        }
    }
}

