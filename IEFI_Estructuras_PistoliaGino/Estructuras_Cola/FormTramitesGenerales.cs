using IEFI_Estructuras_PistoliaGino.Estructura_Lista;
using IEFI_Estructuras_PistoliaGino.Estructura_Pila;
using IEFI_Estructuras_PistoliaGino.Tramite;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace IEFI_Estructuras_PistoliaGino.Estructuras_Cola
{
    public partial class FormTramitesGenerales : Form
    {
        ColaTramites comunes = new ColaTramites();
        ListaFinalizados listaFinalizados = new ListaFinalizados();
        FormHistorial formlistaFinalizados = new FormHistorial(" Generales");
        FormUrgencias formurgencias = new FormUrgencias();

        public FormTramitesGenerales()
        {
            InitializeComponent();
            Tramitar();
            formurgencias.Show();
            formlistaFinalizados.Show();

        }

        private void FormTramitesGenerales_Load_1(object sender, EventArgs e)
        {
            dgvTramitesGenerales.Columns.Clear();
            dgvTramitesGenerales.Columns.Add("DNI", "DNI");
            dgvTramitesGenerales.Columns.Add("Nombre Completo", "NombreCompleto");
            dgvTramitesGenerales.Columns.Add("Tipo de tramite", "Tipotramite");
            dgvTramitesGenerales.Columns.Add("Fecha de ingreso", "Fechaingreso");
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            comunes.Insertar(txtdni.Text, txtnombrecompleto.Text, txttipotramite.Text, DateTime.Now);
            txtdni.Clear();
            txtnombrecompleto.Clear();
            txttipotramite.Clear();
            MostrarTramitesGenerales(comunes.devolverRegistros());
        }

        public void Tramitar()
        {
            if (comunes.Inicio != null)
            {
                comunes.Eliminar();

            }
            else MessageBox.Show("Procesado");
        }
        public void MostrarTramitesGenerales(List<Comunes> listaComunes)
        {
            dgvTramitesGenerales.Rows.Clear();
            foreach (var comunes in listaComunes)
            {
                dgvTramitesGenerales.Rows.Add(comunes.NombreCompleto, comunes.TipoTramite, comunes.FechaHoraIngreso.ToString("HH:mm"));
            }
        }

        private void btnAtendido_Click(object sender, EventArgs e)
        {
            if (comunes.Inicio != null)
            {

                Finalizados tramitefinalizado = new Finalizados(comunes.Inicio.Comunes.DNI, comunes.Inicio.Comunes.NombreCompleto,"", comunes.Inicio.Comunes.TipoTramite, comunes.Inicio.Comunes.FechaHoraIngreso);
                comunes.Eliminar();

                listaFinalizados.Insertar(tramitefinalizado);

                MostrarTramitesGenerales(comunes.devolverRegistros());
                formlistaFinalizados.MostrarTramitesFinalizados(listaFinalizados.Listar());
            }
            else
            {
                MessageBox.Show("No hay pedidos pendientes.");
            }
        }

        private void btnVerAtendidos_Click(object sender, EventArgs e)
        {
            formlistaFinalizados.MostrarTramitesFinalizados(listaFinalizados.Listar());
        }

    }
    
}

