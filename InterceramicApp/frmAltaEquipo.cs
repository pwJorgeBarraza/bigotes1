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
    public partial class frmAltaEquipo : Form
    {
        public frmAltaEquipo()
        {
            InitializeComponent();
            CargaDepartamento();
        }

        private void cmbDepartamento_SelectedIndexChanged(object sender, EventArgs e)
        {
            {
                string clave = cmbDepartamento.SelectedIndex.ToString();
<<<<<<< HEAD
                string strCon = "Data Source=DESKTOP-5J98UPE\\SQLEXPRESS;Initial Catalog=Interceramic;Integrated Security=True";
=======
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
                string strComando = "select nombre from departamento";
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

                        
                    }
                }
                conn.Close();
            }
        }
        public void CargaDepartamento()
        {
            string clave = cmbDepartamento.SelectedIndex.ToString();
<<<<<<< HEAD
            string strCon = "Data Source=DESKTOP-5J98UPE\\SQLEXPRESS;Initial Catalog=Interceramic;Integrated Security=True";
=======
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
            string strComando = "SELECT nombre from departamento";
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

        private void frmAltaEquipo_Load(object sender, EventArgs e)
        {

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
            if (txtDispositivo.Text == "" || cmbDepartamento.SelectedIndex <= 0 ||txtGarantia.Text == "" || txtMarca.Text == "" || txtModelo.Text == "" || txtProveedor.Text == "" || txtTipo.Text == "")

            {
                MessageBox.Show("Datos vacios", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                string departamento = cmbDepartamento.SelectedText.ToString();
                string dispositivo = txtDispositivo.Text;
                string tipo = txtTipo.Text;
                string marca = txtMarca.Text;
                string proveedor = txtProveedor.Text;
                string modelo= txtModelo.Text;
                string garantia = txtGarantia.Text;
                int cantidad = 1;
                DateTime FechaCompra = mcFecha.TodayDate.Date;
                string strComando = "insert into equipo(departamento, dispositivo, tipo, marca, fecha, garantia, proveedor, modelo, cantidad)";
                strComando += "values (@departamento, @dispositivo, @tipo, @marca, @fecha, @garantia, @proveedor, @modelo, @cantidad)";
                SqlCommand cmd = new SqlCommand(strComando, conn);
                cmd.Parameters.AddWithValue("@fecha",FechaCompra);
                cmd.Parameters.AddWithValue("@tipo", tipo);
                cmd.Parameters.AddWithValue("@dispositivo", dispositivo);
                cmd.Parameters.AddWithValue("@marca", marca);
                cmd.Parameters.AddWithValue("@garantia", garantia);
                cmd.Parameters.AddWithValue("@departamento",cmbDepartamento.Text.ToString());
                cmd.Parameters.AddWithValue("@proveedor", proveedor);
                cmd.Parameters.AddWithValue("@modelo", modelo);
                cmd.Parameters.AddWithValue("@cantidad", cantidad);


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
            txtDispositivo.Text = "";
            cmbDepartamento.SelectedIndex = -1;
            txtGarantia.Text = "";
            txtMarca.Text = "";
            txtModelo.Text = "";
            txtProveedor.Text = "";
            txtTipo.Text = "";


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

