namespace IEFI_Estructuras_PistoliaGino.Estructuras_Cola
{
    partial class FormTramitesGenerales
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
            this.dgvTramitesGenerales = new System.Windows.Forms.DataGridView();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnAtendido = new System.Windows.Forms.Button();
            this.btnVerAtendidos = new System.Windows.Forms.Button();
            this.txtdni = new System.Windows.Forms.TextBox();
            this.txtnombrecompleto = new System.Windows.Forms.TextBox();
            this.txttipotramite = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTramitesGenerales)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvTramitesGenerales
            // 
            this.dgvTramitesGenerales.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTramitesGenerales.Location = new System.Drawing.Point(252, 56);
            this.dgvTramitesGenerales.Name = "dgvTramitesGenerales";
            this.dgvTramitesGenerales.Size = new System.Drawing.Size(495, 176);
            this.dgvTramitesGenerales.TabIndex = 0;
            // 
            // btnAgregar
            // 
            this.btnAgregar.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnAgregar.Location = new System.Drawing.Point(52, 340);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(116, 47);
            this.btnAgregar.TabIndex = 1;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = false;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnAtendido
            // 
            this.btnAtendido.BackColor = System.Drawing.Color.CadetBlue;
            this.btnAtendido.Location = new System.Drawing.Point(312, 340);
            this.btnAtendido.Name = "btnAtendido";
            this.btnAtendido.Size = new System.Drawing.Size(131, 47);
            this.btnAtendido.TabIndex = 2;
            this.btnAtendido.Text = "Atendido";
            this.btnAtendido.UseVisualStyleBackColor = false;
            this.btnAtendido.Click += new System.EventHandler(this.btnAtendido_Click);
            // 
            // btnVerAtendidos
            // 
            this.btnVerAtendidos.BackColor = System.Drawing.Color.SteelBlue;
            this.btnVerAtendidos.Location = new System.Drawing.Point(591, 340);
            this.btnVerAtendidos.Name = "btnVerAtendidos";
            this.btnVerAtendidos.Size = new System.Drawing.Size(131, 47);
            this.btnVerAtendidos.TabIndex = 3;
            this.btnVerAtendidos.Text = "Ver Atendidos";
            this.btnVerAtendidos.UseVisualStyleBackColor = false;
            this.btnVerAtendidos.Click += new System.EventHandler(this.btnVerAtendidos_Click);
            // 
            // txtdni
            // 
            this.txtdni.Location = new System.Drawing.Point(52, 46);
            this.txtdni.Name = "txtdni";
            this.txtdni.Size = new System.Drawing.Size(100, 20);
            this.txtdni.TabIndex = 4;
            // 
            // txtnombrecompleto
            // 
            this.txtnombrecompleto.Location = new System.Drawing.Point(52, 121);
            this.txtnombrecompleto.Name = "txtnombrecompleto";
            this.txtnombrecompleto.Size = new System.Drawing.Size(100, 20);
            this.txtnombrecompleto.TabIndex = 5;
            // 
            // txttipotramite
            // 
            this.txttipotramite.Location = new System.Drawing.Point(52, 212);
            this.txttipotramite.Name = "txttipotramite";
            this.txttipotramite.Size = new System.Drawing.Size(100, 20);
            this.txttipotramite.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(49, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "DNI";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(49, 105);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Nombre Completo";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(49, 196);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Tipo de Tramite";
            // 
            // FormTramitesGenerales
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txttipotramite);
            this.Controls.Add(this.txtnombrecompleto);
            this.Controls.Add(this.txtdni);
            this.Controls.Add(this.btnVerAtendidos);
            this.Controls.Add(this.btnAtendido);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.dgvTramitesGenerales);
            this.Name = "FormTramitesGenerales";
            this.Text = "FormTramitesGenerales";
            this.Load += new System.EventHandler(this.FormTramitesGenerales_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTramitesGenerales)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvTramitesGenerales;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnAtendido;
        private System.Windows.Forms.Button btnVerAtendidos;
        private System.Windows.Forms.TextBox txtdni;
        private System.Windows.Forms.TextBox txtnombrecompleto;
        private System.Windows.Forms.TextBox txttipotramite;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}