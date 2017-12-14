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
    public partial class frmMuestraCatalogo : Form
    {
        public frmMuestraCatalogo()
        {
            InitializeComponent();
        }

        private void frmMuestraCatalogo_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'InterceramicDataSet2.catalogo' table. You can move, or remove it, as needed.
            this.catalogoTableAdapter.Fill(this.InterceramicDataSet2.catalogo);
            // TODO: This line of code loads data into the 'InterceramicDataSet.incidencias' table. You can move, or remove it, as needed.
         
            this.reportViewer1.RefreshReport();
        }
    }
}
