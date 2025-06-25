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

namespace IEFI_Estructuras_PistoliaGino.Estructura_Lista
{
    public partial class FormHistorial : Form
    {
        public FormHistorial(string Origen)
        {
            InitializeComponent();
            this.Text += Origen;
        }

        public void FormHistorial_Load(object sender, EventArgs e)
        {
            dgvTramitesFinalizados.Columns.Clear();
            dgvTramitesFinalizados.Columns.Add("DNI", "DNI");
            dgvTramitesFinalizados.Columns.Add("Nombre Completo", "NombreCompleto");
            dgvTramitesFinalizados.Columns.Add("Motivo", "Motivo");
            dgvTramitesFinalizados.Columns.Add("Tipo de tramite", "Tipotramite");
            dgvTramitesFinalizados.Columns.Add("Fecha de ingreso", "Fechaingreso");

        }
        public void MostrarTramitesFinalizados(List<Finalizados> listaFinalizados)
        {
            dgvTramitesFinalizados.Rows.Clear();
            foreach (var finalizados in listaFinalizados)
            {
                dgvTramitesFinalizados.Rows.Add(finalizados.DNI, finalizados.NombreCompleto,finalizados.Motivo, finalizados.TipoTramite, finalizados.FechaHoraIngreso.ToString("HH:mm"));
            }
        }
    }
}

