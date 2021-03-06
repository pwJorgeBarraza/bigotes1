﻿using System;
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
    public partial class ActualizarEquipo : Form
    {
        public ActualizarEquipo()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string clave = comboBox1.Text.ToString();
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
            string strComando = "SELECT  dispositivo from rfc WHERE rfcId ='" + clave + "'";
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
                   
                    txtActual.Text = lector.GetValue(0).ToString();
                }
            }
            conn.Close();
        }

        private void ActualizarEquipo_Load(object sender, EventArgs e)
        {
            string clave = comboBox1.SelectedIndex.ToString();
            string strCon = "Data Source=DESKTOP-5J98UPE\\SQLEXPRESS;Initial Catalog=Interceramic;Integrated Security=True";
            //string strCon = "Data Source=DESKTOP-9D96CMH\\SQLEXPRESS;Initial Catalog=Interceramic;Integrated Security=True";
            SqlConnection conn = UsoDB.ConectaBD(strCon);
            if (conn == null)
            {
                MessageBox.Show("Imposible Conectar");
            }
            string strcomand = "select rfcId from rfc where estatus = 'recibido'";
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
                    comboBox1.Items.Add(Lector.GetValue(0).ToString());
                }
            }
            conn.Close();
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            string strCon = "Data Source=DESKTOP-5J98UPE\\SQLEXPRESS;Initial Catalog=Interceramic;Integrated Security=True";
            //string strCon = "Data Source=DESKTOP-9D96CMH\\SQLEXPRESS;Initial Catalog=Interceramic;Integrated Security=True";
            SqlConnection conn = UsoDB.ConectaBD(strCon);
            if (txtNuevo.Text == "" || comboBox1.SelectedIndex <= -1 || txtGarantia.Text == "" || txtMarca.Text == "" || txtModelo.Text == "" || txtProveedor.Text == "" || txtTipo.Text == "")

            {
                MessageBox.Show("Datos vacios", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                string dispositivo = txtNuevo.Text;
                string tipo = txtTipo.Text;
                string marca = txtMarca.Text;
                string proveedor = txtProveedor.Text;
                string modelo = txtModelo.Text;
                string garantia = txtGarantia.Text;
                int cantidad = 1;
                DateTime FechaCompra = mcFecha.TodayDate.Date;
                string strComando = "update equipo set dispositivo=@dispositivo, tipo=@tipo, marca=@marca, fecha=@fecha, garantia=@garantia, proveedor=@proveedor, modelo=@modelo where dispositivo='" + txtActual.Text.ToString() + "'";
                SqlCommand cmd = new SqlCommand(strComando, conn);
                cmd.Parameters.AddWithValue("@fecha", FechaCompra);
                cmd.Parameters.AddWithValue("@tipo", tipo);
                cmd.Parameters.AddWithValue("@dispositivo", dispositivo);
                cmd.Parameters.AddWithValue("@marca", marca);
                cmd.Parameters.AddWithValue("@garantia", garantia);
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
            }
        }
    }
}
