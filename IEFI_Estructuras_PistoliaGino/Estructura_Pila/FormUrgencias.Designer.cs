namespace IEFI_Estructuras_PistoliaGino.Estructura_Pila
{
    partial class FormUrgencias
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
            this.btnInsertar = new System.Windows.Forms.Button();
            this.cmbMotivo = new System.Windows.Forms.ComboBox();
            this.lblMotivoUrgencia = new System.Windows.Forms.Label();
            this.dgvTramitesUrgentes = new System.Windows.Forms.DataGridView();
            this.btnFinalizar = new System.Windows.Forms.Button();
            this.btnVerTramitesFinalizados = new System.Windows.Forms.Button();
            this.txtDNI = new System.Windows.Forms.TextBox();
            this.txtNombreCompleto = new System.Windows.Forms.TextBox();
            this.txtTipoTramite = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTramitesUrgentes)).BeginInit();
            this.SuspendLayout();
            // 
            // btnInsertar
            // 
            this.btnInsertar.BackColor = System.Drawing.Color.SlateGray;
            this.btnInsertar.Location = new System.Drawing.Point(32, 354);
            this.btnInsertar.Name = "btnInsertar";
            this.btnInsertar.Size = new System.Drawing.Size(128, 43);
            this.btnInsertar.TabIndex = 0;
            this.btnInsertar.Text = "Insertar";
            this.btnInsertar.UseVisualStyleBackColor = false;
            this.btnInsertar.Click += new System.EventHandler(this.btnInsertar_Click);
            // 
            // cmbMotivo
            // 
            this.cmbMotivo.FormattingEnabled = true;
            this.cmbMotivo.Items.AddRange(new object[] {
            "Salud",
            "Viajes",
            "Fuerza Mayor"});
            this.cmbMotivo.Location = new System.Drawing.Point(45, 237);
            this.cmbMotivo.Name = "cmbMotivo";
            this.cmbMotivo.Size = new System.Drawing.Size(121, 21);
            this.cmbMotivo.TabIndex = 2;
            // 
            // lblMotivoUrgencia
            // 
            this.lblMotivoUrgencia.AutoSize = true;
            this.lblMotivoUrgencia.Location = new System.Drawing.Point(42, 221);
            this.lblMotivoUrgencia.Name = "lblMotivoUrgencia";
            this.lblMotivoUrgencia.Size = new System.Drawing.Size(109, 13);
            this.lblMotivoUrgencia.TabIndex = 3;
            this.lblMotivoUrgencia.Text = "Motivo de la urgencia";
            // 
            // dgvTramitesUrgentes
            // 
            this.dgvTramitesUrgentes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTramitesUrgentes.Location = new System.Drawing.Point(279, 52);
            this.dgvTramitesUrgentes.Name = "dgvTramitesUrgentes";
            this.dgvTramitesUrgentes.Size = new System.Drawing.Size(494, 189);
            this.dgvTramitesUrgentes.TabIndex = 4;
            // 
            // btnFinalizar
            // 
            this.btnFinalizar.BackColor = System.Drawing.Color.SlateGray;
            this.btnFinalizar.Location = new System.Drawing.Point(299, 353);
            this.btnFinalizar.Name = "btnFinalizar";
            this.btnFinalizar.Size = new System.Drawing.Size(138, 44);
            this.btnFinalizar.TabIndex = 5;
            this.btnFinalizar.Text = "Finalizar";
            this.btnFinalizar.UseVisualStyleBackColor = false;
            this.btnFinalizar.Click += new System.EventHandler(this.btnFinalizar_Click_1);
            // 
            // btnVerTramitesFinalizados
            // 
            this.btnVerTramitesFinalizados.BackColor = System.Drawing.Color.SlateGray;
            this.btnVerTramitesFinalizados.Location = new System.Drawing.Point(576, 347);
            this.btnVerTramitesFinalizados.Name = "btnVerTramitesFinalizados";
            this.btnVerTramitesFinalizados.Size = new System.Drawing.Size(135, 50);
            this.btnVerTramitesFinalizados.TabIndex = 6;
            this.btnVerTramitesFinalizados.Text = "Ver tramites finalizados";
            this.btnVerTramitesFinalizados.UseVisualStyleBackColor = false;
            this.btnVerTramitesFinalizados.Click += new System.EventHandler(this.btnVerTramitesFinalizados_Click_1);
            // 
            // txtDNI
            // 
            this.txtDNI.Location = new System.Drawing.Point(45, 52);
            this.txtDNI.Name = "txtDNI";
            this.txtDNI.Size = new System.Drawing.Size(100, 20);
            this.txtDNI.TabIndex = 7;
            // 
            // txtNombreCompleto
            // 
            this.txtNombreCompleto.Location = new System.Drawing.Point(45, 105);
            this.txtNombreCompleto.Name = "txtNombreCompleto";
            this.txtNombreCompleto.Size = new System.Drawing.Size(100, 20);
            this.txtNombreCompleto.TabIndex = 8;
            // 
            // txtTipoTramite
            // 
            this.txtTipoTramite.Location = new System.Drawing.Point(45, 164);
            this.txtTipoTramite.Name = "txtTipoTramite";
            this.txtTipoTramite.Size = new System.Drawing.Size(100, 20);
            this.txtTipoTramite.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(42, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "DNI";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(42, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Nombre Completo";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(42, 148);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Tipo de Tramite";
            // 
            // FormUrgencias
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DodgerBlue;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtTipoTramite);
            this.Controls.Add(this.txtNombreCompleto);
            this.Controls.Add(this.txtDNI);
            this.Controls.Add(this.btnVerTramitesFinalizados);
            this.Controls.Add(this.btnFinalizar);
            this.Controls.Add(this.dgvTramitesUrgentes);
            this.Controls.Add(this.lblMotivoUrgencia);
            this.Controls.Add(this.cmbMotivo);
            this.Controls.Add(this.btnInsertar);
            this.Name = "FormUrgencias";
            this.Text = "Urgencias";
            this.Load += new System.EventHandler(this.FormUrgencias_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTramitesUrgentes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnInsertar;
        private System.Windows.Forms.ComboBox cmbMotivo;
        private System.Windows.Forms.Label lblMotivoUrgencia;
        private System.Windows.Forms.DataGridView dgvTramitesUrgentes;
        private System.Windows.Forms.Button btnFinalizar;
        private System.Windows.Forms.Button btnVerTramitesFinalizados;
        private System.Windows.Forms.TextBox txtDNI;
        private System.Windows.Forms.TextBox txtNombreCompleto;
        private System.Windows.Forms.TextBox txtTipoTramite;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}