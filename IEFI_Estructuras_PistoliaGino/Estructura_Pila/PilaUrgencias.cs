using IEFI_Estructuras_PistoliaGino.Tramite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IEFI_Estructuras_PistoliaGino.Estructura_Pila
{
    public class PilaUrgencias
    {
        public NodoPila Inicio;

        public PilaUrgencias()
        {
            Inicio = null;
        }

        public void Insertar(string dni, string nombrecompleto, string motivo, string tipotramite, DateTime horafecha)
        {
            Urgentes urgentes = new Urgentes(dni, motivo, nombrecompleto, tipotramite, horafecha);
            NodoPila nuevo = new NodoPila(urgentes);
            if (Inicio == null) Inicio = nuevo;
            else
            {
                nuevo.Siguiente = Inicio;
                Inicio = nuevo;
            }
        }

        public void Eliminar()
        {
            NodoPila aux = Inicio;
            Inicio = Inicio.Siguiente;
            aux = null;
        }

        public List<Urgentes> devolverRegistros()
        {
            List<Urgentes> lista = new List<Urgentes>();

            NodoPila aux = Inicio;
            while (aux != null)
            {
                lista.Add(aux.Urgentes);
                aux = aux.Siguiente;
            }

            return lista;
        }
    }
}
