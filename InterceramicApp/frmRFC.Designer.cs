namespace InterceramicApp
{
    partial class frmRFC
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
            this.cmbUsuario = new System.Windows.Forms.ComboBox();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.ldlDescripcion = new System.Windows.Forms.Label();
            this.lblDepartamento = new System.Windows.Forms.Label();
            this.lblFecha = new System.Windows.Forms.Label();
            this.btnEnviar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.txtFecha = new System.Windows.Forms.TextBox();
            this.lblDispositivo = new System.Windows.Forms.Label();
            this.cmbDepartamento = new System.Windows.Forms.ComboBox();
            this.cmbDispositivo = new System.Windows.Forms.ComboBox();
            this.lblClave = new System.Windows.Forms.Label();
            this.cmbClave = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // cmbUsuario
            // 
            this.cmbUsuario.FormattingEnabled = true;
            this.cmbUsuario.Location = new System.Drawing.Point(34, 74);
            this.cmbUsuario.Name = "cmbUsuario";
            this.cmbUsuario.Size = new System.Drawing.Size(240, 21);
            this.cmbUsuario.TabIndex = 0;
            this.cmbUsuario.SelectedIndexChanged += new System.EventHandler(this.cmbUsuario_SelectedIndexChanged);
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtDescripcion.Location = new System.Drawing.Point(34, 117);
            this.txtDescripcion.MaxLength = 1024;
            this.txtDescripcion.Multiline = true;
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(453, 383);
            this.txtDescripcion.TabIndex = 2;
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(30, 59);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(46, 13);
            this.lblNombre.TabIndex = 7;
            this.lblNombre.Text = "Tecnico";
            // 
            // ldlDescripcion
            // 
            this.ldlDescripcion.AutoSize = true;
            this.ldlDescripcion.Location = new System.Drawing.Point(31, 101);
            this.ldlDescripcion.Name = "ldlDescripcion";
            this.ldlDescripcion.Size = new System.Drawing.Size(133, 13);
            this.ldlDescripcion.TabIndex = 10;
            this.ldlDescripcion.Text = "Descripcion de la solicitud;";
            // 
            // lblDepartamento
            // 
            this.lblDepartamento.AutoSize = true;
            this.lblDepartamento.Location = new System.Drawing.Point(277, 60);
            this.lblDepartamento.Name = "lblDepartamento";
            this.lblDepartamento.Size = new System.Drawing.Size(74, 13);
            this.lblDepartamento.TabIndex = 8;
            this.lblDepartamento.Text = "Departamento";
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Location = new System.Drawing.Point(478, 59);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(100, 13);
            this.lblFecha.TabIndex = 9;
            this.lblFecha.Text = "Fecha (AA-MM-DD)";
            // 
            // btnEnviar
            // 
            this.btnEnviar.Location = new System.Drawing.Point(497, 101);
            this.btnEnviar.Name = "btnEnviar";
            this.btnEnviar.Size = new System.Drawing.Size(75, 23);
            this.btnEnviar.TabIndex = 4;
            this.btnEnviar.Text = "Enviar";
            this.btnEnviar.UseVisualStyleBackColor = true;
            this.btnEnviar.Click += new System.EventHandler(this.btnEnviar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(497, 183);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 5;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // txtFecha
            // 
            this.txtFecha.Location = new System.Drawing.Point(481, 75);
            this.txtFecha.Name = "txtFecha";
            this.txtFecha.Size = new System.Drawing.Size(91, 20);
            this.txtFecha.TabIndex = 11;
            // 
            // lblDispositivo
            // 
            this.lblDispositivo.AutoSize = true;
            this.lblDispositivo.Location = new System.Drawing.Point(385, 60);
            this.lblDispositivo.Name = "lblDispositivo";
            this.lblDispositivo.Size = new System.Drawing.Size(58, 13);
            this.lblDispositivo.TabIndex = 13;
            this.lblDispositivo.Text = "Dispositivo";
            // 
            // cmbDepartamento
            // 
            this.cmbDepartamento.FormattingEnabled = true;
            this.cmbDepartamento.Location = new System.Drawing.Point(280, 74);
            this.cmbDepartamento.Name = "cmbDepartamento";
            this.cmbDepartamento.Size = new System.Drawing.Size(98, 21);
            this.cmbDepartamento.TabIndex = 14;
            this.cmbDepartamento.SelectedIndexChanged += new System.EventHandler(this.cmbDepartamento_SelectedIndexChanged);
            // 
            // cmbDispositivo
            // 
            this.cmbDispositivo.FormattingEnabled = true;
            this.cmbDispositivo.Location = new System.Drawing.Point(384, 74);
            this.cmbDispositivo.Name = "cmbDispositivo";
            this.cmbDispositivo.Size = new System.Drawing.Size(91, 21);
            this.cmbDispositivo.TabIndex = 15;
            this.cmbDispositivo.SelectedIndexChanged += new System.EventHandler(this.cmbDispositivo_SelectedIndexChanged);
            // 
            // lblClave
            // 
            this.lblClave.AutoSize = true;
            this.lblClave.Location = new System.Drawing.Point(29, 10);
            this.lblClave.Name = "lblClave";
            this.lblClave.Size = new System.Drawing.Size(34, 13);
            this.lblClave.TabIndex = 17;
            this.lblClave.Text = "Clave";
            // 
            // cmbClave
            // 
            this.cmbClave.FormattingEnabled = true;
            this.cmbClave.Location = new System.Drawing.Point(33, 25);
            this.cmbClave.Name = "cmbClave";
            this.cmbClave.Size = new System.Drawing.Size(55, 21);
            this.cmbClave.TabIndex = 16;
            this.cmbClave.SelectedIndexChanged += new System.EventHandler(this.cmbClave_SelectedIndexChanged);
            // 
            // frmRFC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(607, 600);
            this.Controls.Add(this.lblClave);
            this.Controls.Add(this.cmbClave);
            this.Controls.Add(this.cmbDispositivo);
            this.Controls.Add(this.cmbDepartamento);
            this.Controls.Add(this.lblDispositivo);
            this.Controls.Add(this.txtFecha);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnEnviar);
            this.Controls.Add(this.lblFecha);
            this.Controls.Add(this.lblDepartamento);
            this.Controls.Add(this.ldlDescripcion);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.txtDescripcion);
            this.Controls.Add(this.cmbUsuario);
            this.Name = "frmRFC";
            this.Text = "Solicitud De Cambio";
            this.Load += new System.EventHandler(this.frmRFC_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbUsuario;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label ldlDescripcion;
        private System.Windows.Forms.Label lblDepartamento;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.Button btnEnviar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.TextBox txtFecha;
        private System.Windows.Forms.Label lblDispositivo;
        private System.Windows.Forms.ComboBox cmbDepartamento;
        private System.Windows.Forms.ComboBox cmbDispositivo;
        private System.Windows.Forms.Label lblClave;
        private System.Windows.Forms.ComboBox cmbClave;
    }
}