using IEFI_Estructuras_PistoliaGino.Estructuras_Cola;
using IEFI_Estructuras_PistoliaGino.Tramite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IEFI_Estructuras_PistoliaGino.Estructura_Pila
{
    public class NodoPila
    {
        public Urgentes Urgentes { get; set; }
        public NodoPila Siguiente { get; set; }

        public NodoPila(Urgentes urgentes)
        {
            Urgentes = urgentes;
            Siguiente = null;
        }
    }
}

