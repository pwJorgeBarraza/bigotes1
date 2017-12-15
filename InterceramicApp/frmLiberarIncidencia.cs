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
    public partial class frmLiberarIncidencia : Form
    {
        public frmLiberarIncidencia()
        {
            InitializeComponent();
        }

        private void cmbClave_SelectedIndexChanged(object sender, EventArgs e)
        {
<<<<<<< HEAD
            string clave = cmbClave.Text.ToString();
            string strCon = "Data Source=DESKTOP-5J98UPE\\SQLEXPRESS;Initial Catalog=Interceramic;Integrated Security=True";
=======
            string clave = cmbClave.SelectedItem.ToString();
            string strCon = "Data Source=JORGE-HPDV5;Initial Catalog=Interceramic;Integrated Security=True";
>>>>>>> master
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
<<<<<<< HEAD
            string strComando = "select usuario, descripcion from incidencias WHERE incidenciaID= '" + clave + "'";
=======
            string strComando = "select usuario, descripcion from incidencias WHERE incidenciaID= '" + clave+"'";
>>>>>>> master
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
<<<<<<< HEAD
                    txtDescripcion.Text = lector.GetValue(1).ToString();

=======
                   txtDescripcion.Text = lector.GetValue(1).ToString();
                    
>>>>>>> master
                }
            }
            conn.Close();
        }

        private void frmLiberarIncidencia_Load(object sender, EventArgs e)
        {
<<<<<<< HEAD
            string clave = cmbClave.SelectedIndex.ToString();
            string strCon = "Data Source=DESKTOP-5J98UPE\\SQLEXPRESS;Initial Catalog=Interceramic;Integrated Security=True";
=======

            string clave = cmbClave.SelectedText.ToString();

            string strCon = "Data Source=JORGE-HPDV5;Initial Catalog=Interceramic;Integrated Security=True";
>>>>>>> master
            //string strCon = "Data Source=DESKTOP-9D96CMH\\SQLEXPRESS;Initial Catalog=Interceramic;Integrated Security=True";
            SqlConnection conn = UsoDB.ConectaBD(strCon);
            if (conn == null)
            {
                MessageBox.Show("Imposible Conectar");
            }
            string strcomand = "select incidenciaID From incidencias where estatus='ASIGNADA'";
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

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
<<<<<<< HEAD

        private void btnLiberar_Click(object sender, EventArgs e)
        {
            string clave = cmbClave.SelectedText.ToString();
            string strCon = "Data Source=DESKTOP-5J98UPE\\SQLEXPRESS;Initial Catalog=Interceramic;Integrated Security=True";
            //string strCon = "Data Source=DESKTOP-9D96CMH\\SQLEXPRESS;Initial Catalog=Interceramic;Integrated Security=True";
            SqlConnection conn = UsoDB.ConectaBD(strCon);
            if (cmbClave.SelectedIndex < 0 || txtDescripcion.Text == "" || txtTecnico.Text == "")
            {
                MessageBox.Show("HAY ALGUN CAMPO VACÍO", "EXCLAMACIÓN", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else
            {
                DateTime fechaLiberacion = mcFecha.TodayDate.Date;
                string estatus = "";
                if (btnLiberar.Enabled == true)
                {
                    estatus = "LIBERADA";
                }

                string strComando = "update incidencias set fechaLiberacion=@fechaLiberacion,  estatus=@estatus where incidenciaID='" + cmbClave.Text.ToString() + "'";
                SqlCommand cmd = new SqlCommand(strComando, conn);
                cmd.Parameters.AddWithValue("@fechaLiberacion", fechaLiberacion);
                cmd.Parameters.AddWithValue("@estatus", estatus);

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
            txtTecnico.Text = "";
            cmbClave.SelectedIndex = -1;
        }
=======
>>>>>>> master
    }
}
