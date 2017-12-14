namespace InterceramicApp
{
    partial class frmAsignarIncidencia
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
            this.lblClave = new System.Windows.Forms.Label();
            this.txtTipo = new System.Windows.Forms.TextBox();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.lblTipo = new System.Windows.Forms.Label();
            this.lblDescripcion = new System.Windows.Forms.Label();
            this.cmbClaveUsuario = new System.Windows.Forms.ComboBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lblClaveUsuario = new System.Windows.Forms.Label();
            this.btnAsignar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbBaja = new System.Windows.Forms.RadioButton();
            this.rdMedia = new System.Windows.Forms.RadioButton();
            this.rdAlta = new System.Windows.Forms.RadioButton();
            this.lblPrioridad = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // cmbClave
            // 
            this.cmbClave.FormattingEnabled = true;
            this.cmbClave.Location = new System.Drawing.Point(12, 45);
            this.cmbClave.Name = "cmbClave";
            this.cmbClave.Size = new System.Drawing.Size(183, 21);
            this.cmbClave.TabIndex = 1;
            this.cmbClave.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // lblClave
            // 
            this.lblClave.AutoSize = true;
            this.lblClave.Location = new System.Drawing.Point(12, 29);
            this.lblClave.Name = "lblClave";
            this.lblClave.Size = new System.Drawing.Size(41, 13);
            this.lblClave.TabIndex = 2;
            this.lblClave.Text = "CLAVE";
            // 
            // txtTipo
            // 
            this.txtTipo.Location = new System.Drawing.Point(12, 101);
            this.txtTipo.Name = "txtTipo";
            this.txtTipo.ReadOnly = true;
            this.txtTipo.Size = new System.Drawing.Size(183, 20);
            this.txtTipo.TabIndex = 3;
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtDescripcion.Location = new System.Drawing.Point(12, 152);
            this.txtDescripcion.MaxLength = 140;
            this.txtDescripcion.Multiline = true;
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.ReadOnly = true;
            this.txtDescripcion.Size = new System.Drawing.Size(430, 114);
            this.txtDescripcion.TabIndex = 4;
            // 
            // lblTipo
            // 
            this.lblTipo.AutoSize = true;
            this.lblTipo.Location = new System.Drawing.Point(12, 85);
            this.lblTipo.Name = "lblTipo";
            this.lblTipo.Size = new System.Drawing.Size(32, 13);
            this.lblTipo.TabIndex = 6;
            this.lblTipo.Text = "TIPO";
            // 
            // lblDescripcion
            // 
            this.lblDescripcion.AutoSize = true;
            this.lblDescripcion.Location = new System.Drawing.Point(12, 136);
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Size = new System.Drawing.Size(80, 13);
            this.lblDescripcion.TabIndex = 8;
            this.lblDescripcion.Text = "DESCRIPCION";
            // 
            // cmbClaveUsuario
            // 
            this.cmbClaveUsuario.FormattingEnabled = true;
            this.cmbClaveUsuario.Location = new System.Drawing.Point(12, 291);
            this.cmbClaveUsuario.Name = "cmbClaveUsuario";
            this.cmbClaveUsuario.Size = new System.Drawing.Size(183, 21);
            this.cmbClaveUsuario.TabIndex = 9;
            this.cmbClaveUsuario.SelectedIndexChanged += new System.EventHandler(this.cmbClaveUsuario_SelectedIndexChanged);
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(12, 326);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(54, 13);
            this.lblNombre.TabIndex = 11;
            this.lblNombre.Text = "NOMBRE";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(12, 342);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.ReadOnly = true;
            this.txtNombre.Size = new System.Drawing.Size(430, 20);
            this.txtNombre.TabIndex = 10;
            this.txtNombre.TextChanged += new System.EventHandler(this.txtNombre_TextChanged);
            // 
            // lblClaveUsuario
            // 
            this.lblClaveUsuario.AutoSize = true;
            this.lblClaveUsuario.Location = new System.Drawing.Point(9, 275);
            this.lblClaveUsuario.Name = "lblClaveUsuario";
            this.lblClaveUsuario.Size = new System.Drawing.Size(115, 13);
            this.lblClaveUsuario.TabIndex = 12;
            this.lblClaveUsuario.Text = "CLAVE DEL TECNICO";
            // 
            // btnAsignar
            // 
            this.btnAsignar.Location = new System.Drawing.Point(223, 491);
            this.btnAsignar.Name = "btnAsignar";
            this.btnAsignar.Size = new System.Drawing.Size(75, 23);
            this.btnAsignar.TabIndex = 13;
            this.btnAsignar.Text = "Asignar";
            this.btnAsignar.UseVisualStyleBackColor = true;
            this.btnAsignar.Click += new System.EventHandler(this.btnAsignar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(314, 491);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 14;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnCerrar
            // 
            this.btnCerrar.Location = new System.Drawing.Point(405, 491);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(75, 23);
            this.btnCerrar.TabIndex = 15;
            this.btnCerrar.Text = "Cerrar";
            this.btnCerrar.UseVisualStyleBackColor = true;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbBaja);
            this.groupBox1.Controls.Add(this.rdMedia);
            this.groupBox1.Controls.Add(this.rdAlta);
            this.groupBox1.Location = new System.Drawing.Point(462, 101);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(219, 114);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            // 
            // rbBaja
            // 
            this.rbBaja.AutoSize = true;
            this.rbBaja.Location = new System.Drawing.Point(6, 78);
            this.rbBaja.Name = "rbBaja";
            this.rbBaja.Size = new System.Drawing.Size(51, 17);
            this.rbBaja.TabIndex = 2;
            this.rbBaja.TabStop = true;
            this.rbBaja.Text = "BAJA";
            this.rbBaja.UseVisualStyleBackColor = true;
            // 
            // rdMedia
            // 
            this.rdMedia.AutoSize = true;
            this.rdMedia.Location = new System.Drawing.Point(6, 51);
            this.rdMedia.Name = "rdMedia";
            this.rdMedia.Size = new System.Drawing.Size(59, 17);
            this.rdMedia.TabIndex = 1;
            this.rdMedia.TabStop = true;
            this.rdMedia.Text = "MEDIA";
            this.rdMedia.UseVisualStyleBackColor = true;
            // 
            // rdAlta
            // 
            this.rdAlta.AutoSize = true;
            this.rdAlta.Location = new System.Drawing.Point(6, 24);
            this.rdAlta.Name = "rdAlta";
            this.rdAlta.Size = new System.Drawing.Size(52, 17);
            this.rdAlta.TabIndex = 0;
            this.rdAlta.TabStop = true;
            this.rdAlta.Text = "ALTA";
            this.rdAlta.UseVisualStyleBackColor = true;
            // 
            // lblPrioridad
            // 
            this.lblPrioridad.AutoSize = true;
            this.lblPrioridad.Location = new System.Drawing.Point(459, 85);
            this.lblPrioridad.Name = "lblPrioridad";
            this.lblPrioridad.Size = new System.Drawing.Size(48, 13);
            this.lblPrioridad.TabIndex = 17;
            this.lblPrioridad.Text = "Prioridad";
            this.lblPrioridad.Click += new System.EventHandler(this.lblPrioridad_Click);
            // 
            // frmAsignarIncidencia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(703, 554);
            this.Controls.Add(this.lblPrioridad);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnAsignar);
            this.Controls.Add(this.lblClaveUsuario);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.cmbClaveUsuario);
            this.Controls.Add(this.lblDescripcion);
            this.Controls.Add(this.lblTipo);
            this.Controls.Add(this.txtDescripcion);
            this.Controls.Add(this.txtTipo);
            this.Controls.Add(this.lblClave);
            this.Controls.Add(this.cmbClave);
            this.Name = "frmAsignarIncidencia";
            this.Text = "ASIGNACION DE INCIDENCIA";
            this.Load += new System.EventHandler(this.frmAsignarIncidencia_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbClave;
        private System.Windows.Forms.Label lblClave;
        private System.Windows.Forms.TextBox txtTipo;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.Label lblTipo;
        private System.Windows.Forms.Label lblDescripcion;
        private System.Windows.Forms.ComboBox cmbClaveUsuario;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label lblClaveUsuario;
        private System.Windows.Forms.Button btnAsignar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbBaja;
        private System.Windows.Forms.RadioButton rdMedia;
        private System.Windows.Forms.RadioButton rdAlta;
        private System.Windows.Forms.Label lblPrioridad;
    }
}