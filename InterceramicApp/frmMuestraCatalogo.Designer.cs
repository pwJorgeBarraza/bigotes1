namespace InterceramicApp
{
    partial class frmMuestraCatalogo
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
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.InterceramicDataSet = new InterceramicApp.InterceramicDataSet();
            this.incidenciasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.incidenciasTableAdapter = new InterceramicApp.InterceramicDataSetTableAdapters.incidenciasTableAdapter();
            this.InterceramicDataSet2 = new InterceramicApp.InterceramicDataSet2();
            this.catalogoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.catalogoTableAdapter = new InterceramicApp.InterceramicDataSet2TableAdapters.catalogoTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.InterceramicDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.incidenciasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.InterceramicDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.catalogoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet";
            reportDataSource1.Value = this.catalogoBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "InterceramicApp.Report5.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(654, 426);
            this.reportViewer1.TabIndex = 0;
            // 
            // InterceramicDataSet
            // 
            this.InterceramicDataSet.DataSetName = "InterceramicDataSet";
            this.InterceramicDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // incidenciasBindingSource
            // 
            this.incidenciasBindingSource.DataMember = "incidencias";
            this.incidenciasBindingSource.DataSource = this.InterceramicDataSet;
            // 
            // incidenciasTableAdapter
            // 
            this.incidenciasTableAdapter.ClearBeforeFill = true;
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
            // frmMuestraCatalogo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(654, 426);
            this.Controls.Add(this.reportViewer1);
            this.Name = "frmMuestraCatalogo";
            this.Text = "Catalogo de Problemas";
            this.Load += new System.EventHandler(this.frmMuestraCatalogo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.InterceramicDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.incidenciasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.InterceramicDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.catalogoBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource incidenciasBindingSource;
        private InterceramicDataSet InterceramicDataSet;
        private InterceramicDataSetTableAdapters.incidenciasTableAdapter incidenciasTableAdapter;
        private System.Windows.Forms.BindingSource catalogoBindingSource;
        private InterceramicDataSet2 InterceramicDataSet2;
        private InterceramicDataSet2TableAdapters.catalogoTableAdapter catalogoTableAdapter;
    }
}