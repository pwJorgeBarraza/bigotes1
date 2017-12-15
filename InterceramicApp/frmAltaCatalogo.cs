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
    public partial class frmAltaCatalogo : Form
    {
        public frmAltaCatalogo()
        {
            InitializeComponent();
        }

        private void btnAlta_Click(object sender, EventArgs e)
        {
            //string strCon = "Data Source=DESKTOP-5J98UPE\\SQLEXPRESS;Initial Catalog=Interceramic;Integrated Security=True";
            string strCon = "Data Source=DESKTOP-5J98UPE\\SQLEXPRESS;Initial Catalog=Interceramic;Integrated Security=True";
            SqlConnection conn = UsoDB.ConectaBD(strCon);
            if (txtIncidencia.Text == "" || txtSolucion1.Text == "" || txtTiempo.Text == "")
            {
                MessageBox.Show("Datos vacios", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {



                string incidencia = txtIncidencia.Text;
                string solucion1 = txtSolucion1.Text;
                string solucion2 = txtSolucion2.Text;
                string tiempo = txtTiempo.Text;
                string strComando = "insert into catalogo(incidencia,solucion1,solucion2,tiemposolucion)";
                strComando += "values (@incidencia, @solucion1,@solucion2, @tiemposolucion)";
                SqlCommand cmd = new SqlCommand(strComando, conn);
                cmd.Parameters.AddWithValue("@incidencia", incidencia);
                cmd.Parameters.AddWithValue("@solucion1", solucion1);
                cmd.Parameters.AddWithValue("@solucion2", solucion2);
                cmd.Parameters.AddWithValue("@tiemposolucion", tiempo);
                try
                {
                    cmd.ExecuteNonQuery();
                }
                catch (SqlException ex)
                {
                    MessageBox.Show(ex.Message);
                }
                MessageBox.Show("CATALOGO ACTUALIZADO", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Limpiar();
                conn.Close();
            }
        }
               public void Limpiar()
               {
                txtIncidencia.Text = "";
                txtSolucion1.Text = "";
                txtTiempo.Text = "";
                txtSolucion2.Text = "";
               }

        private void frmAltaCatalogo_Load(object sender, EventArgs e)
        {

        }
    }
}
