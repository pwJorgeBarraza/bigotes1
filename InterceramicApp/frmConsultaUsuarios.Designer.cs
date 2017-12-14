namespace InterceramicApp
{
    partial class frmConsultaUsuarios
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.usuariosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.InterceramicDataSet1 = new InterceramicApp.InterceramicDataSet1();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.usuariosTableAdapter = new InterceramicApp.InterceramicDataSet1TableAdapters.usuariosTableAdapter();
            this.InterceramicDataSet2 = new InterceramicApp.InterceramicDataSet2();
            this.catalogoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.catalogoTableAdapter = new InterceramicApp.InterceramicDataSet2TableAdapters.catalogoTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.usuariosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.InterceramicDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.InterceramicDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.catalogoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // usuariosBindingSource
            // 
            this.usuariosBindingSource.DataMember = "usuarios";
            this.usuariosBindingSource.DataSource = this.InterceramicDataSet1;
            // 
            // InterceramicDataSet1
            // 
            this.InterceramicDataSet1.DataSetName = "InterceramicDataSet1";
            this.InterceramicDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.usuariosBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "InterceramicApp.Report3.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(1141, 552);
            this.reportViewer1.TabIndex = 0;
            // 
            // usuariosTableAdapter
            // 
            this.usuariosTableAdapter.ClearBeforeFill = true;
            // 
            // InterceramicDataSet2
            // 
            this.InterceramicDataSet2.DataSetName = "InterceramicDataSet2";
            this.InterceramicDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // catalogoBindingSource
            // 
            this.catalogoBindingSource.DataMember = "catalogo";
            this.catalogoBindingSource.DataSource = this.InterceramicDataSet2;
            // 
            // catalogoTableAdapter
            // 
            this.catalogoTableAdapter.ClearBeforeFill = true;
            // 
            // frmConsultaUsuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1141, 552);
            this.Controls.Add(this.reportViewer1);
            this.Name = "frmConsultaUsuarios";
            this.Text = "frmConsultaUsuarios";
            this.Load += new System.EventHandler(this.frmConsultaUsuarios_Load);
            ((System.ComponentModel.ISupportInitialize)(this.usuariosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.InterceramicDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.InterceramicDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.catalogoBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource usuariosBindingSource;
        private InterceramicDataSet1 InterceramicDataSet1;
        private InterceramicDataSet1TableAdapters.usuariosTableAdapter usuariosTableAdapter;
        private System.Windows.Forms.BindingSource catalogoBindingSource;
        private InterceramicDataSet2 InterceramicDataSet2;
        private InterceramicDataSet2TableAdapters.catalogoTableAdapter catalogoTableAdapter;
    }
}