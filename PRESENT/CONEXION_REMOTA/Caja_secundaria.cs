using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using PUNTO_DE_VENTA.LOGIC;

namespace PUNTO_DE_VENTA.PRESENT.CONEXION_REMOTA
{
    public partial class Caja_secundaria : Form
    {
        public Caja_secundaria()
        {
            InitializeComponent();
        }
        string serialPc;
        public static string lblconexion;
        private void Caja_secundaria_Load(object sender, EventArgs e)
        {
            Bases.Obtener_serialPC(ref serialPc);
        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            if(!string.IsNullOrEmpty(txtcaja.Text))
            {
                Ingresar_caja();
            }
            else
            {
                MessageBox.Show("Datos Incompletos");
            }
            
        }

        private void Ingresar_caja()
        {
            try
            {


                SqlConnection conexionExpress = new SqlConnection(lblconexion);
                conexionExpress.Open();
                SqlCommand cmd = new SqlCommand();
                cmd = new SqlCommand("Insertar_caja", conexionExpress);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@descripcion", txtcaja.Text);
                cmd.Parameters.AddWithValue("@Tema", "Redentor");
                cmd.Parameters.AddWithValue("@Serial_PC", serialPc);
                cmd.Parameters.AddWithValue("@Impresora_Ticket", "Ninguna");
                cmd.Parameters.AddWithValue("@Impresora_A4", "Ninguna");
                cmd.Parameters.AddWithValue("@Tipo", "SECUNDARIA");
                cmd.ExecuteNonQuery();
                conexionExpress.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void iniciar_inicio_de_sesion()
        {
            try
            {


                SqlConnection conexionExpress = new SqlConnection(lblconexion);
                conexionExpress.Open();
                SqlCommand cmd = new SqlCommand();
                cmd = new SqlCommand("Insertar_caja", conexionExpress);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Id_serial_Pc", serialPc);
                cmd.ExecuteNonQuery();
                conexionExpress.Close();
                iniciar_inicio_de_sesion();
                MessageBox.Show("Listo ya Tienes Esta CAJA Habilitada", "Caja Registrada", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Dispose();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            Dispose();
        }
    }
}
