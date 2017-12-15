namespace InterceramicApp
{
    partial class FrmAltaIncidencia
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
            this.components = new System.ComponentModel.Container();
            this.grpTipos = new System.Windows.Forms.GroupBox();
            this.rdHardware = new System.Windows.Forms.RadioButton();
            this.rdSoftware = new System.Windows.Forms.RadioButton();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.lblDescripcion = new System.Windows.Forms.Label();
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.cmbUsuario = new System.Windows.Forms.ComboBox();
            this.txtDepartamento = new System.Windows.Forms.TextBox();
            this.lblDepartamento = new System.Windows.Forms.Label();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.mcFecha = new System.Windows.Forms.MonthCalendar();
            this.lblEquipo = new System.Windows.Forms.Label();
            this.lblDispositivo = new System.Windows.Forms.Label();
            this.txtDispositivo = new System.Windows.Forms.TextBox();
            this.grpTipos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // grpTipos
            // 
            this.grpTipos.Controls.Add(this.rdHardware);
            this.grpTipos.Controls.Add(this.rdSoftware);
            this.grpTipos.Location = new System.Drawing.Point(22, 248);
            this.grpTipos.Name = "grpTipos";
            this.grpTipos.Size = new System.Drawing.Size(200, 79);
            this.grpTipos.TabIndex = 1;
            this.grpTipos.TabStop = false;
            this.grpTipos.Text = "Tipos";
            this.grpTipos.Enter += new System.EventHandler(this.grpTipos_Enter);
            // 
            // rdHardware
            // 
            this.rdHardware.AutoSize = true;
            this.rdHardware.Location = new System.Drawing.Point(6, 51);
            this.rdHardware.Name = "rdHardware";
            this.rdHardware.Size = new System.Drawing.Size(71, 17);
            this.rdHardware.TabIndex = 3;
            this.rdHardware.TabStop = true;
            this.rdHardware.Text = "Hardware";
            this.rdHardware.UseVisualStyleBackColor = true;
            this.rdHardware.CheckedChanged += new System.EventHandler(this.rdHardware_CheckedChanged);
            // 
            // rdSoftware
            // 
            this.rdSoftware.AutoSize = true;
            this.rdSoftware.Location = new System.Drawing.Point(6, 25);
            this.rdSoftware.Name = "rdSoftware";
            this.rdSoftware.Size = new System.Drawing.Size(67, 17);
            this.rdSoftware.TabIndex = 2;
            this.rdSoftware.TabStop = true;
            this.rdSoftware.Text = "Software";
            this.rdSoftware.UseVisualStyleBackColor = true;
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtDescripcion.Location = new System.Drawing.Point(22, 128);
            this.txtDescripcion.MaxLength = 140;
            this.txtDescripcion.Multiline = true;
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(430, 114);
            this.txtDescripcion.TabIndex = 3;
            this.txtDescripcion.TextChanged += new System.EventHandler(this.txtDescripcion_TextChanged);
            this.txtDescripcion.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDescripcion_KeyPress);
            // 
            // lblDescripcion
            // 
            this.lblDescripcion.AutoSize = true;
            this.lblDescripcion.Location = new System.Drawing.Point(19, 112);
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Size = new System.Drawing.Size(80, 13);
            this.lblDescripcion.TabIndex = 6;
            this.lblDescripcion.Text = "DESCRIPCION";
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.Location = new System.Drawing.Point(195, 357);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(75, 23);
            this.btnRegistrar.TabIndex = 8;
            this.btnRegistrar.Text = "Aceptar";
            this.btnRegistrar.UseVisualStyleBackColor = true;
            this.btnRegistrar.Click += new System.EventHandler(this.btnRegistrar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(326, 357);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 9;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnCerrar
            // 
            this.btnCerrar.Location = new System.Drawing.Point(452, 357);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(75, 23);
            this.btnCerrar.TabIndex = 10;
            this.btnCerrar.Text = "Cerrar";
            this.btnCerrar.UseVisualStyleBackColor = true;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // cmbUsuario
            // 
            this.cmbUsuario.FormattingEnabled = true;
            this.cmbUsuario.Location = new System.Drawing.Point(22, 52);
            this.cmbUsuario.Name = "cmbUsuario";
            this.cmbUsuario.Size = new System.Drawing.Size(379, 21);
            this.cmbUsuario.TabIndex = 11;
            this.cmbUsuario.SelectedIndexChanged += new System.EventHandler(this.cmbUsuario_SelectedIndexChanged);
            // 
            // txtDepartamento
            // 
            this.txtDepartamento.Location = new System.Drawing.Point(563, 52);
            this.txtDepartamento.Name = "txtDepartamento";
            this.txtDepartamento.ReadOnly = true;
            this.txtDepartamento.Size = new System.Drawing.Size(251, 20);
            this.txtDepartamento.TabIndex = 12;
            this.txtDepartamento.TextChanged += new System.EventHandler(this.txtDepartamento_TextChanged);
            // 
            // lblDepartamento
            // 
            this.lblDepartamento.AutoSize = true;
            this.lblDepartamento.Location = new System.Drawing.Point(563, 33);
            this.lblDepartamento.Name = "lblDepartamento";
            this.lblDepartamento.Size = new System.Drawing.Size(97, 13);
            this.lblDepartamento.TabIndex = 13;
            this.lblDepartamento.Text = "DEPARTAMENTO";
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.Location = new System.Drawing.Point(19, 33);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(56, 13);
            this.lblUsuario.TabIndex = 14;
            this.lblUsuario.Text = "USUARIO";
            // 
            // mcFecha
            // 
            this.mcFecha.Location = new System.Drawing.Point(563, 175);
            this.mcFecha.Name = "mcFecha";
            this.mcFecha.TabIndex = 15;
            this.mcFecha.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.mcFecha_DateChanged);
            // 
            // lblEquipo
            // 
            this.lblEquipo.AutoSize = true;
            this.lblEquipo.Location = new System.Drawing.Point(560, 153);
            this.lblEquipo.Name = "lblEquipo";
            this.lblEquipo.Size = new System.Drawing.Size(219, 13);
            this.lblEquipo.TabIndex = 17;
            this.lblEquipo.Text = "FECHA EN QUE OCURRIO LA INCIDENCIA";
            this.lblEquipo.Click += new System.EventHandler(this.lblEquipo_Click);
            // 
            // lblDispositivo
            // 
            this.lblDispositivo.AutoSize = true;
            this.lblDispositivo.Location = new System.Drawing.Point(560, 96);
            this.lblDispositivo.Name = "lblDispositivo";
            this.lblDispositivo.Size = new System.Drawing.Size(75, 13);
            this.lblDispositivo.TabIndex = 18;
            this.lblDispositivo.Text = "DISPOSITIVO";
            // 
            // txtDispositivo
            // 
            this.txtDispositivo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtDispositivo.Location = new System.Drawing.Point(563, 112);
            this.txtDispositivo.Name = "txtDispositivo";
            this.txtDispositivo.Size = new System.Drawing.Size(245, 20);
            this.txtDispositivo.TabIndex = 19;
            // 
            // FrmAltaIncidencia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(843, 405);
            this.Controls.Add(this.txtDispositivo);
            this.Controls.Add(this.lblDispositivo);
            this.Controls.Add(this.lblEquipo);
            this.Controls.Add(this.mcFecha);
            this.Controls.Add(this.lblUsuario);
            this.Controls.Add(this.lblDepartamento);
            this.Controls.Add(this.txtDepartamento);
            this.Controls.Add(this.cmbUsuario);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnRegistrar);
            this.Controls.Add(this.lblDescripcion);
            this.Controls.Add(this.txtDescripcion);
            this.Controls.Add(this.grpTipos);
            this.Name = "FrmAltaIncidencia";
            this.Text = "Alta de Incidencia";
            this.Load += new System.EventHandler(this.FrmAltaIncidencia_Load);
            this.grpTipos.ResumeLayout(false);
            this.grpTipos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grpTipos;
        private System.Windows.Forms.RadioButton rdHardware;
        private System.Windows.Forms.RadioButton rdSoftware;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.Label lblDescripcion;
        private System.Windows.Forms.Button btnRegistrar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.ComboBox cmbUsuario;
        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.Label lblDepartamento;
        private System.Windows.Forms.TextBox txtDepartamento;
        private System.Windows.Forms.MonthCalendar mcFecha;
        private System.Windows.Forms.Label lblEquipo;
        private System.Windows.Forms.TextBox txtDispositivo;
        private System.Windows.Forms.Label lblDispositivo;
    }
}