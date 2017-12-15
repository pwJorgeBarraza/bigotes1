namespace InterceramicApp
{
    partial class frmAltaUsuario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAltaUsuario));
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtNombreUsuario = new System.Windows.Forms.TextBox();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.txtClave = new System.Windows.Forms.TextBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.lblContraseña = new System.Windows.Forms.Label();
            this.pbInterceramic = new System.Windows.Forms.PictureBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.lblEspecialidad = new System.Windows.Forms.Label();
            this.txtEspecialidad = new System.Windows.Forms.TextBox();
            this.grpTipo = new System.Windows.Forms.GroupBox();
            this.rdUsuario = new System.Windows.Forms.RadioButton();
            this.rdTecnico = new System.Windows.Forms.RadioButton();
            this.rdAdmin = new System.Windows.Forms.RadioButton();
            this.lblDepartamento = new System.Windows.Forms.Label();
            this.cmbDepartamento = new System.Windows.Forms.ComboBox();
<<<<<<< HEAD
            this.rbCab = new System.Windows.Forms.RadioButton();
=======
>>>>>>> master
            ((System.ComponentModel.ISupportInitialize)(this.pbInterceramic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.grpTipo.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtNombre
            // 
            this.txtNombre.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtNombre.Location = new System.Drawing.Point(14, 187);
            this.txtNombre.MaxLength = 60;
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(338, 20);
            this.txtNombre.TabIndex = 0;
            this.txtNombre.TextChanged += new System.EventHandler(this.txtNombre_TextChanged);
            this.txtNombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNombre_KeyPress);
            // 
            // txtNombreUsuario
            // 
            this.txtNombreUsuario.Location = new System.Drawing.Point(14, 268);
            this.txtNombreUsuario.MaxLength = 16;
            this.txtNombreUsuario.Name = "txtNombreUsuario";
            this.txtNombreUsuario.Size = new System.Drawing.Size(338, 20);
            this.txtNombreUsuario.TabIndex = 1;
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnGuardar.Location = new System.Drawing.Point(135, 445);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(75, 23);
            this.btnGuardar.TabIndex = 2;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(273, 445);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 3;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.BackColor = System.Drawing.Color.Red;
            this.btnSalir.Location = new System.Drawing.Point(398, 445);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 23);
            this.btnSalir.TabIndex = 4;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // txtClave
            // 
            this.txtClave.Location = new System.Drawing.Point(14, 340);
            this.txtClave.MaxLength = 16;
            this.txtClave.Name = "txtClave";
            this.txtClave.PasswordChar = '♦';
            this.txtClave.Size = new System.Drawing.Size(338, 20);
            this.txtClave.TabIndex = 5;
            this.txtClave.TextChanged += new System.EventHandler(this.txtClave_TextChanged);
            this.txtClave.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtClave_KeyPress);
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.Location = new System.Drawing.Point(146, 161);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(85, 20);
            this.lblNombre.TabIndex = 6;
            this.lblNombre.Text = "NOMBRE";
            this.lblNombre.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsuario.Location = new System.Drawing.Point(144, 235);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(91, 20);
            this.lblUsuario.TabIndex = 7;
            this.lblUsuario.Text = "USUARIO";
            // 
            // lblContraseña
            // 
            this.lblContraseña.AutoSize = true;
            this.lblContraseña.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblContraseña.Location = new System.Drawing.Point(123, 306);
            this.lblContraseña.Name = "lblContraseña";
            this.lblContraseña.Size = new System.Drawing.Size(129, 20);
            this.lblContraseña.TabIndex = 8;
            this.lblContraseña.Text = "CONTRASEÑA";
            // 
            // pbInterceramic
            // 
            this.pbInterceramic.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pbInterceramic.BackgroundImage")));
            this.pbInterceramic.Image = ((System.Drawing.Image)(resources.GetObject("pbInterceramic.Image")));
            this.pbInterceramic.Location = new System.Drawing.Point(455, 12);
            this.pbInterceramic.Name = "pbInterceramic";
            this.pbInterceramic.Size = new System.Drawing.Size(124, 120);
            this.pbInterceramic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbInterceramic.TabIndex = 9;
            this.pbInterceramic.TabStop = false;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // lblEspecialidad
            // 
            this.lblEspecialidad.AutoSize = true;
            this.lblEspecialidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEspecialidad.Location = new System.Drawing.Point(451, 161);
            this.lblEspecialidad.Name = "lblEspecialidad";
            this.lblEspecialidad.Size = new System.Drawing.Size(140, 20);
            this.lblEspecialidad.TabIndex = 11;
            this.lblEspecialidad.Text = "ESPECIALIDAD";
            // 
            // txtEspecialidad
            // 
            this.txtEspecialidad.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtEspecialidad.Location = new System.Drawing.Point(398, 187);
            this.txtEspecialidad.MaxLength = 60;
            this.txtEspecialidad.Name = "txtEspecialidad";
            this.txtEspecialidad.Size = new System.Drawing.Size(235, 20);
            this.txtEspecialidad.TabIndex = 10;
            this.txtEspecialidad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtEspecialidad_KeyPress);
            // 
            // grpTipo
            // 
<<<<<<< HEAD
            this.grpTipo.Controls.Add(this.rbCab);
=======
>>>>>>> master
            this.grpTipo.Controls.Add(this.rdUsuario);
            this.grpTipo.Controls.Add(this.rdTecnico);
            this.grpTipo.Controls.Add(this.rdAdmin);
            this.grpTipo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpTipo.Location = new System.Drawing.Point(398, 235);
            this.grpTipo.Name = "grpTipo";
<<<<<<< HEAD
            this.grpTipo.Size = new System.Drawing.Size(200, 151);
=======
            this.grpTipo.Size = new System.Drawing.Size(200, 125);
>>>>>>> master
            this.grpTipo.TabIndex = 12;
            this.grpTipo.TabStop = false;
            this.grpTipo.Text = "TIPO DE USUARIO";
            // 
            // rdUsuario
            // 
            this.rdUsuario.AutoSize = true;
            this.rdUsuario.Location = new System.Drawing.Point(7, 93);
            this.rdUsuario.Name = "rdUsuario";
            this.rdUsuario.Size = new System.Drawing.Size(109, 24);
            this.rdUsuario.TabIndex = 2;
            this.rdUsuario.TabStop = true;
            this.rdUsuario.Text = "USUARIO";
            this.rdUsuario.UseVisualStyleBackColor = true;
            // 
            // rdTecnico
            // 
            this.rdTecnico.AutoSize = true;
            this.rdTecnico.Location = new System.Drawing.Point(7, 64);
            this.rdTecnico.Name = "rdTecnico";
            this.rdTecnico.Size = new System.Drawing.Size(104, 24);
            this.rdTecnico.TabIndex = 1;
            this.rdTecnico.TabStop = true;
            this.rdTecnico.Text = "TECNICO";
            this.rdTecnico.UseVisualStyleBackColor = true;
            // 
            // rdAdmin
            // 
            this.rdAdmin.AutoSize = true;
            this.rdAdmin.Location = new System.Drawing.Point(7, 32);
            this.rdAdmin.Name = "rdAdmin";
            this.rdAdmin.Size = new System.Drawing.Size(176, 24);
            this.rdAdmin.TabIndex = 0;
            this.rdAdmin.TabStop = true;
            this.rdAdmin.Text = "ADMINISTRADOR";
            this.rdAdmin.UseVisualStyleBackColor = true;
            // 
            // lblDepartamento
            // 
            this.lblDepartamento.AutoSize = true;
            this.lblDepartamento.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDepartamento.Location = new System.Drawing.Point(699, 161);
            this.lblDepartamento.Name = "lblDepartamento";
            this.lblDepartamento.Size = new System.Drawing.Size(153, 20);
            this.lblDepartamento.TabIndex = 13;
            this.lblDepartamento.Text = "DEPARTAMENTO";
            // 
            // cmbDepartamento
            // 
            this.cmbDepartamento.FormattingEnabled = true;
            this.cmbDepartamento.Location = new System.Drawing.Point(693, 187);
            this.cmbDepartamento.Name = "cmbDepartamento";
            this.cmbDepartamento.Size = new System.Drawing.Size(172, 21);
            this.cmbDepartamento.TabIndex = 14;
            this.cmbDepartamento.SelectedIndexChanged += new System.EventHandler(this.cmbDepartamento_SelectedIndexChanged);
            // 
<<<<<<< HEAD
            // rbCab
            // 
            this.rbCab.AutoSize = true;
            this.rbCab.Location = new System.Drawing.Point(7, 123);
            this.rbCab.Name = "rbCab";
            this.rbCab.Size = new System.Drawing.Size(63, 24);
            this.rbCab.TabIndex = 3;
            this.rbCab.TabStop = true;
            this.rbCab.Text = "CAB";
            this.rbCab.UseVisualStyleBackColor = true;
            // 
=======
>>>>>>> master
            // frmAltaUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(911, 506);
            this.Controls.Add(this.cmbDepartamento);
            this.Controls.Add(this.lblDepartamento);
            this.Controls.Add(this.grpTipo);
            this.Controls.Add(this.lblEspecialidad);
            this.Controls.Add(this.txtEspecialidad);
            this.Controls.Add(this.pbInterceramic);
            this.Controls.Add(this.lblContraseña);
            this.Controls.Add(this.lblUsuario);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.txtClave);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.txtNombreUsuario);
            this.Controls.Add(this.txtNombre);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmAltaUsuario";
            this.Text = "Alta de Usuario";
            this.Load += new System.EventHandler(this.frmAltaUsuario_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbInterceramic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.grpTipo.ResumeLayout(false);
            this.grpTipo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtNombreUsuario;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.TextBox txtClave;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.Label lblContraseña;
        private System.Windows.Forms.PictureBox pbInterceramic;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.GroupBox grpTipo;
        private System.Windows.Forms.RadioButton rdTecnico;
        private System.Windows.Forms.RadioButton rdAdmin;
        private System.Windows.Forms.Label lblEspecialidad;
        private System.Windows.Forms.TextBox txtEspecialidad;
        private System.Windows.Forms.RadioButton rdUsuario;
        private System.Windows.Forms.ComboBox cmbDepartamento;
        private System.Windows.Forms.Label lblDepartamento;
<<<<<<< HEAD
        private System.Windows.Forms.RadioButton rbCab;
=======
>>>>>>> master
    }
}