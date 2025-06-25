namespace IEFI_Estructuras_PistoliaGino.Estructura_Lista
{
    partial class FormHistorial
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dgvTramitesFinalizados = new System.Windows.Forms.DataGridView();
            this.dgvDNI = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvNombreCompleto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTramitesFinalizados)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvTramitesFinalizados
            // 
            this.dgvTramitesFinalizados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTramitesFinalizados.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgvDNI,
            this.dgvNombreCompleto,
            this.Column1,
            this.Column3,
            this.Column4});
            this.dgvTramitesFinalizados.Location = new System.Drawing.Point(53, 78);
            this.dgvTramitesFinalizados.Name = "dgvTramitesFinalizados";
            this.dgvTramitesFinalizados.Size = new System.Drawing.Size(699, 296);
            this.dgvTramitesFinalizados.TabIndex = 0;
            // 
            // dgvDNI
            // 
            this.dgvDNI.HeaderText = "DNI";
            this.dgvDNI.Name = "dgvDNI";
            // 
            // dgvNombreCompleto
            // 
            this.dgvNombreCompleto.HeaderText = "Nombre Completo";
            this.dgvNombreCompleto.Name = "dgvNombreCompleto";
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Motivo";
            this.Column1.Name = "Column1";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Tipo de Tramite";
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Fecha y Hora";
            this.Column4.Name = "Column4";
            // 
            // FormHistorial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSalmon;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgvTramitesFinalizados);
            this.Name = "FormHistorial";
            this.Text = "Historial";
            ((System.ComponentModel.ISupportInitialize)(this.dgvTramitesFinalizados)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvTramitesFinalizados;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvDNI;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvNombreCompleto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
    }
}