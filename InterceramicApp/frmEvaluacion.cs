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
    public partial class frmEvaluacion : Form
    {
        public frmEvaluacion()
        {
            InitializeComponent();
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
            string strComando = "SELECT usuario, tecnico, descripcion, fecha, fechaLiberacion, tiempoEstimado from incidencias WHERE incidenciaID ='" + clave + "'";
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
                    txtUsuario.Text = lector.GetValue(0).ToString();
                    txtTecnico.Text = lector.GetValue(1).ToString();
                    txtDescripcion.Text = lector.GetValue(2).ToString();
                    txtFechaI.Text = lector.GetValue(3).ToString();
                    txtFechaF.Text = lector.GetValue(4).ToString();
                    txtTiempo.Text = lector.GetValue(5).ToString();
                }
            }
            conn.Close();
        }

        private void frmEvaluacion_Load(object sender, EventArgs e)
        {
            string clave = cmbClave.SelectedIndex.ToString();
            string strCon = "Data Source=JORGE-HPDV5;Initial Catalog=Interceramic;Integrated Security=True";
            //string strCon = "Data Source=DESKTOP-9D96CMH\\SQLEXPRESS;Initial Catalog=Interceramic;Integrated Security=True";
            SqlConnection conn = UsoDB.ConectaBD(strCon);
            if (conn == null)
            {
                MessageBox.Show("Imposible Conectar");
            }
            string strcomand = "select incidenciaID From incidencias where estatus ='LIBERADA'";
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

        private void txtTiempoR_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnEvaluar_Click(object sender, EventArgs e)
        {
            string clave = cmbClave.SelectedText.ToString();
            string strCon = "Data Source=JORGE-HPDV5;Initial Catalog=Interceramic;Integrated Security=True";
            //string strCon = "Data Source=DESKTOP-9D96CMH\\SQLEXPRESS;Initial Catalog=Interceramic;Integrated Security=True";
            SqlConnection conn = UsoDB.ConectaBD(strCon);
            if (cmbClave.SelectedIndex < 0 || txtDescripcion.Text == "" || txtTecnico.Text == "" || txtFechaF.Text == "" | txtFechaI.Text == "" || txtTiempo.Text == "" || txtTiempoR.Text == "" || txtUsuario.Text == "")
            {
                MessageBox.Show("HAY ALGUN CAMPO VACÍO", "EXCLAMACIÓN", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else
            {
                DateTime fechaI = Convert.ToDateTime(txtFechaI.Text);
                DateTime fechaF = Convert.ToDateTime(txtFechaF.Text);
                int evaluacion=0;
                if (rdBueno.Checked && rdSi2.Checked && rdAtento.Checked)
                { evaluacion = 10; }
                if (rdBueno.Checked && rdSi2.Checked && rdGrosero.Checked)
                { evaluacion = 7; }
                if (rdBueno.Checked && rdNo2.Checked && rdAtento.Checked)
                { evaluacion = 8; }
                if (rdBueno.Checked && rdNo2.Checked && rdGrosero.Checked)
                { evaluacion = 5; }
                if (rdMalo.Checked && rdSi2.Checked && rdAtento.Checked)
                { evaluacion = 7; }
                if (rdMalo.Checked && rdSi2.Checked && rdGrosero.Checked)
                { evaluacion = 6; }
                if (rdMalo.Checked && rdNo2.Checked && rdAtento.Checked)
                { evaluacion = 7; }
                if (rdMalo.Checked && rdNo2.Checked && rdGrosero.Checked)
                { evaluacion = 0; }
                TimeSpan tiempoR = fechaF.Subtract(fechaF);
                txtTiempoR.Text = tiempoR.Days.ToString();
                string strComando = "update incidencias set evaluacion=@evaluacion where incidenciaID='" + clave + "'";
                SqlCommand cmd = new SqlCommand(strComando, conn);
                cmd.Parameters.AddWithValue("@evaluacion", evaluacion);
                try
                {
                    cmd.ExecuteNonQuery();
                }
                catch (SqlException ex)
                {
                    MessageBox.Show(ex.Message);
                }
                MessageBox.Show("INCIDENCIA LIBERADA", "INFORMACION", MessageBoxButtons.OK, MessageBoxIcon.Information);
                conn.Close();
                limpiar();
            }
        }
                
                
        public void limpiar()
        {
            txtDescripcion.Text = "";
            txtFechaF.Text = "";
            txtFechaI.Text = "";
            txtTecnico.Text = "";
            txtTiempo.Text = "";
            txtTiempoR.Text = "";
            txtUsuario.Text = "";

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
