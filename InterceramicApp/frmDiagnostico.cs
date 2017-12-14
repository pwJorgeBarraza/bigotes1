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

        }

        private void cmbClave_SelectedIndexChanged(object sender, EventArgs e)
        {
            string clave = cmbClave.Text.ToString();
            string strCon = "Data Source=JORGE-HPDV5;Initial Catalog=Interceramic;Integrated Security=True";
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
            string strComando = "SELECT descripcion, usuario from incidencias WHERE incidenciaID ='" + clave + "'";
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
                    txtTecnico.Text = lector.GetValue(0).ToString();
                    txtDescripcion.Text = lector.GetValue(1).ToString();
                }
            }
            conn.Close();
        }
        public void CargaUsuario()
        {
            string strCon = "Data Source=JORGE-HPDV5;Initial Catalog=Interceramic;Integrated Security=True";
            //string strCon = "Data Source=DESKTOP-9D96CMH\\SQLEXPRESS;Initial Catalog=Interceramic;Integrated Security=True";
            SqlConnection conn = UsoDB.ConectaBD(strCon);
            if (conn == null)
            {
                MessageBox.Show("Imposible Conectar");
                return;
            }
            string strComando = "select usuarioID from usuarios where Tipo='T'";

            SqlDataReader lector = UsoDB.Consulta(strComando, conn);
            if (lector == null)
            {
                MessageBox.Show("Error En La Consulta");
                conn.Close();
                return;
            }
            if (lector.HasRows)
            {


                while (lector.Read())
                {
                    cmbClave.Items.Add(lector.GetValue(0).ToString());
                }
            }
            conn.Close();
        }
        private void btnDiagnosticar_Click(object sender, EventArgs e)
        {

        }
    }
}

