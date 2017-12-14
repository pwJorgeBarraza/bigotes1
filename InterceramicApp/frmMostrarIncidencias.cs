using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InterceramicApp
{
    public partial class frmMostrarIncidencias : Form
    {
        public frmMostrarIncidencias()
        {
            InitializeComponent();
        }

        private void frmMostrarIncidencias_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'InterceramicDataSet.incidencias' table. You can move, or remove it, as needed.
            this.incidenciasTableAdapter.Fill(this.InterceramicDataSet.incidencias);

            this.reportViewer1.RefreshReport();
        }
    }
}
