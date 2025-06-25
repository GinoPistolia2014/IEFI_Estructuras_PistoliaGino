using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IEFI_Estructuras_PistoliaGino.Tramite
{
    public class Urgentes
    {
        public string DNI { get; set; }
        public string NombreCompleto { get; set; }
        public string Motivo { get; set; }
        public string TipoTramite { get; set; }

        public DateTime HoraFecha { get; set; }

        public Urgentes Siguiente;

        public Urgentes(string dni, string motivo, string nombrecompleto, string tipotramite, DateTime horafecha)
        {
            this.DNI = dni;
            this.NombreCompleto = nombrecompleto;
            this.Motivo = motivo;
            this.TipoTramite = tipotramite;
            this.HoraFecha = horafecha;
            this.Siguiente = null;
        }
    }
}
