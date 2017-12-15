namespace InterceramicApp
{
    partial class frmAltaCatalogo
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
            this.lblTiempo = new System.Windows.Forms.Label();
            this.lblSolucion1 = new System.Windows.Forms.Label();
            this.lblIncidencia = new System.Windows.Forms.Label();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnAlta = new System.Windows.Forms.Button();
            this.txtTiempo = new System.Windows.Forms.TextBox();
            this.txtSolucion1 = new System.Windows.Forms.TextBox();
            this.txtIncidencia = new System.Windows.Forms.TextBox();
            this.lblSolucion2 = new System.Windows.Forms.Label();
            this.txtSolucion2 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblTiempo
            // 
            this.lblTiempo.AutoSize = true;
            this.lblTiempo.Location = new System.Drawing.Point(261, 27);
            this.lblTiempo.Name = "lblTiempo";
            this.lblTiempo.Size = new System.Drawing.Size(88, 13);
            this.lblTiempo.TabIndex = 15;
            this.lblTiempo.Text = "Tiempo Estimado";
            // 
            // lblSolucion1
            // 
            this.lblSolucion1.AutoSize = true;
            this.lblSolucion1.Location = new System.Drawing.Point(24, 114);
            this.lblSolucion1.Name = "lblSolucion1";
            this.lblSolucion1.Size = new System.Drawing.Size(54, 13);
            this.lblSolucion1.TabIndex = 14;
            this.lblSolucion1.Text = "Solucion1";
            // 
            // lblIncidencia
            // 
            this.lblIncidencia.AutoSize = true;
            this.lblIncidencia.Location = new System.Drawing.Point(24, 27);
            this.lblIncidencia.Name = "lblIncidencia";
            this.lblIncidencia.Size = new System.Drawing.Size(56, 13);
            this.lblIncidencia.TabIndex = 13;
            this.lblIncidencia.Text = "Incidencia";
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(231, 342);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 12;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            // 
            // btnAlta
            // 
            this.btnAlta.Location = new System.Drawing.Point(123, 342);
            this.btnAlta.Name = "btnAlta";
            this.btnAlta.Size = new System.Drawing.Size(75, 23);
            this.btnAlta.TabIndex = 11;
            this.btnAlta.Text = "Alta";
            this.btnAlta.UseVisualStyleBackColor = true;
            this.btnAlta.Click += new System.EventHandler(this.btnAlta_Click);
            // 
            // txtTiempo
            // 
            this.txtTiempo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtTiempo.Location = new System.Drawing.Point(264, 43);
            this.txtTiempo.MaxLength = 15;
            this.txtTiempo.Name = "txtTiempo";
            this.txtTiempo.Size = new System.Drawing.Size(141, 20);
            this.txtTiempo.TabIndex = 10;
            // 
            // txtSolucion1
            // 
            this.txtSolucion1.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtSolucion1.Location = new System.Drawing.Point(24, 130);
            this.txtSolucion1.MaxLength = 250;
            this.txtSolucion1.Multiline = true;
            this.txtSolucion1.Name = "txtSolucion1";
            this.txtSolucion1.Size = new System.Drawing.Size(174, 179);
            this.txtSolucion1.TabIndex = 9;
            // 
            // txtIncidencia
            // 
            this.txtIncidencia.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtIncidencia.Location = new System.Drawing.Point(24, 44);
            this.txtIncidencia.MaxLength = 100;
            this.txtIncidencia.Multiline = true;
            this.txtIncidencia.Name = "txtIncidencia";
            this.txtIncidencia.Size = new System.Drawing.Size(231, 60);
            this.txtIncidencia.TabIndex = 8;
            // 
            // lblSolucion2
            // 
            this.lblSolucion2.AutoSize = true;
            this.lblSolucion2.Location = new System.Drawing.Point(231, 114);
            this.lblSolucion2.Name = "lblSolucion2";
            this.lblSolucion2.Size = new System.Drawing.Size(54, 13);
            this.lblSolucion2.TabIndex = 17;
            this.lblSolucion2.Text = "Solucion2";
            // 
            // txtSolucion2
            // 
            this.txtSolucion2.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtSolucion2.Location = new System.Drawing.Point(231, 130);
            this.txtSolucion2.MaxLength = 250;
            this.txtSolucion2.Multiline = true;
            this.txtSolucion2.Name = "txtSolucion2";
            this.txtSolucion2.Size = new System.Drawing.Size(174, 179);
            this.txtSolucion2.TabIndex = 16;
            // 
            // frmAltaCatalogo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(433, 392);
            this.Controls.Add(this.lblSolucion2);
            this.Controls.Add(this.txtSolucion2);
            this.Controls.Add(this.lblTiempo);
            this.Controls.Add(this.lblSolucion1);
            this.Controls.Add(this.lblIncidencia);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnAlta);
            this.Controls.Add(this.txtTiempo);
            this.Controls.Add(this.txtSolucion1);
            this.Controls.Add(this.txtIncidencia);
            this.Name = "frmAltaCatalogo";
            this.Text = "frmAltaCatalogo";
            this.Load += new System.EventHandler(this.frmAltaCatalogo_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTiempo;
        private System.Windows.Forms.Label lblSolucion1;
        private System.Windows.Forms.Label lblIncidencia;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnAlta;
        private System.Windows.Forms.TextBox txtTiempo;
        private System.Windows.Forms.TextBox txtSolucion1;
        private System.Windows.Forms.TextBox txtIncidencia;
        private System.Windows.Forms.Label lblSolucion2;
        private System.Windows.Forms.TextBox txtSolucion2;
    }
}