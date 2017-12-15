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
    public partial class FrmAltaIncidencia : Form
    {
        public FrmAltaIncidencia()
        {
            InitializeComponent();
            cargaUsuario();
            CargaEquipo();
        }
         public void Limpiar()
        {
           
            txtDescripcion.Text = "";
            
            rdHardware.Checked = false;
            rdSoftware.Checked = false;
        }      
        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            string strCon = "Data Source=JORGE-HPDV5;Initial Catalog=Interceramic;Integrated Security=True";
            //string strCon = "Data Source=DESKTOP-9D96CMH\\SQLEXPRESS;Initial Catalog=Interceramic;Integrated Security=True";
            SqlConnection conn = UsoDB.ConectaBD(strCon);
            if (txtDescripcion.Text == ""|| txtDispositivo.Text == "")
            {
                MessageBox.Show("Datos vacios", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {

                string descripcion = txtDescripcion.Text;
                string prioridad = "";


                string tipo = "";
                if (rdSoftware.Checked)
                {
                    tipo = "Software";
                }
                if (rdHardware.Checked)
                {
                    tipo = "Hardware";
                }
                string estatus = "";
                if (btnRegistrar.Enabled == true)
                {
                    estatus = "EN ESPERA";
                }
                DateTime fechaIncidencia = mcFecha.TodayDate.Date;
                string dispositivo= txtDispositivo.Text;
                    string strComando = "insert into incidencias(usuario,fecha,tipo, prioridad, estatus, descripcion, departamento, dispositivo)";
                    strComando += "values (@usuario,@fecha,@tipo, @prioridad, @estatus, @descripcion, @departamento, @dispositivo)";
                    SqlCommand cmd = new SqlCommand(strComando, conn);
                    cmd.Parameters.AddWithValue("@usuario", cmbUsuario.Text.ToString());
                    cmd.Parameters.AddWithValue("@fecha", fechaIncidencia);
                    cmd.Parameters.AddWithValue("@tipo", tipo);
                    cmd.Parameters.AddWithValue("@prioridad", prioridad);
                    cmd.Parameters.AddWithValue("@estatus", estatus);
                    cmd.Parameters.AddWithValue("@descripcion", descripcion);
                    cmd.Parameters.AddWithValue("@departamento", txtDepartamento.Text);
                cmd.Parameters.AddWithValue("@dispositivo", dispositivo);

                    
                    
                    try
                    {
                        cmd.ExecuteNonQuery();
                    }
                    catch (SqlException ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                    MessageBox.Show("INCIDENCIA AGREGADO", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    conn.Close();
                    Limpiar();


                }
            }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtDescripcion_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((char.IsPunctuation(e.KeyChar) && e.KeyChar != (char)Keys.Back))
            {
                errorProvider1.SetError(txtDescripcion, "Solo se permiten letras");
                e.Handled = true;
            }
            else
            {
                errorProvider1.SetError(txtDescripcion, "");
            }
        }



        private void FrmAltaIncidencia_Load(object sender, EventArgs e)
        {
            
        
    }

        private void grpTipos_Enter(object sender, EventArgs e)
        {

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
            string strComando = "SELECT departamento from Usuarios where nombre = '" +clave+ "'";
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

                    txtDepartamento.Text= lector.GetValue(0).ToString();
                }
            }
            conn.Close();
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
        public void CargaEquipo()
        {
            string departamento = txtDepartamento.Text.ToString(); 
            string strCon = "Data Source=JORGE-HPDV5;Initial Catalog=Interceramic;Integrated Security=True";
            //string strCon = "Data Source=DESKTOP-9D96CMH\\SQLEXPRESS;Initial Catalog=Interceramic;Integrated Security=True";
            SqlConnection conn = new SqlConnection(strCon);
            try
            {
                conn.Open();
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Imposible conectar con los datos 2");
                foreach (SqlError err in ex.Errors)
                {
                    MessageBox.Show(err.Message);
                }
                return;
            }
            SqlDataReader lector = null;
            string strComando = "select dispositivo from equipo where departamento = '"+ departamento +"'";
            SqlCommand cmd = new SqlCommand(strComando, conn);
            try
            {
                lector = cmd.ExecuteReader();

            }
            catch (SqlException ex)
            {
                MessageBox.Show("Error en consulta 3");
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
        private void txtDescripcion_TextChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void txtDepartamento_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblEquipo_Click(object sender, EventArgs e)
        {

        }

        private void mcFecha_DateChanged(object sender, DateRangeEventArgs e)
        {

        }
    }
       
    }

