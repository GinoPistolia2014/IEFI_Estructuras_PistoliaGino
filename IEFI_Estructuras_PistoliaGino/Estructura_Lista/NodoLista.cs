using IEFI_Estructuras_PistoliaGino.Tramite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IEFI_Estructuras_PistoliaGino.Estructura_Lista
{
    public class NodoLista
    {
        public Finalizados Finalizados { get; set; }
        public NodoLista Siguiente { get; set; }

        public NodoLista(Finalizados finalizados)
        {
            this.Finalizados = finalizados;
            this.Siguiente = null;
        }
    }
}
