namespace InterceramicApp
{
    partial class frmEvaluar_tecnico
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
            this.cmbIncidencia = new System.Windows.Forms.ComboBox();
            this.txtDecripcion = new System.Windows.Forms.TextBox();
            this.txtTecnico = new System.Windows.Forms.TextBox();
            this.btnEvaluar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.lblIncidencia = new System.Windows.Forms.Label();
            this.lblTecnico = new System.Windows.Forms.Label();
            this.lblDescripcion = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cmbIncidencia
            // 
            this.cmbIncidencia.FormattingEnabled = true;
            this.cmbIncidencia.Location = new System.Drawing.Point(21, 26);
            this.cmbIncidencia.Name = "cmbIncidencia";
            this.cmbIncidencia.Size = new System.Drawing.Size(121, 21);
            this.cmbIncidencia.TabIndex = 0;
            // 
            // txtDecripcion
            // 
            this.txtDecripcion.Location = new System.Drawing.Point(21, 96);
            this.txtDecripcion.Multiline = true;
            this.txtDecripcion.Name = "txtDecripcion";
            this.txtDecripcion.ReadOnly = true;
            this.txtDecripcion.Size = new System.Drawing.Size(389, 310);
            this.txtDecripcion.TabIndex = 1;
            // 
            // txtTecnico
            // 
            this.txtTecnico.Location = new System.Drawing.Point(148, 27);
            this.txtTecnico.Name = "txtTecnico";
            this.txtTecnico.ReadOnly = true;
            this.txtTecnico.Size = new System.Drawing.Size(379, 20);
            this.txtTecnico.TabIndex = 2;
            // 
            // btnEvaluar
            // 
            this.btnEvaluar.Location = new System.Drawing.Point(437, 111);
            this.btnEvaluar.Name = "btnEvaluar";
            this.btnEvaluar.Size = new System.Drawing.Size(75, 23);
            this.btnEvaluar.TabIndex = 3;
            this.btnEvaluar.Text = "Evaluar";
            this.btnEvaluar.UseVisualStyleBackColor = true;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(437, 176);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 4;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            // 
            // btnCerrar
            // 
            this.btnCerrar.Location = new System.Drawing.Point(437, 238);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(75, 23);
            this.btnCerrar.TabIndex = 5;
            this.btnCerrar.Text = "Cerrar";
            this.btnCerrar.UseVisualStyleBackColor = true;
            // 
            // lblIncidencia
            // 
            this.lblIncidencia.AutoSize = true;
            this.lblIncidencia.Location = new System.Drawing.Point(18, 11);
            this.lblIncidencia.Name = "lblIncidencia";
            this.lblIncidencia.Size = new System.Drawing.Size(118, 13);
            this.lblIncidencia.TabIndex = 6;
            this.lblIncidencia.Text = "Clave De La Incidencia";
            // 
            // lblTecnico
            // 
            this.lblTecnico.AutoSize = true;
            this.lblTecnico.Location = new System.Drawing.Point(145, 11);
            this.lblTecnico.Name = "lblTecnico";
            this.lblTecnico.Size = new System.Drawing.Size(46, 13);
            this.lblTecnico.TabIndex = 7;
            this.lblTecnico.Text = "Técnico";
            // 
            // lblDescripcion
            // 
            this.lblDescripcion.AutoSize = true;
            this.lblDescripcion.Location = new System.Drawing.Point(18, 80);
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Size = new System.Drawing.Size(63, 13);
            this.lblDescripcion.TabIndex = 8;
            this.lblDescripcion.Text = "Descripcion";
            // 
            // frmEvaluar_tecnico
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(548, 418);
            this.Controls.Add(this.lblDescripcion);
            this.Controls.Add(this.lblTecnico);
            this.Controls.Add(this.lblIncidencia);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnEvaluar);
            this.Controls.Add(this.txtTecnico);
            this.Controls.Add(this.txtDecripcion);
            this.Controls.Add(this.cmbIncidencia);
            this.Name = "frmEvaluar_tecnico";
            this.Text = "Evaluar Incidencia";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbIncidencia;
        private System.Windows.Forms.TextBox txtDecripcion;
        private System.Windows.Forms.TextBox txtTecnico;
        private System.Windows.Forms.Button btnEvaluar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.Label lblIncidencia;
        private System.Windows.Forms.Label lblTecnico;
        private System.Windows.Forms.Label lblDescripcion;
    }
}