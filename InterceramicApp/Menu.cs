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
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
            if (Interceramic.tipoCab)
            {
                altasToolStripMenuItem.Visible = false;
            }
            else if (Interceramic.tipoTecnico)
            {
                altasToolStripMenuItem.Visible = false;
            }
            else if (Interceramic.tipoAdministrador)
            {
                altasToolStripMenuItem.Visible = false;
            }
            else if (Interceramic.tipoUsuario)
            {
                altasToolStripMenuItem.Visible = false;
            }
        }

        private void porAñoToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void tecnicosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAltaUsuario altausuario = new frmAltaUsuario();
            altausuario.Show();
        }

        private void incidenciasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmAltaIncidencia altaincidencia = new FrmAltaIncidencia();
            altaincidencia.Show();
        }

        private void incidenciaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAsignarIncidencia asignar = new frmAsignarIncidencia();
            asignar.Show();

        }

        private void Menu_Load(object sender, EventArgs e)
        {

        }

        private void porMesToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmMostrarIncidencias mostrar = new frmMostrarIncidencias();
            mostrar.Show();
        }

        private void equipoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAltaEquipo equipo = new frmAltaEquipo();
            equipo.Show();
        }

        private void deCambioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmRFC rfc = new frmRFC();
            rfc.Show();
        }
      
         
        private void solicitudesToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void incidenciaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmLiberarIncidencia lib = new frmLiberarIncidencia();
            lib.Show();
                
        }

        private void porEspecialidadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmConsultaUsuarios con = new frmConsultaUsuarios();
            con.Show();
        }

        private void incidenciaToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            frmDiagnostico di = new frmDiagnostico();
            di.Show();
        }

        private void incidenciasToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmMuestraCatalogo cat2 = new frmMuestraCatalogo();
            cat2.Show();
        }

        private void catalogoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmAltaCatalogo cat = new frmAltaCatalogo();
            cat.Show();
        }

        private void incidenciaToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            frmEvaluacion eva = new frmEvaluacion();
            eva.Show();
        }
    }
}
