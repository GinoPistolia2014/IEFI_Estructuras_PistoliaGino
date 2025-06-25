using IEFI_Estructuras_PistoliaGino.Estructura_Lista;
using IEFI_Estructuras_PistoliaGino.Estructuras_Cola;
using IEFI_Estructuras_PistoliaGino.Tramite;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IEFI_Estructuras_PistoliaGino.Estructura_Pila
{
    public partial class FormUrgencias : Form
    {
        PilaUrgencias urgentes = new PilaUrgencias();
        ListaFinalizados listaFinalizados = new ListaFinalizados();
        FormHistorial formlistaFinalizados = new FormHistorial(" Urgencia");

        public FormUrgencias()
        {
            InitializeComponent();

            Tramitar();
            formlistaFinalizados.Show();
        }
        private void FormUrgencias_Load(object sender, EventArgs e)
        {
            dgvTramitesUrgentes.Columns.Clear();
            dgvTramitesUrgentes.Columns.Add("DNI", "DNI");
            dgvTramitesUrgentes.Columns.Add("Nombre Completo", "NombreCompleto");
            dgvTramitesUrgentes.Columns.Add("Motivo", "Motivo");
            dgvTramitesUrgentes.Columns.Add("Tipo de tramite", "Tipotramite");
            dgvTramitesUrgentes.Columns.Add("Fecha de ingreso", "Fechaingreso");
        }
        private void btnInsertar_Click(object sender, EventArgs e)
        {
            string motivo = cmbMotivo.Text;
            urgentes.Insertar(txtDNI.Text, txtNombreCompleto.Text, motivo, txtTipoTramite.Text,DateTime.Now);
            txtDNI.Clear();
            txtNombreCompleto.Clear();
            txtTipoTramite.Clear();
            MostrarTramitesUrgentes(urgentes.devolverRegistros());
        }



        public void Tramitar()
        {
            if (urgentes.Inicio != null)
            {
                urgentes.Eliminar();

            }
            else MessageBox.Show("Procesado");
        }
        public void MostrarTramitesUrgentes(List<Urgentes> listaUrgentes)
        {
            dgvTramitesUrgentes.Rows.Clear();
            foreach (var urgentes in listaUrgentes)
            {
                dgvTramitesUrgentes.Rows.Add(urgentes.DNI, urgentes.NombreCompleto, urgentes.Motivo, urgentes.TipoTramite,urgentes.HoraFecha.ToString("HH:mm"));
            }
        }

        public void btnFinalizar_Click_1(object sender, EventArgs e)
        {
            if (urgentes.Inicio != null)
            {

                Finalizados tramitefinalizado = new Finalizados(urgentes.Inicio.Urgentes.DNI, urgentes.Inicio.Urgentes.NombreCompleto, urgentes.Inicio.Urgentes.Motivo, urgentes.Inicio.Urgentes.TipoTramite, urgentes.Inicio.Urgentes.HoraFecha);
                urgentes.Eliminar();

                listaFinalizados.Insertar(tramitefinalizado);

                MostrarTramitesUrgentes(urgentes.devolverRegistros());
                formlistaFinalizados.MostrarTramitesFinalizados(listaFinalizados.Listar());
            }
            else
            {
                MessageBox.Show("No hay pedidos pendientes.");
            }
        }

        private void btnVerTramitesFinalizados_Click_1(object sender, EventArgs e)
        {
            formlistaFinalizados.MostrarTramitesFinalizados(listaFinalizados.Listar());
        }

    }
}

