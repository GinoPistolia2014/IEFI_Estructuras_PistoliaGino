using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IEFI_Estructuras_PistoliaGino.Tramite
{
    public class Finalizados
    {
        public string DNI { get; set; }
        public string NombreCompleto { get; set; }
        public string Motivo { get; set; }
        public string TipoTramite { get; set; }

        public DateTime FechaHoraIngreso { get; set; }

        public Finalizados Siguiente;
        public Finalizados(string dni, string nombrecompleto, string motivo, string tipotramite, DateTime fechahoraingreso)
        {
            this.DNI = dni;
            this.NombreCompleto = nombrecompleto;
            this.Motivo = motivo;
            this.TipoTramite = tipotramite;
            this.FechaHoraIngreso = fechahoraingreso;
            this.Siguiente = null;
        }
    }

}
