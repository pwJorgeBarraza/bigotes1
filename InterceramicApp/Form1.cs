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
    public partial class Interceramic : Form
    {
        public static Boolean tipoCab = false;
        public static Boolean tipoUsuario = false;
        public static Boolean tipoTecnico = false;
        public static Boolean tipoAdministrador = false;

        public Interceramic()
        {
            InitializeComponent();      
        }    

        private void button1_Click(object sender, EventArgs e)
        {
              string strCon = "Data Source=JORGE-HPDV5;Initial Catalog=Interceramic;Integrated Security=True";
            //string strCon = "Data Source=DESKTOP-9D96CMH\\SQLEXPRESS;Initial Catalog=Interceramic;Integrated Security=True";
            SqlConnection conn = UsoDB.ConectaBD(strCon);
            if (txtUsuario.Text == "" || txtContrasena.Text=="")
            {
                MessageBox.Show("Datos vacios", "error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                string usuario = txtUsuario.Text;
                string contrasena = txtContrasena.Text;

                if (BuscaUsuario(usuario) == false || (BuscaClave(contrasena) == false))

                {
                    MessageBox.Show("USUARIO Y/O CONTRASEÑA INCORRECTA", "ADVERTENCIA", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    Limpiar();
                }
                else
                {
                    String tipo = obtenerTipoUsuario();
                    if (tipo.Equals("") || tipo == null)
                    {
                        MessageBox.Show("ERROR AL OBTENER TIPO DE USUARIO", "ADVERTENCIA", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                    else
                    {
                        if (tipo.Equals("U"))
                        {
                            tipoUsuario = true;
                        }
                        else if (tipo.Equals("A"))
                        {
                            tipoAdministrador = true;
                        }
                        else if (tipo.Equals("T"))
                        {
                            tipoTecnico = true;
                        }
                        else if (tipo.Equals("C"))
                        {
                            tipoCab = true;
                        }
                    }
                    string strComando = "select @usuario, @contrasena from usuarios";
                    SqlCommand cmd = new SqlCommand(strComando, conn);
                    cmd.Parameters.AddWithValue("@usuario", usuario);
                    cmd.Parameters.AddWithValue("@contrasena", contrasena);
                    Menu menu = new Menu();
                    menu.Show();
                    try
                    {
                        cmd.ExecuteNonQuery();
                    }
                    catch (SqlException ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                    conn.Close();

                }

                
            }
        }
        public bool BuscaUsuario(string user)
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
        public bool BuscaClave(string clave)
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
            string strComandoSQL = "select contrasena from usuarios where contrasena='" + clave + "'";
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
        public void Limpiar()
        {
            txtContrasena.Text = "";
            txtUsuario.Text = "";
        }
        private void lblContraseña_Load(object sender, EventArgs e)
        {

        }

        public String obtenerTipoUsuario()
        {
            String tipo = "";
            string usuario = txtUsuario.Text;
            string contrasena = txtContrasena.Text;
            //string clave = cmbClave.SelectedItem.ToString();
            string strCon = "Data Source=JORGE-HPDV5;Initial Catalog=Interceramic;Integrated Security=True";
            //string strCon = "Data Source=DESKTOP-9D96CMH\\SQLEXPRESS;Initial Catalog=Interceramic;Integrated Security=True";
            SqlConnection conn = UsoDB.ConectaBD(strCon);
            if (conn == null)
            {
                MessageBox.Show("Imposible Conectar");
                return null;
            }
            string strcomand = "select tipo from usuarios where usuario = '" + usuario + "' and contrasena = '" + contrasena + "'";
            SqlDataReader Lector = UsoDB.Consulta(strcomand, conn);
            if (Lector == null)
            {
                MessageBox.Show("Error en la Consulta");
                conn.Close();
                return null;
            }
            if (Lector.HasRows)
            {
                while (Lector.Read())
                {
                    //cmbDepartamento.Items.Add(Lector.GetValue(0).ToString());
                    tipo = Lector.GetValue(0).ToString();
                    return tipo;
                }
            }
            else
            {
                return null;
            }
            conn.Close();
            return tipo;
        }
    }
}
