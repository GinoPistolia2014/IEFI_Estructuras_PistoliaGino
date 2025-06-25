using IEFI_Estructuras_PistoliaGino.Tramite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IEFI_Estructuras_PistoliaGino.Estructuras_Cola
{
    public class NodoCola
    {
        public Comunes Comunes{ get; set; }
        public NodoCola Siguiente { get; set; }

        public NodoCola(Comunes comunes)
        {
            Comunes = comunes;
            Siguiente = null;
        }
    }
}
 