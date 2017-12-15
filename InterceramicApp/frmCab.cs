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
    public partial class frmCab : Form
    {
        public frmCab()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
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
            string strComando = "SELECT nomDepartamento, dispositivo, descripcion from rfc WHERE rfcId ='" + clave + "'";
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
                    cmbDepartamento.Items.Add(lector.GetValue(0).ToString());
                    cmbDispositivo.Items.Add(lector.GetValue(1).ToString());
                    txtPeticion.Text = lector.GetValue(2).ToString();
                }
            }
            conn.Close();
        }

        private void btnResponder_Click(object sender, EventArgs e)
        {
            string clave = cmbClave.SelectedText.ToString();
            string strCon = "Data Source=DESKTOP-5J98UPE\\SQLEXPRESS;Initial Catalog=Interceramic;Integrated Security=True";
            //string strCon = "Data Source=DESKTOP-9D96CMH\\SQLEXPRESS;Initial Catalog=Interceramic;Integrated Security=True";
            SqlConnection conn = UsoDB.ConectaBD(strCon);
            if (cmbClave.SelectedIndex < 0)
            {
                MessageBox.Show("SELECCIONE UNA OPCION", "INFORMACION", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else
            {
                string justificacion = txtJustificacion.Text;
                string estatus = " ";
                if (rdAprobado.Checked)
                {
                    estatus = "APROBADO";
                }
                if (rbRechazado.Checked)
                {
                    estatus = "RECHAZADO";
                }
               

                string strComando = "update rfc set estatus=@estatus,  justificacion=@justificacion where rfcId='" + cmbClave.Text.ToString() + "'";
                SqlCommand cmd = new SqlCommand(strComando, conn);
                cmd.Parameters.AddWithValue("@justificacion", justificacion);
                cmd.Parameters.AddWithValue("@estatus", estatus);


                try
                {
                    cmd.ExecuteNonQuery();
                }
                catch (SqlException ex)
                {
                    MessageBox.Show(ex.Message);
                }
                MessageBox.Show("SOLICITUD", "INFORMACION", MessageBoxButtons.OK, MessageBoxIcon.Information);
                conn.Close();
            }
        }

        private void frmCab_Load(object sender, EventArgs e)
        {
            string clave = cmbClave.SelectedIndex.ToString();
            string strCon = "Data Source=DESKTOP-5J98UPE\\SQLEXPRESS;Initial Catalog=Interceramic;Integrated Security=True";
            //string strCon = "Data Source=DESKTOP-9D96CMH\\SQLEXPRESS;Initial Catalog=Interceramic;Integrated Security=True";
            SqlConnection conn = UsoDB.ConectaBD(strCon);
            if (conn == null)
            {
                MessageBox.Show("Imposible Conectar");
            }
            string strcomand = "select rfcId from rfc where estatus = 'recibido'";
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

        private void rdAprobado_CheckedChanged(object sender, EventArgs e)
        {
            if (rdAprobado.Checked)
            {
                ActualizarEquipo ac = new ActualizarEquipo();
                ac.Show();

            }
        }
    }
}
