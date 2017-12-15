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
    public partial class frmAsignarIncidencia : Form
    {
        public frmAsignarIncidencia()
        {
            InitializeComponent();
            CargaUsuario();
        }
       
        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
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
            string strComando = "SELECT tipo, descripcion, departamento from incidencias WHERE incidenciaID ='" + clave+"'";
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
                    txtTipo.Text = lector.GetValue(0).ToString();
                    txtDescripcion.Text = lector.GetValue(1).ToString();
                }
            }
            conn.Close();
        }

        private void frmAsignarIncidencia_Load(object sender, EventArgs e)
        {
            string clave = cmbClave.SelectedIndex.ToString();
            string strCon = "Data Source=JORGE-HPDV5;Initial Catalog=Interceramic;Integrated Security=True";
            //string strCon = "Data Source=DESKTOP-9D96CMH\\SQLEXPRESS;Initial Catalog=Interceramic;Integrated Security=True";
            SqlConnection conn = UsoDB.ConectaBD(strCon);
            if (conn == null)
            {
                MessageBox.Show("Imposible Conectar");
            }
            string strcomand = "select incidenciaID From incidencias where estatus ='EN ESPERA'";
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

        private void cmbClaveUsuario_SelectedIndexChanged(object sender, EventArgs e)
        {
            string claveUsuario = cmbClaveUsuario.Text.ToString();
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
            string strComando = "SELECT nombre from Usuarios WHERE usuarioID= '" +claveUsuario+"'";
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
                    txtNombre.Text = lector.GetValue(0).ToString();
                   
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
                    cmbClaveUsuario.Items.Add(lector.GetValue(0).ToString());
                }
            }
            conn.Close();
        }

        private void btnAsignar_Click(object sender, EventArgs e)
        {
            string clave = cmbClave.SelectedText.ToString();
            string strCon = "Data Source=JORGE-HPDV5;Initial Catalog=Interceramic;Integrated Security=True";
            //string strCon = "Data Source=DESKTOP-9D96CMH\\SQLEXPRESS;Initial Catalog=Interceramic;Integrated Security=True";
            SqlConnection conn = UsoDB.ConectaBD(strCon);
            if (cmbClave.SelectedIndex < 0 || cmbClaveUsuario.SelectedIndex < 0 &&(rbBaja.Checked==false&&rdAlta.Checked==false&&rdMedia.Checked==false))
            {
                MessageBox.Show("SELECCIONE UNA OPCION", "INFORMACION", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else
            {
                string prioridad= " ";
                if (rdAlta.Checked)
                {
                    prioridad = "ALTA";
                }
                if (rdMedia.Checked)
                {
                    prioridad = "MEDIA";
                }
                if (rbBaja.Checked)
                {
                    prioridad = "BAJA";
                }
                string estatus="ASIGNADA";
                if (btnAsignar.Enabled == true)
                {
                   estatus = "ASIGNADA";
                }
               
                string strComando = "update incidencias set tecnico=@tecnico,  estatus=@estatus, prioridad=@prioridad where incidenciaID='" +cmbClave.Text.ToString()+"'";
                SqlCommand cmd = new SqlCommand(strComando, conn);
                cmd.Parameters.AddWithValue("@tecnico", txtNombre.Text);
                cmd.Parameters.AddWithValue("@estatus",estatus);
                cmd.Parameters.AddWithValue("@prioridad",prioridad) ;

                try
                {
                    cmd.ExecuteNonQuery();
                }
                catch (SqlException ex)
                {
                    MessageBox.Show(ex.Message);
                }
                MessageBox.Show("INCIDENCIA ASIGNADA", "INFORMACION", MessageBoxButtons.OK, MessageBoxIcon.Information); 
            conn.Close();
                limpiar();
            }
        }
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            limpiar();
        }
        public void limpiar()
        {
            cmbClave.SelectedIndex = -1;
            cmbClaveUsuario.SelectedIndex = -1;
            txtDescripcion.Text = "";
            txtNombre.Text = "";
            txtTipo.Text = "";

        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtDepartamento_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblPrioridad_Click(object sender, EventArgs e)
        {

        }
    }
    }

