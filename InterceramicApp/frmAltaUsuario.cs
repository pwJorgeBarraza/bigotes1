using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;
using LibreriaBD;


namespace InterceramicApp
{
    public partial class frmAltaUsuario : Form
    {
        public frmAltaUsuario()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Limpiar();
        }
        public void Limpiar()
        {
            txtNombre.Text = "";
            txtNombreUsuario.Text = "";
            txtClave.Text = "";
            txtEspecialidad.Text = "";
            rdAdmin.Checked=true;
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        public bool BuscaUSuario(string user)
        {
            bool bandera = false;
            string strCon = "Data Source=JORGE-HPDV5;Initial Catalog=Interceramic;Integrated Security=True";
            //string strCon = "Data Source=DESKTOP-9D96CMH\\SQLEXPRESS;Initial Catalog=Interceramic;Integrated Security=True";
            SqlConnection conn = UsoDB.ConectaBD(strCon);
            if (conn == null)
            {
                MessageBox.Show("Imposible conectar con BD");
                return false;
            }
            SqlDataReader lector = null;
            string strComandoSQL = "select usuario from usuarios where usuario='" + user + "'";
            SqlCommand cmd = new SqlCommand(strComandoSQL, conn);
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
                    return false;
                }
            }
            if (lector.HasRows)
            {
                bandera = true;
            }
            conn.Close();
            return bandera;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            string strCon = "Data Source=JORGE-HPDV5;Initial Catalog=Interceramic;Integrated Security=True";
            //string strCon = "Data Source=DESKTOP-9D96CMH\\SQLEXPRESS;Initial Catalog=Interceramic;Integrated Security=True";
            SqlConnection conn = UsoDB.ConectaBD(strCon);
            if (txtNombre.Text == "" || txtNombreUsuario.Text == "" || txtClave.Text == "" || txtEspecialidad.Text == ""||cmbDepartamento.SelectedIndex<=0)
            {
                MessageBox.Show("Datos vacios", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {

            
            
                string usuario = txtNombreUsuario.Text;
                if (BuscaUSuario(usuario) == true)
                {
                    MessageBox.Show("NOMBRE DE USUARIO REPETIDO, FAVOR DE PONER OTRO", "ADVERTENCIA", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {
                    string nombre = txtNombre.Text;
                    string contrasena = txtClave.Text;
                    txtClave.MaxLength = 16;
                    txtClave.PasswordChar = '*';
                    txtClave.CharacterCasing = CharacterCasing.Lower;
                    string especialidad = txtEspecialidad.Text;
                    string tipo = "";
                    if (rdAdmin.Checked)
                    {
                        tipo = "A";
                    }
                    if (rdTecnico.Checked)
                    {
                        tipo = "T";
                    }
                    if (rdUsuario.Checked)
                    {
                        tipo = "U";
                    }
                    if (rbCab.Checked)
                    {
                        tipo = "C";
                    }
                    string strComando = "insert into usuarios(nombre, usuario, contrasena, tipo, especialidad,departamento)";
                    strComando += "values (@nombre, @usuario, @contrasena, @tipo, @especialidad,@departamento)";
                    SqlCommand cmd = new SqlCommand(strComando, conn);
                    cmd.Parameters.AddWithValue("@nombre", nombre);
                    cmd.Parameters.AddWithValue("@usuario", usuario);
                    cmd.Parameters.AddWithValue("@contrasena", contrasena);
                    cmd.Parameters.AddWithValue("@tipo", tipo);
                    cmd.Parameters.AddWithValue("@especialidad", especialidad);
                    cmd.Parameters.AddWithValue("@departamento", cmbDepartamento.Text);

                    try
                    {
                        cmd.ExecuteNonQuery();
                    }
                    catch (SqlException ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                    MessageBox.Show("USUARIO AGREGADO", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    conn.Close();
                    Limpiar();


                }
            }
        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((char.IsNumber(e.KeyChar) && e.KeyChar != (char)Keys.Back))
            {
                errorProvider1.SetError(txtNombre, "Solo se permiten letras");
                e.Handled = true;
            }
            else
            {
                errorProvider1.SetError(txtNombre, "");
            }
        }

        private void txtClave_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtClave_KeyPress(object sender, KeyPressEventArgs e)
        {
            errorProvider1.SetError(txtClave, "Escribir una contraseña de 8 a 16 caracteres");
           
        }

        private void txtEspecialidad_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((char.IsNumber(e.KeyChar) && e.KeyChar != (char)Keys.Back))
            {
                errorProvider1.SetError(txtNombre, "Solo se permiten letras");
                e.Handled = true;
            }
            else
            {
                errorProvider1.SetError(txtNombre, "");
            }
        }

        private void cmbDepartamento_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void frmAltaUsuario_Load(object sender, EventArgs e)
        {
            //string clave = cmbClave.SelectedItem.ToString();
            string strCon = "Data Source=JORGE-HPDV5;Initial Catalog=Interceramic;Integrated Security=True";
            //string strCon = "Data Source=DESKTOP-9D96CMH\\SQLEXPRESS;Initial Catalog=Interceramic;Integrated Security=True";
            SqlConnection conn = UsoDB.ConectaBD(strCon);
            if (conn == null)
            {
                MessageBox.Show("Imposible Conectar");
            }
            string strcomand = "select nombre from departamento";
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
                    cmbDepartamento.Items.Add(Lector.GetValue(0).ToString());
                }
            }
            conn.Close();
        }
    }
}
