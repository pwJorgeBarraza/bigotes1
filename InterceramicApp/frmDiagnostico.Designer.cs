namespace InterceramicApp
{
    partial class frmDiagnostico
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
            this.interceramicDataSet1 = new InterceramicApp.InterceramicDataSet();
            this.lblNumero = new System.Windows.Forms.Label();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.txtTiempo = new System.Windows.Forms.TextBox();
            this.lblTiempo = new System.Windows.Forms.Label();
            this.lblDescripcion = new System.Windows.Forms.Label();
            this.btnDiagnosticar = new System.Windows.Forms.Button();
            this.txtTecnico = new System.Windows.Forms.TextBox();
            this.lblTecnico = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.interceramicDataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbClave
            // 
            this.cmbClave.FormattingEnabled = true;
            this.cmbClave.Location = new System.Drawing.Point(22, 44);
            this.cmbClave.Name = "cmbClave";
            this.cmbClave.Size = new System.Drawing.Size(121, 21);
            this.cmbClave.TabIndex = 0;
            this.cmbClave.SelectedIndexChanged += new System.EventHandler(this.cmbClave_SelectedIndexChanged);
            // 
            // interceramicDataSet1
            // 
            this.interceramicDataSet1.DataSetName = "InterceramicDataSet";
            this.interceramicDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // lblNumero
            // 
            this.lblNumero.AutoSize = true;
            this.lblNumero.Location = new System.Drawing.Point(22, 25);
            this.lblNumero.Name = "lblNumero";
            this.lblNumero.Size = new System.Drawing.Size(34, 13);
            this.lblNumero.TabIndex = 1;
            this.lblNumero.Text = "Clave";
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Location = new System.Drawing.Point(25, 110);
            this.txtDescripcion.Multiline = true;
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(485, 214);
            this.txtDescripcion.TabIndex = 2;
            this.txtDescripcion.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // txtTiempo
            // 
            this.txtTiempo.Location = new System.Drawing.Point(165, 45);
            this.txtTiempo.Name = "txtTiempo";
            this.txtTiempo.Size = new System.Drawing.Size(138, 20);
            this.txtTiempo.TabIndex = 3;
            // 
            // lblTiempo
            // 
            this.lblTiempo.AutoSize = true;
            this.lblTiempo.Location = new System.Drawing.Point(162, 29);
            this.lblTiempo.Name = "lblTiempo";
            this.lblTiempo.Size = new System.Drawing.Size(42, 13);
            this.lblTiempo.TabIndex = 4;
            this.lblTiempo.Text = "Tiempo";
            // 
            // lblDescripcion
            // 
            this.lblDescripcion.AutoSize = true;
            this.lblDescripcion.Location = new System.Drawing.Point(22, 94);
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Size = new System.Drawing.Size(63, 13);
            this.lblDescripcion.TabIndex = 5;
            this.lblDescripcion.Text = "Descripcion";
            // 
            // btnDiagnosticar
            // 
            this.btnDiagnosticar.Location = new System.Drawing.Point(527, 197);
            this.btnDiagnosticar.Name = "btnDiagnosticar";
            this.btnDiagnosticar.Size = new System.Drawing.Size(75, 23);
            this.btnDiagnosticar.TabIndex = 6;
            this.btnDiagnosticar.Text = "Diagnosticar";
            this.btnDiagnosticar.UseVisualStyleBackColor = true;
            this.btnDiagnosticar.Click += new System.EventHandler(this.btnDiagnosticar_Click);
            // 
            // txtTecnico
            // 
            this.txtTecnico.Location = new System.Drawing.Point(328, 45);
            this.txtTecnico.Name = "txtTecnico";
            this.txtTecnico.Size = new System.Drawing.Size(274, 20);
            this.txtTecnico.TabIndex = 7;
            // 
            // lblTecnico
            // 
            this.lblTecnico.AutoSize = true;
            this.lblTecnico.Location = new System.Drawing.Point(325, 29);
            this.lblTecnico.Name = "lblTecnico";
            this.lblTecnico.Size = new System.Drawing.Size(46, 13);
            this.lblTecnico.TabIndex = 8;
            this.lblTecnico.Text = "Técnico";
            // 
            // frmDiagnostico
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(621, 362);
            this.Controls.Add(this.lblTecnico);
            this.Controls.Add(this.txtTecnico);
            this.Controls.Add(this.btnDiagnosticar);
            this.Controls.Add(this.lblDescripcion);
            this.Controls.Add(this.lblTiempo);
            this.Controls.Add(this.txtTiempo);
            this.Controls.Add(this.txtDescripcion);
            this.Controls.Add(this.lblNumero);
            this.Controls.Add(this.cmbClave);
            this.Name = "frmDiagnostico";
            this.Text = "Diagnostico";
            this.Load += new System.EventHandler(this.frmDiagnostico_Load);
            ((System.ComponentModel.ISupportInitialize)(this.interceramicDataSet1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbClave;
        private InterceramicDataSet interceramicDataSet1;
        private System.Windows.Forms.Label lblNumero;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.TextBox txtTiempo;
        private System.Windows.Forms.Label lblTiempo;
        private System.Windows.Forms.Label lblDescripcion;
        private System.Windows.Forms.Button btnDiagnosticar;
        private System.Windows.Forms.TextBox txtTecnico;
        private System.Windows.Forms.Label lblTecnico;
    }
}