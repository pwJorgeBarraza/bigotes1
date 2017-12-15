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
        public Interceramic()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
<<<<<<< HEAD
              string strCon = "Data Source=DESKTOP-5J98UPE\\SQLEXPRESS;Initial Catalog=Interceramic;Integrated Security=True";
=======
              string strCon = "Data Source=JORGE-HPDV5;Initial Catalog=Interceramic;Integrated Security=True";
>>>>>>> master
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
<<<<<<< HEAD
            string strCon = "Data Source=DESKTOP-5J98UPE\\SQLEXPRESS;Initial Catalog=Interceramic;Integrated Security=True";
=======
            string strCon = "Data Source=JORGE-HPDV5;Initial Catalog=Interceramic;Integrated Security=True";
>>>>>>> master
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
<<<<<<< HEAD
            string strCon = "Data Source=DESKTOP-5J98UPE\\SQLEXPRESS;Initial Catalog=Interceramic;Integrated Security=True";
=======
            string strCon = "Data Source=JORGE-HPDV5;Initial Catalog=Interceramic;Integrated Security=True";
>>>>>>> master
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
    }
}
