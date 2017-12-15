namespace InterceramicApp
{
    partial class frmCab
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
            this.txtPeticion = new System.Windows.Forms.TextBox();
            this.lblPeticion = new System.Windows.Forms.Label();
            this.grpEstatus = new System.Windows.Forms.GroupBox();
            this.rbRechazado = new System.Windows.Forms.RadioButton();
            this.rdAprobado = new System.Windows.Forms.RadioButton();
            this.txtJustificacion = new System.Windows.Forms.TextBox();
            this.lblJustificacion = new System.Windows.Forms.Label();
            this.cmbDispositivo = new System.Windows.Forms.ComboBox();
            this.lblEquipo = new System.Windows.Forms.Label();
            this.btnResponder = new System.Windows.Forms.Button();
            this.lblDepartamento = new System.Windows.Forms.Label();
            this.cmbDepartamento = new System.Windows.Forms.ComboBox();
            this.grpEstatus.SuspendLayout();
            this.SuspendLayout();
            // 
            // cmbClave
            // 
            this.cmbClave.FormattingEnabled = true;
            this.cmbClave.Location = new System.Drawing.Point(23, 31);
            this.cmbClave.Name = "cmbClave";
            this.cmbClave.Size = new System.Drawing.Size(263, 21);
            this.cmbClave.TabIndex = 0;
            this.cmbClave.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // lblClave
            // 
            this.lblClave.AutoSize = true;
            this.lblClave.Location = new System.Drawing.Point(20, 15);
            this.lblClave.Name = "lblClave";
            this.lblClave.Size = new System.Drawing.Size(102, 13);
            this.lblClave.TabIndex = 1;
            this.lblClave.Text = "Numero de Solicitud";
            // 
            // txtPeticion
            // 
            this.txtPeticion.Location = new System.Drawing.Point(22, 84);
            this.txtPeticion.Multiline = true;
            this.txtPeticion.Name = "txtPeticion";
            this.txtPeticion.Size = new System.Drawing.Size(496, 322);
            this.txtPeticion.TabIndex = 2;
            // 
            // lblPeticion
            // 
            this.lblPeticion.AutoSize = true;
            this.lblPeticion.Location = new System.Drawing.Point(20, 68);
            this.lblPeticion.Name = "lblPeticion";
            this.lblPeticion.Size = new System.Drawing.Size(135, 13);
            this.lblPeticion.TabIndex = 3;
            this.lblPeticion.Text = "Descripción De La petición";
            // 
            // grpEstatus
            // 
            this.grpEstatus.Controls.Add(this.rbRechazado);
            this.grpEstatus.Controls.Add(this.rdAprobado);
            this.grpEstatus.Location = new System.Drawing.Point(558, 15);
            this.grpEstatus.Name = "grpEstatus";
            this.grpEstatus.Size = new System.Drawing.Size(226, 121);
            this.grpEstatus.TabIndex = 4;
            this.grpEstatus.TabStop = false;
            this.grpEstatus.Text = "Estatus";
            // 
            // rbRechazado
            // 
            this.rbRechazado.AutoSize = true;
            this.rbRechazado.Location = new System.Drawing.Point(34, 70);
            this.rbRechazado.Name = "rbRechazado";
            this.rbRechazado.Size = new System.Drawing.Size(80, 17);
            this.rbRechazado.TabIndex = 1;
            this.rbRechazado.TabStop = true;
            this.rbRechazado.Text = "Rechazado";
            this.rbRechazado.UseVisualStyleBackColor = true;
            // 
            // rdAprobado
            // 
            this.rdAprobado.AutoSize = true;
            this.rdAprobado.Location = new System.Drawing.Point(34, 29);
            this.rdAprobado.Name = "rdAprobado";
            this.rdAprobado.Size = new System.Drawing.Size(71, 17);
            this.rdAprobado.TabIndex = 0;
            this.rdAprobado.TabStop = true;
            this.rdAprobado.Text = "Aprobado";
            this.rdAprobado.UseVisualStyleBackColor = true;
            // 
            // txtJustificacion
            // 
            this.txtJustificacion.Location = new System.Drawing.Point(558, 172);
            this.txtJustificacion.Multiline = true;
            this.txtJustificacion.Name = "txtJustificacion";
            this.txtJustificacion.Size = new System.Drawing.Size(226, 234);
            this.txtJustificacion.TabIndex = 5;
            // 
            // lblJustificacion
            // 
            this.lblJustificacion.AutoSize = true;
            this.lblJustificacion.Location = new System.Drawing.Point(558, 153);
            this.lblJustificacion.Name = "lblJustificacion";
            this.lblJustificacion.Size = new System.Drawing.Size(65, 13);
            this.lblJustificacion.TabIndex = 6;
            this.lblJustificacion.Text = "Justificacion";
            // 
            // cmbDispositivo
            // 
            this.cmbDispositivo.FormattingEnabled = true;
            this.cmbDispositivo.Location = new System.Drawing.Point(422, 31);
            this.cmbDispositivo.Name = "cmbDispositivo";
            this.cmbDispositivo.Size = new System.Drawing.Size(96, 21);
            this.cmbDispositivo.TabIndex = 7;
            // 
            // lblEquipo
            // 
            this.lblEquipo.AutoSize = true;
            this.lblEquipo.Location = new System.Drawing.Point(436, 15);
            this.lblEquipo.Name = "lblEquipo";
            this.lblEquipo.Size = new System.Drawing.Size(58, 13);
            this.lblEquipo.TabIndex = 8;
            this.lblEquipo.Text = "Dispositivo";
            // 
            // btnResponder
            // 
            this.btnResponder.Location = new System.Drawing.Point(632, 412);
            this.btnResponder.Name = "btnResponder";
            this.btnResponder.Size = new System.Drawing.Size(75, 23);
            this.btnResponder.TabIndex = 9;
            this.btnResponder.Text = "Responder";
            this.btnResponder.UseVisualStyleBackColor = true;
            this.btnResponder.Click += new System.EventHandler(this.btnResponder_Click);
            // 
            // lblDepartamento
            // 
            this.lblDepartamento.AutoSize = true;
            this.lblDepartamento.Location = new System.Drawing.Point(299, 15);
            this.lblDepartamento.Name = "lblDepartamento";
            this.lblDepartamento.Size = new System.Drawing.Size(74, 13);
            this.lblDepartamento.TabIndex = 11;
            this.lblDepartamento.Text = "Departamento";
            // 
            // cmbDepartamento
            // 
            this.cmbDepartamento.FormattingEnabled = true;
            this.cmbDepartamento.Location = new System.Drawing.Point(302, 31);
            this.cmbDepartamento.Name = "cmbDepartamento";
            this.cmbDepartamento.Size = new System.Drawing.Size(99, 21);
            this.cmbDepartamento.TabIndex = 10;
            // 
            // frmCab
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(807, 445);
            this.Controls.Add(this.lblDepartamento);
            this.Controls.Add(this.cmbDepartamento);
            this.Controls.Add(this.btnResponder);
            this.Controls.Add(this.lblEquipo);
            this.Controls.Add(this.cmbDispositivo);
            this.Controls.Add(this.lblJustificacion);
            this.Controls.Add(this.txtJustificacion);
            this.Controls.Add(this.grpEstatus);
            this.Controls.Add(this.lblPeticion);
            this.Controls.Add(this.txtPeticion);
            this.Controls.Add(this.lblClave);
            this.Controls.Add(this.cmbClave);
            this.Name = "frmCab";
            this.Text = "frmCab";
            this.Load += new System.EventHandler(this.frmCab_Load);
            this.grpEstatus.ResumeLayout(false);
            this.grpEstatus.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbClave;
        private System.Windows.Forms.Label lblClave;
        private System.Windows.Forms.TextBox txtPeticion;
        private System.Windows.Forms.Label lblPeticion;
        private System.Windows.Forms.GroupBox grpEstatus;
        private System.Windows.Forms.RadioButton rbRechazado;
        private System.Windows.Forms.RadioButton rdAprobado;
        private System.Windows.Forms.TextBox txtJustificacion;
        private System.Windows.Forms.Label lblJustificacion;
        private System.Windows.Forms.ComboBox cmbDispositivo;
        private System.Windows.Forms.Label lblEquipo;
        private System.Windows.Forms.Button btnResponder;
        private System.Windows.Forms.Label lblDepartamento;
        private System.Windows.Forms.ComboBox cmbDepartamento;
    }
}