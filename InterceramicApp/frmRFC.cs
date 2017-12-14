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
            cargaUsuario();
        }

        private void frmRFC_Load(object sender, EventArgs e)
        {

        }
       
           
        
        public void cargaUsuario()
        {
            string clave = cmbUsuario.SelectedText.ToString();
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
            string strComando = "SELECT nombre from Usuarios where tipo='U'";
            SqlCommand cmd = new SqlCommand(strComando, conn);
            try
            {
                lector = cmd.ExecuteReader();

            }
            catch (SqlException ex)
            {
                MessageBox.Show("Error en consulta 2");
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

        private void cmbUsuario_SelectedIndexChanged(object sender, EventArgs e)
        {
            string clave = cmbUsuario.SelectedItem.ToString();
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
            string strComando = "SELECT departamento from Usuarios where nombre = '" + clave + "'";
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

                    txtDepartamento.Text = lector.GetValue(0).ToString();
                }
            }
            conn.Close();
        }

        private void btnEnviar_Click(object sender, EventArgs e)
        {
     
        string strCon = "Data Source=JORGE-HPDV5;Initial Catalog=Interceramic;Integrated Security=True";
        //string strCon = "Data Source=DESKTOP-9D96CMH\\SQLEXPRESS;Initial Catalog=Interceramic;Integrated Security=True";
        SqlConnection conn = UsoDB.ConectaBD(strCon);
            if (txtDepartamento.Text == "" || cmbUsuario.SelectedIndex <= 0 ||txtFecha.Text == "" || txtDescripcion.Text == "")

            {
                MessageBox.Show("Datos vacios", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                string usuario = cmbUsuario.SelectedText.ToString();
                string departamento = txtDepartamento.Text;
                string fecha = txtFecha.Text;
                string descripcion = txtDescripcion.Text;
    
                string strComando = "insert into rfc (nombre, descripcion, fecha, departamento)";
                 strComando += "values (@nombre, @descripcion, @fecha, @departamento)";
                SqlCommand cmd = new SqlCommand(strComando, conn);
                 cmd.Parameters.AddWithValue("@fecha",fecha);
                cmd.Parameters.AddWithValue("@departamento", departamento);
                cmd.Parameters.AddWithValue("@usuario", usuario);
                cmd.Parameters.AddWithValue("@descripcion", descripcion);
                try
                {
                    cmd.ExecuteNonQuery();
                }
                catch (SqlException ex)
                {
                    MessageBox.Show(ex.Message);
                }
                MessageBox.Show("EQUIPO REGISTRADO", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                conn.Close();
                Limpiar();


            }
        }
        public void Limpiar()
{
            txtDepartamento.Text = "";
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
    }
}
