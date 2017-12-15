namespace InterceramicApp
{
    partial class frmLiberarIncidencia
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
            this.cmbClave = new System.Windows.Forms.ComboBox();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
<<<<<<< HEAD
            this.mcFecha = new System.Windows.Forms.MonthCalendar();
            this.txtTecnico = new System.Windows.Forms.TextBox();
            this.btnLiberar = new System.Windows.Forms.Button();
            this.lblNumero = new System.Windows.Forms.Label();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.lblDescripcion = new System.Windows.Forms.Label();
            this.lblFecha = new System.Windows.Forms.Label();
            this.btnCancelar = new System.Windows.Forms.Button();
=======
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.txtTecnico = new System.Windows.Forms.TextBox();
            this.btnLiberar = new System.Windows.Forms.Button();
            this.lblNumero = new System.Windows.Forms.Label();
            this.lblTecnico = new System.Windows.Forms.Label();
            this.lblDescripcion = new System.Windows.Forms.Label();
            this.mcFecha = new System.Windows.Forms.Label();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnCerrar = new System.Windows.Forms.Button();
>>>>>>> master
            this.SuspendLayout();
            // 
            // cmbClave
            // 
            this.cmbClave.FormattingEnabled = true;
            this.cmbClave.Location = new System.Drawing.Point(12, 50);
            this.cmbClave.Name = "cmbClave";
            this.cmbClave.Size = new System.Drawing.Size(58, 21);
            this.cmbClave.TabIndex = 0;
            this.cmbClave.SelectedIndexChanged += new System.EventHandler(this.cmbClave_SelectedIndexChanged);
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Location = new System.Drawing.Point(12, 144);
            this.txtDescripcion.MaxLength = 140;
            this.txtDescripcion.Multiline = true;
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.ReadOnly = true;
            this.txtDescripcion.Size = new System.Drawing.Size(308, 268);
            this.txtDescripcion.TabIndex = 1;
            // 
<<<<<<< HEAD
            // mcFecha
            // 
            this.mcFecha.Location = new System.Drawing.Point(348, 50);
            this.mcFecha.Name = "mcFecha";
            this.mcFecha.TabIndex = 2;
=======
            // monthCalendar1
            // 
            this.monthCalendar1.Location = new System.Drawing.Point(348, 50);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 2;
>>>>>>> master
            // 
            // txtTecnico
            // 
            this.txtTecnico.Location = new System.Drawing.Point(12, 90);
            this.txtTecnico.Name = "txtTecnico";
            this.txtTecnico.ReadOnly = true;
            this.txtTecnico.Size = new System.Drawing.Size(275, 20);
            this.txtTecnico.TabIndex = 3;
            // 
            // btnLiberar
            // 
            this.btnLiberar.Location = new System.Drawing.Point(437, 242);
            this.btnLiberar.Name = "btnLiberar";
            this.btnLiberar.Size = new System.Drawing.Size(75, 23);
            this.btnLiberar.TabIndex = 5;
            this.btnLiberar.Text = "Liberar";
            this.btnLiberar.UseVisualStyleBackColor = true;
<<<<<<< HEAD
            this.btnLiberar.Click += new System.EventHandler(this.btnLiberar_Click);
=======
>>>>>>> master
            // 
            // lblNumero
            // 
            this.lblNumero.AutoSize = true;
            this.lblNumero.Location = new System.Drawing.Point(9, 34);
            this.lblNumero.Name = "lblNumero";
            this.lblNumero.Size = new System.Drawing.Size(121, 13);
            this.lblNumero.TabIndex = 6;
            this.lblNumero.Text = "Clave De La Incidencia:";
            // 
<<<<<<< HEAD
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.Location = new System.Drawing.Point(12, 74);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(105, 13);
            this.lblUsuario.TabIndex = 7;
            this.lblUsuario.Text = "Nombre Del Usuario:";
=======
            // lblTecnico
            // 
            this.lblTecnico.AutoSize = true;
            this.lblTecnico.Location = new System.Drawing.Point(12, 74);
            this.lblTecnico.Name = "lblTecnico";
            this.lblTecnico.Size = new System.Drawing.Size(108, 13);
            this.lblTecnico.TabIndex = 7;
            this.lblTecnico.Text = "Nombre Del Técnico:";
>>>>>>> master
            // 
            // lblDescripcion
            // 
            this.lblDescripcion.AutoSize = true;
            this.lblDescripcion.Location = new System.Drawing.Point(9, 128);
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Size = new System.Drawing.Size(150, 13);
            this.lblDescripcion.TabIndex = 8;
            this.lblDescripcion.Text = "Descripción De La Incidencia:";
            // 
<<<<<<< HEAD
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Location = new System.Drawing.Point(345, 34);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(109, 13);
            this.lblFecha.TabIndex = 10;
            this.lblFecha.Text = "Fecha De Liberación:";
=======
            // mcFecha
            // 
            this.mcFecha.AutoSize = true;
            this.mcFecha.Location = new System.Drawing.Point(345, 34);
            this.mcFecha.Name = "mcFecha";
            this.mcFecha.Size = new System.Drawing.Size(109, 13);
            this.mcFecha.TabIndex = 10;
            this.mcFecha.Text = "Fecha De Liberación:";
>>>>>>> master
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(437, 292);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 11;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            // 
<<<<<<< HEAD
=======
            // btnCerrar
            // 
            this.btnCerrar.Location = new System.Drawing.Point(437, 346);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(75, 23);
            this.btnCerrar.TabIndex = 12;
            this.btnCerrar.Text = "Cerrar";
            this.btnCerrar.UseVisualStyleBackColor = true;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
>>>>>>> master
            // frmLiberarIncidencia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(682, 453);
<<<<<<< HEAD
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.lblFecha);
            this.Controls.Add(this.lblDescripcion);
            this.Controls.Add(this.lblUsuario);
            this.Controls.Add(this.lblNumero);
            this.Controls.Add(this.btnLiberar);
            this.Controls.Add(this.txtTecnico);
            this.Controls.Add(this.mcFecha);
=======
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.mcFecha);
            this.Controls.Add(this.lblDescripcion);
            this.Controls.Add(this.lblTecnico);
            this.Controls.Add(this.lblNumero);
            this.Controls.Add(this.btnLiberar);
            this.Controls.Add(this.txtTecnico);
            this.Controls.Add(this.monthCalendar1);
>>>>>>> master
            this.Controls.Add(this.txtDescripcion);
            this.Controls.Add(this.cmbClave);
            this.Name = "frmLiberarIncidencia";
            this.Text = "Liberar Incidencia";
            this.Load += new System.EventHandler(this.frmLiberarIncidencia_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbClave;
        private System.Windows.Forms.TextBox txtDescripcion;
<<<<<<< HEAD
        private System.Windows.Forms.MonthCalendar mcFecha;
        private System.Windows.Forms.TextBox txtTecnico;
        private System.Windows.Forms.Button btnLiberar;
        private System.Windows.Forms.Label lblNumero;
        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.Label lblDescripcion;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.Button btnCancelar;
=======
        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.TextBox txtTecnico;
        private System.Windows.Forms.Button btnLiberar;
        private System.Windows.Forms.Label lblNumero;
        private System.Windows.Forms.Label lblTecnico;
        private System.Windows.Forms.Label lblDescripcion;
        private System.Windows.Forms.Label mcFecha;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnCerrar;
>>>>>>> master
    }
}