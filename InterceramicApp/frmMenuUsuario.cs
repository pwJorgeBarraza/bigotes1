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
    public partial class frmMenuUsuario : Form
    {
        public frmMenuUsuario()
        {
            InitializeComponent();
        }

        private void incidenciasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmAltaIncidencia alta = new FrmAltaIncidencia();
            alta.Show();
        }
    }
}
