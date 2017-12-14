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
    public partial class frmConsultaUsuarios : Form
    {
        public frmConsultaUsuarios()
        {
            InitializeComponent();
        }

        private void frmConsultaUsuarios_Load(object sender, EventArgs e)
        {
          
            this.usuariosTableAdapter.Fill(this.InterceramicDataSet1.usuarios);

            this.reportViewer1.RefreshReport();
        }
    }
}
