using IEFI_Estructuras_PistoliaGino.Tramite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IEFI_Estructuras_PistoliaGino.Estructura_Lista
{
    public class ListaFinalizados
    {
        NodoLista Inicio;
        NodoLista Fin;

        public ListaFinalizados()
        {
            Inicio = null;
            Fin = null;

        }

        public void Insertar(Finalizados finalizados)
        {
            NodoLista nuevo = new NodoLista(finalizados);


            if (Inicio == null)
            {
                Inicio = nuevo;
                Fin = nuevo;
            }

            else if (finalizados.FechaHoraIngreso < Inicio.Finalizados.FechaHoraIngreso)
            {
                nuevo.Siguiente = Inicio;
                Inicio = nuevo;
            }

            else if (finalizados.FechaHoraIngreso >= Fin.Finalizados.FechaHoraIngreso)
            {
                Fin.Siguiente = nuevo;
                Fin = nuevo;
            }

            else
            {
                NodoLista anterior = Inicio;
                NodoLista actual = Inicio.Siguiente;

                while (actual != null && finalizados.FechaHoraIngreso >= actual.Finalizados.FechaHoraIngreso)
                {
                    anterior = actual;
                    actual = actual.Siguiente;
                }

                nuevo.Siguiente = actual;
                anterior.Siguiente = nuevo;
            }
        }

        public List<Finalizados> Listar()
        {
            List<Finalizados> ListaFinalizados = new List<Finalizados>();
            NodoLista aux = Inicio;
            while (aux != null)
            {
                ListaFinalizados.Add(aux.Finalizados);
                aux = aux.Siguiente;
            }
            return ListaFinalizados;
        }
    }
}

