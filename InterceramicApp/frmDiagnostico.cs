using System;
using System.Collections;
using System.ComponentModel;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LibreriaBD;

namespace InterceramicApp
{
    public partial class frmDiagnostico : Form
    {
        public frmDiagnostico()
        {
            InitializeComponent();
            CargaUsuario();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void frmDiagnostico_Load(object sender, EventArgs e)
        {
            string clave = cmbClave.SelectedIndex.ToString();

            string strCon = "Data Source=DESKTOP-5J98UPE\\SQLEXPRESS;Initial Catalog=Interceramic;Integrated Security=True";
            //string strCon = "Data Source=DESKTOP-9D96CMH\\SQLEXPRESS;Initial Catalog=Interceramic;Integrated Security=True";
            SqlConnection conn = UsoDB.ConectaBD(strCon);
            if (conn == null)
            {
                MessageBox.Show("Imposible Conectar");
            }
            string strcomand = "select incidenciaID From incidencias where estatus ='ASIGNADA'";
            SqlDataReader Lector = UsoDB.Consulta(strcomand, conn);
            if (Lector == null)
            {
                MessageBox.Show("Error en la Consulta");
                conn.Close();
                return;
            }
            if (Lector.HasRows)
            {
                while (Lector.Read())
                {
                    cmbClave.Items.Add(Lector.GetValue(0).ToString());
                }
            }
            conn.Close();
        }

        private void cmbClave_SelectedIndexChanged(object sender, EventArgs e)
        {
            string clave = cmbClave.Text.ToString();
            string strCon = "Data Source=DESKTOP-5J98UPE\\SQLEXPRESS;Initial Catalog=Interceramic;Integrated Security=True";
            //string strCon = "Data Source=DESKTOP-9D96CMH\\SQLEXPRESS;Initial Catalog=Interceramic;Integrated Security=True";
            SqlConnection conn = new SqlConnection(strCon);
            try
            {
                conn.Open();
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Imposible conectar con los datos");
                foreach (SqlError err in ex.Errors)
                {
                    MessageBox.Show(err.Message);
                }
                return;
            }
            SqlDataReader lector = null;
            string strComando = "SELECT descripcion, tecnico from incidencias WHERE incidenciaID ='" + clave + "'";
            SqlCommand cmd = new SqlCommand(strComando, conn);
            try
            {
                lector = cmd.ExecuteReader();

            }
            catch (SqlException ex)
            {
                MessageBox.Show("Error en consulta");
                foreach (SqlError err in ex.Errors)
                {
                    MessageBox.Show(err.Message);
                }
                conn.Close();
                return;
            }

            if (lector.HasRows)
            {
                while (lector.Read())
                {
                    txtTecnico.Text = lector.GetValue(1).ToString();
                    txtDescripcion.Text = lector.GetValue(0).ToString();
                }
            }
            conn.Close();
        }
        public void CargaUsuario()
        {
           
        }
        private void btnDiagnosticar_Click(object sender, EventArgs e)
        {

            string clave = cmbClave.Text.ToString();
            string strCon = "Data Source=DESKTOP-5J98UPE\\SQLEXPRESS;Initial Catalog=Interceramic;Integrated Security=True";
            //string strCon = "Data Source=DESKTOP-9D96CMH\\SQLEXPRESS;Initial Catalog=Interceramic;Integrated Security=True";
            SqlConnection conn = UsoDB.ConectaBD(strCon);
            if (txtTiempo.Text == "")
            {
                MessageBox.Show("Datos vacios", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {




                string tiempoEstimado = txtTiempo.Text;

                string strComando = "update incidencias set tiempoEstimado=@tiempoEstimado where incidenciaID='" + clave + "'";
                SqlCommand cmd = new SqlCommand(strComando, conn);
                cmd.Parameters.AddWithValue("@tiempoEstimado", tiempoEstimado);
                try
                {
                    cmd.ExecuteNonQuery();
                }
                catch (SqlException ex)
                {
                    MessageBox.Show(ex.Message);
                }
                MessageBox.Show("INCIDENCIA DIAGNOSTICADA", "INFORMACION", MessageBoxButtons.OK, MessageBoxIcon.Information);
                conn.Close();
                limpiar();
            }
        }
        public void limpiar()
        {
            txtDescripcion.Text = "";
            txtTecnico.Text = "";
            txtTiempo.Text = "";
        }

        private void btnCatalogo_Click(object sender, EventArgs e)
        {
            frmMuestraCatalogo cat = new frmMuestraCatalogo();
            cat.Show();
        }

        private void txtTiempo_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

