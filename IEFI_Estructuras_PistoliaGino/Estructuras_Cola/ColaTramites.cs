using IEFI_Estructuras_PistoliaGino.Tramite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IEFI_Estructuras_PistoliaGino.Estructuras_Cola
{
    public class ColaTramites
    {
        public NodoCola Inicio;
        public NodoCola Fin;


        public ColaTramites()
        {
            Inicio = null;
            Fin = null;

        }

        public void Insertar(string dni, string nombrecompleto, string tipotramite, DateTime fechahoraingreso)
        {
            Comunes comunes = new Comunes(dni, nombrecompleto, tipotramite, fechahoraingreso);
            NodoCola nuevo = new NodoCola(comunes);
            if (Fin == null)
            {
                Inicio = nuevo;
                Fin = nuevo;
            }
            else
            {
                Fin.Siguiente = nuevo;
                Fin = nuevo;
            }
        }

        public void Eliminar()
        {
            NodoCola aux = Inicio;
            Inicio = Inicio.Siguiente;
            aux = null;
        }
        public List<Comunes> devolverRegistros()
        {
            List<Comunes> lista = new List<Comunes>();

            NodoCola aux = Inicio;
            while (aux != null)
            {
                lista.Add(aux.Comunes);
                aux = aux.Siguiente;
            }
            return lista;
        }
    }
}

