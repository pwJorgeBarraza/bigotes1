namespace InterceramicApp
{
    partial class frmEvaluacion
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
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.txtTecnico = new System.Windows.Forms.TextBox();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.txtFechaI = new System.Windows.Forms.TextBox();
            this.txtFechaF = new System.Windows.Forms.TextBox();
            this.txtTiempo = new System.Windows.Forms.TextBox();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.lblTecnico = new System.Windows.Forms.Label();
            this.lblDescripcion = new System.Windows.Forms.Label();
            this.lblFechaInicial = new System.Windows.Forms.Label();
            this.lblFechaFinal = new System.Windows.Forms.Label();
            this.lblTiempoEsperado = new System.Windows.Forms.Label();
            this.lblTiempoUsado = new System.Windows.Forms.Label();
            this.txtTiempoR = new System.Windows.Forms.TextBox();
            this.btnEvaluar = new System.Windows.Forms.Button();
            this.rdMalo = new System.Windows.Forms.RadioButton();
            this.lblQ1 = new System.Windows.Forms.Label();
            this.rdBueno = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // cmbClave
            // 
            this.cmbClave.FormattingEnabled = true;
            this.cmbClave.Location = new System.Drawing.Point(24, 24);
            this.cmbClave.Name = "cmbClave";
            this.cmbClave.Size = new System.Drawing.Size(121, 21);
            this.cmbClave.TabIndex = 0;
            this.cmbClave.SelectedIndexChanged += new System.EventHandler(this.cmbClave_SelectedIndexChanged);
            // 
            // lblClave
            // 
            this.lblClave.AutoSize = true;
            this.lblClave.Location = new System.Drawing.Point(21, 8);
            this.lblClave.Name = "lblClave";
            this.lblClave.Size = new System.Drawing.Size(34, 13);
            this.lblClave.TabIndex = 1;
            this.lblClave.Text = "Clave";
            // 
            // txtUsuario
            // 
            this.txtUsuario.Location = new System.Drawing.Point(24, 71);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(312, 20);
            this.txtUsuario.TabIndex = 2;
            // 
            // txtTecnico
            // 
            this.txtTecnico.Location = new System.Drawing.Point(24, 113);
            this.txtTecnico.Name = "txtTecnico";
            this.txtTecnico.Size = new System.Drawing.Size(312, 20);
            this.txtTecnico.TabIndex = 3;
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Location = new System.Drawing.Point(24, 155);
            this.txtDescripcion.Multiline = true;
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(312, 77);
            this.txtDescripcion.TabIndex = 4;
            // 
            // txtFechaI
            // 
            this.txtFechaI.Location = new System.Drawing.Point(24, 255);
            this.txtFechaI.Name = "txtFechaI";
            this.txtFechaI.Size = new System.Drawing.Size(74, 20);
            this.txtFechaI.TabIndex = 5;
            // 
            // txtFechaF
            // 
            this.txtFechaF.Location = new System.Drawing.Point(130, 255);
            this.txtFechaF.Name = "txtFechaF";
            this.txtFechaF.Size = new System.Drawing.Size(71, 20);
            this.txtFechaF.TabIndex = 6;
            // 
            // txtTiempo
            // 
            this.txtTiempo.Location = new System.Drawing.Point(236, 255);
            this.txtTiempo.Name = "txtTiempo";
            this.txtTiempo.Size = new System.Drawing.Size(100, 20);
            this.txtTiempo.TabIndex = 7;
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.Location = new System.Drawing.Point(21, 55);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(43, 13);
            this.lblUsuario.TabIndex = 8;
            this.lblUsuario.Text = "Usuario";
            // 
            // lblTecnico
            // 
            this.lblTecnico.AutoSize = true;
            this.lblTecnico.Location = new System.Drawing.Point(21, 97);
            this.lblTecnico.Name = "lblTecnico";
            this.lblTecnico.Size = new System.Drawing.Size(46, 13);
            this.lblTecnico.TabIndex = 9;
            this.lblTecnico.Text = "Tecnico";
            // 
            // lblDescripcion
            // 
            this.lblDescripcion.AutoSize = true;
            this.lblDescripcion.Location = new System.Drawing.Point(21, 139);
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Size = new System.Drawing.Size(63, 13);
            this.lblDescripcion.TabIndex = 10;
            this.lblDescripcion.Text = "Descripción";
            // 
            // lblFechaInicial
            // 
            this.lblFechaInicial.AutoSize = true;
            this.lblFechaInicial.Location = new System.Drawing.Point(21, 239);
            this.lblFechaInicial.Name = "lblFechaInicial";
            this.lblFechaInicial.Size = new System.Drawing.Size(67, 13);
            this.lblFechaInicial.TabIndex = 11;
            this.lblFechaInicial.Text = "Fecha Inicial";
            // 
            // lblFechaFinal
            // 
            this.lblFechaFinal.AutoSize = true;
            this.lblFechaFinal.Location = new System.Drawing.Point(130, 239);
            this.lblFechaFinal.Name = "lblFechaFinal";
            this.lblFechaFinal.Size = new System.Drawing.Size(62, 13);
            this.lblFechaFinal.TabIndex = 12;
            this.lblFechaFinal.Text = "Fecha Final";
            // 
            // lblTiempoEsperado
            // 
            this.lblTiempoEsperado.AutoSize = true;
            this.lblTiempoEsperado.Location = new System.Drawing.Point(233, 239);
            this.lblTiempoEsperado.Name = "lblTiempoEsperado";
            this.lblTiempoEsperado.Size = new System.Drawing.Size(90, 13);
            this.lblTiempoEsperado.TabIndex = 13;
            this.lblTiempoEsperado.Text = "Tiempo Esperado";
            // 
            // lblTiempoUsado
            // 
            this.lblTiempoUsado.AutoSize = true;
            this.lblTiempoUsado.Location = new System.Drawing.Point(233, 8);
            this.lblTiempoUsado.Name = "lblTiempoUsado";
            this.lblTiempoUsado.Size = new System.Drawing.Size(94, 13);
            this.lblTiempoUsado.TabIndex = 15;
            this.lblTiempoUsado.Text = "Tiempo Requerido";
            // 
            // txtTiempoR
            // 
            this.txtTiempoR.Location = new System.Drawing.Point(236, 24);
            this.txtTiempoR.Name = "txtTiempoR";
            this.txtTiempoR.ReadOnly = true;
            this.txtTiempoR.Size = new System.Drawing.Size(100, 20);
            this.txtTiempoR.TabIndex = 14;
            this.txtTiempoR.TextChanged += new System.EventHandler(this.txtTiempoR_TextChanged);
            // 
            // btnEvaluar
            // 
            this.btnEvaluar.Location = new System.Drawing.Point(289, 328);
            this.btnEvaluar.Name = "btnEvaluar";
            this.btnEvaluar.Size = new System.Drawing.Size(75, 23);
            this.btnEvaluar.TabIndex = 16;
            this.btnEvaluar.Text = "Evaluar";
            this.btnEvaluar.UseVisualStyleBackColor = true;
            this.btnEvaluar.Click += new System.EventHandler(this.btnEvaluar_Click);
            // 
            // rdMalo
            // 
            this.rdMalo.AutoSize = true;
            this.rdMalo.Location = new System.Drawing.Point(79, 50);
            this.rdMalo.Name = "rdMalo";
            this.rdMalo.Size = new System.Drawing.Size(48, 17);
            this.rdMalo.TabIndex = 32;
            this.rdMalo.TabStop = true;
            this.rdMalo.Text = "Malo";
            this.rdMalo.UseVisualStyleBackColor = true;
            // 
            // lblQ1
            // 
            this.lblQ1.AutoSize = true;
            this.lblQ1.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold);
            this.lblQ1.Location = new System.Drawing.Point(6, 19);
            this.lblQ1.Name = "lblQ1";
            this.lblQ1.Size = new System.Drawing.Size(247, 14);
            this.lblQ1.TabIndex = 30;
            this.lblQ1.Text = "¿Como calificas el desempeño del tecnico?";
            // 
            // rdBueno
            // 
            this.rdBueno.AutoSize = true;
            this.rdBueno.Location = new System.Drawing.Point(6, 48);
            this.rdBueno.Name = "rdBueno";
            this.rdBueno.Size = new System.Drawing.Size(56, 17);
            this.rdBueno.TabIndex = 31;
            this.rdBueno.TabStop = true;
            this.rdBueno.Text = "Bueno";
            this.rdBueno.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblQ1);
            this.groupBox1.Controls.Add(this.rdBueno);
            this.groupBox1.Controls.Add(this.rdMalo);
            this.groupBox1.Location = new System.Drawing.Point(376, 9);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(260, 74);
            this.groupBox1.TabIndex = 39;
            this.groupBox1.TabStop = false;
            // 
            // frmEvaluacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(664, 384);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnEvaluar);
            this.Controls.Add(this.lblTiempoUsado);
            this.Controls.Add(this.txtTiempoR);
            this.Controls.Add(this.lblTiempoEsperado);
            this.Controls.Add(this.lblFechaFinal);
            this.Controls.Add(this.lblFechaInicial);
            this.Controls.Add(this.lblDescripcion);
            this.Controls.Add(this.lblTecnico);
            this.Controls.Add(this.lblUsuario);
            this.Controls.Add(this.txtTiempo);
            this.Controls.Add(this.txtFechaF);
            this.Controls.Add(this.txtFechaI);
            this.Controls.Add(this.txtDescripcion);
            this.Controls.Add(this.txtTecnico);
            this.Controls.Add(this.txtUsuario);
            this.Controls.Add(this.lblClave);
            this.Controls.Add(this.cmbClave);
            this.Name = "frmEvaluacion";
            this.Text = "frmEvaluacion";
            this.Load += new System.EventHandler(this.frmEvaluacion_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbClave;
        private System.Windows.Forms.Label lblClave;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.TextBox txtTecnico;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.TextBox txtFechaI;
        private System.Windows.Forms.TextBox txtFechaF;
        private System.Windows.Forms.TextBox txtTiempo;
        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.Label lblTecnico;
        private System.Windows.Forms.Label lblDescripcion;
        private System.Windows.Forms.Label lblFechaInicial;
        private System.Windows.Forms.Label lblFechaFinal;
        private System.Windows.Forms.Label lblTiempoEsperado;
        private System.Windows.Forms.Label lblTiempoUsado;
        private System.Windows.Forms.TextBox txtTiempoR;
        private System.Windows.Forms.Button btnEvaluar;
        private System.Windows.Forms.RadioButton rdMalo;
        private System.Windows.Forms.Label lblQ1;
        private System.Windows.Forms.RadioButton rdBueno;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}