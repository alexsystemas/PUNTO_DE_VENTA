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
using System.Management;

namespace PUNTO_DE_VENTA.sevendePor.ASISTENTE_DE_ISTALACION_servidor
{
    public partial class USUARIOS_AUTORIZADO_AL_SISTEMA : Form
    {
        public USUARIOS_AUTORIZADO_AL_SISTEMA()
        {
            InitializeComponent();
        }

        private void BTN_SIGUIENTE_Click(object sender, EventArgs e)
        {
            if (txtNombre.Text != "" && txtContraseña.Text != "" && txtUsuario.Text != "")
            {
                if (txtContraseña.Text == txtConfirmaContraseña.Text)
                {
                    string contraseña_encryptada;
                    contraseña_encryptada = CONEXION.Encryptar_en_texto.Encriptar(this.txtConfirmaContraseña.Text.Trim());
                    try
                    {
                        SqlConnection con = new SqlConnection();
                        con.ConnectionString = CONEXION.CONEXIONMAESTRA.conexion;
                        con.Open();
                        SqlCommand cmd = new SqlCommand();
                        cmd = new SqlCommand("insertar_usuario", con);
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@nombres", txtNombre.Text);
                        cmd.Parameters.AddWithValue("@Login", txtUsuario.Text);
                        cmd.Parameters.AddWithValue("@Password", contraseña_encryptada);
                        cmd.Parameters.AddWithValue("@Correo ", sevendePor.ASISTENTE_DE_ISTALACION_servidor.REGISTRO_DE_EMPRESA.correo);
                        cmd.Parameters.AddWithValue("@Rol", "Administrador (Control total)");

                        System.IO.MemoryStream ms = new System.IO.MemoryStream();
                        pictureBox1.Image.Save(ms, pictureBox1.Image.RawFormat);

                        cmd.Parameters.AddWithValue("@Icono ", ms.GetBuffer());
                        cmd.Parameters.AddWithValue("@Nombre_de_icono", "VEGA");
                        cmd.Parameters.AddWithValue("@Estado ", "ACTIVO");

                        cmd.ExecuteNonQuery();
                        con.Close();
                        Insertar_licencia_de_prueba_30_dias();
                        insertar_cliente_standar();
                        insertar_grupo_por_defecto();
                        insertar_inicio_De_sesion();
                        MessageBox.Show("!LISTO! RECUERDA que para Iniciar Sesión tu Usuario es: " + txtUsuario.Text + " y tu Contraseña es: " + txtContraseña.Text, "Registro Exitoso", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                        Dispose();
                        //Application.Restart();

                    }
                    catch (Exception ex)
                    {

                        MessageBox.Show(ex.Message);
                    }
                }
                else
                {
                    MessageBox.Show("las contraseñas no coinciden", "contraseñas incompatibles", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("falta ingrsar Datos", "Datos Incompletos", MessageBoxButtons.OKCancel);
            }
        }
        private void Insertar_licencia_de_prueba_30_dias()
        {
            DateTime today = DateTime.Now;
            DateTime fechaFinal = today.AddDays(30);
            txtfechaFinalOK.Text = Convert.ToString(fechaFinal);
            string SERIALpC;
            SERIALpC = CONEXION.Encryptar_en_texto.Encriptar(this.lblIDSERIAL.Text.Trim());
            string FECHA_FINAL;
            FECHA_FINAL = CONEXION.Encryptar_en_texto.Encriptar(this.txtfechaFinalOK.Text.Trim());
            string estado;
            estado = CONEXION.Encryptar_en_texto.Encriptar("?ACTIVO?");
            string fecha_activacion;
            fecha_activacion = CONEXION.Encryptar_en_texto.Encriptar(this.txtfechaInicio.Text.Trim());


            try
            {


                SqlConnection con = new SqlConnection();
                con.ConnectionString = CONEXION.CONEXIONMAESTRA.conexion;
                con.Open();
                SqlCommand cmd = new SqlCommand();
                cmd = new SqlCommand("Insertar_marcan", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@s", SERIALpC);
                cmd.Parameters.AddWithValue("@f", FECHA_FINAL);
                cmd.Parameters.AddWithValue("@e", estado);
                cmd.Parameters.AddWithValue("@fa", fecha_activacion);
                cmd.ExecuteNonQuery();
                con.Close();


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void insertar_cliente_standar()
        {
            try
            {


                SqlConnection con = new SqlConnection();
                con.ConnectionString = CONEXION.CONEXIONMAESTRA.conexion;
                con.Open();
                SqlCommand cmd = new SqlCommand();
                cmd = new SqlCommand("insertar_cliente", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Nombre", "GENERICO");
                cmd.Parameters.AddWithValue("@Direccion_para_factura", 0);
                cmd.Parameters.AddWithValue("@RFC ", 0);
                cmd.Parameters.AddWithValue("@movil", 0);
                cmd.Parameters.AddWithValue("@Cliente ", "NEUTRO");
                cmd.Parameters.AddWithValue("@Proveedor", "NEUTRO");
                cmd.Parameters.AddWithValue("@Estado", 0);
                cmd.Parameters.AddWithValue("@Saldo", 0);
                cmd.ExecuteNonQuery();
                con.Close();


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void insertar_grupo_por_defecto()
        {
            try
            {


                SqlConnection con = new SqlConnection();
                con.ConnectionString = CONEXION.CONEXIONMAESTRA.conexion;
                con.Open();
                SqlCommand cmd = new SqlCommand();
                cmd = new SqlCommand("insertar_Grupo", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Grupo", "General");
                cmd.Parameters.AddWithValue("@Por_defecto", "Si");

                cmd.ExecuteNonQuery();
                con.Close();


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void insertar_inicio_De_sesion()
        {
            try
            {

                string serialPC;
                serialPC = CONEXION.Encryptar_en_texto.Encriptar(this.lblSerialPc.Text.Trim());
                SqlConnection con = new SqlConnection();
                con.ConnectionString = CONEXION.CONEXIONMAESTRA.conexion;
                con.Open();
                SqlCommand cmd = new SqlCommand();
                cmd = new SqlCommand("insertar_inicio_De_sesion", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Id_serial_Pc", serialPC);

                cmd.ExecuteNonQuery();
                con.Close();


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void USUARIOS_AUTORIZADO_AL_SISTEMA_Load(object sender, EventArgs e)
        {
            ManagementObject MOS = new ManagementObject(@"Win32_PhysicalMedia='\\.\PHYSICALDRIVE0'");
                lblSerialPc.Text = MOS.Properties["SerialNumber"].Value.ToString();
        }
    }
}
