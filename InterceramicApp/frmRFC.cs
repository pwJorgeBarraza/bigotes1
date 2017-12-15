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
    public partial class frmRFC : Form
    {
        public frmRFC()
        {
            InitializeComponent();
            
            carga();
            cargaDepartamento();
        }

        private void frmRFC_Load(object sender, EventArgs e)
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



      
        private void cmbUsuario_SelectedIndexChanged(object sender, EventArgs e)
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
            string strComando = "SELECT departamento from incidencias WHERE incidenciaID ='" + clave + "'";
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
                }
            }
            conn.Close();
        }

        private void btnEnviar_Click(object sender, EventArgs e)
        {
                    string strCon = "Data Source=DESKTOP-5J98UPE\\SQLEXPRESS;Initial Catalog=Interceramic;Integrated Security=True";
        //string strCon = "Data Source=DESKTOP-9D96CMH\\SQLEXPRESS;Initial Catalog=Interceramic;Integrated Security=True";
        SqlConnection conn = UsoDB.ConectaBD(strCon);
            if (cmbDepartamento.Text == "" || cmbUsuario.SelectedIndex == -1 ||txtFecha.Text == "" || txtDescripcion.Text == "")

            {
                MessageBox.Show("Datos vacios", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
              
                string fecha = txtFecha.Text;
                string descripcion = txtDescripcion.Text;
                string estatus = "";
                if (btnEnviar.Enabled == true)
                {
                    estatus = "RECIBIDO";
                }
                string strComando = "insert into rfc (nombre, descripcion, fecha, nomDepartamento,dispositivo,estatus)";
                 strComando += "values (@nombre, @descripcion, @fecha, @nomDepartamento,@dispositivo,@estatus)";
                SqlCommand cmd = new SqlCommand(strComando, conn);
                cmd.Parameters.AddWithValue("@nomDepartamento", cmbDepartamento.Text);
                cmd.Parameters.AddWithValue("@nombre", cmbUsuario.Text);
                cmd.Parameters.AddWithValue("@descripcion", descripcion);
                cmd.Parameters.AddWithValue("@fecha", fecha);
                cmd.Parameters.AddWithValue("@dispositivo", cmbDispositivo.Text);
                cmd.Parameters.AddWithValue("@estatus", estatus);
                try
                {
                    cmd.ExecuteNonQuery();
                }
                catch (SqlException ex)
                {
                    MessageBox.Show(ex.Message);
                }
                MessageBox.Show("SOLICITUD ENVIADA", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                conn.Close();
                Limpiar();


            }
        }
        public void Limpiar()
{
            cmbDepartamento.SelectedIndex=-1;
            cmbUsuario.SelectedIndex = -1;
            txtDescripcion.Text = "";
            txtFecha.Text = "";
           


        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cmbDispositivo_SelectedIndexChanged(object sender, EventArgs e)
        {
     
        }
        public void cargaDepartamento()
        {
           
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
            string strComando = "SELECT tecnico from incidencias WHERE incidenciaID ='" + clave + "'";
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
                    cmbUsuario.Items.Add(lector.GetValue(0).ToString());
                }
            }
            conn.Close();
        }
        public void carga()
        {
            
        }
        private void cmbDepartamento_SelectedIndexChanged(object sender, EventArgs e)
        {
            string clave = cmbDepartamento.Text.ToString();
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
            string strComando = "SELECT dispositivo from incidencias WHERE departamento='" + clave + "'";
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
                    cmbDispositivo.Items.Add(lector.GetValue(0).ToString());
                }
            }
            conn.Close();
        }
    }
    
}
