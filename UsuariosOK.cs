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
namespace PUNTO_DE_VENTA
{
    public partial class UsuariosOK : Form
    {
        public UsuariosOK()
        {
            InitializeComponent();
        }

        private void UsuariosOK_Load(object sender, EventArgs e)
        {
            mostrar();
            panelDatos.Visible = false;
            panelContenido.Visible = false;
           // dataListado.Visible = true;
        }

        private void ButtonGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtNombre.Text != "")
                {
                    SqlConnection con = new SqlConnection(); //creamos variable para conexion
                    con.ConnectionString = CONEXION.CONEXIONMAESTRA.conexion;// nos conectamos con la variable
                    con.Open(); // abrimos la conexion 
                    SqlCommand cmd = new SqlCommand();// creamos una variable cmd 
                    cmd = new SqlCommand("insertar_usuario", con); //traemos nuetro procedimiento almacenado
                    cmd.CommandType = CommandType.StoredProcedure;//insertamos parametros
                    cmd.Parameters.AddWithValue("@nombres", txtNombre.Text); //insertamos el parametro nombre de a la BD.
                    cmd.Parameters.AddWithValue("@login", txtLogin.Text);
                    cmd.Parameters.AddWithValue("@Password", txtPassword.Text);
                    cmd.Parameters.AddWithValue("@Correo", txtCorreo.Text);
                    cmd.Parameters.AddWithValue("@Rol", txtRol.Text);

                    System.IO.MemoryStream ms = new System.IO.MemoryStream(); //linea para procesar las imagenes y memorizar y crea la variable ms
                    ICONO.Image.Save(ms, ICONO.Image.RawFormat);// Guarda una imagen trasformada a un formato SQLSERVER en una variable ms

                    cmd.Parameters.AddWithValue("@Icono", ms.GetBuffer());// getbuuffer lo trsforma a binario  
                    cmd.Parameters.AddWithValue("@Nombre_de_Icono", lblNumeroIcono.Text);
                    cmd.Parameters.AddWithValue("@Estado", "ACTIVO");
                    cmd.ExecuteNonQuery();
                    con.Close();
                    
                      panelContenido.Visible = false;
                      panelDatos.Visible = false;
                      mostrar();  
                   // dataListado.Visible = true;  
                      

                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

           

        }

        private void mostrar()
        {
            try
            {
                DataTable dt = new DataTable();
                SqlDataAdapter da;
                SqlConnection con = new SqlConnection();
                con.ConnectionString = CONEXION.CONEXIONMAESTRA.conexion;
                con.Open();

                SqlCommand cmd = new SqlCommand();
                da = new SqlDataAdapter("mostrar_usuario", con);
                da.Fill(dt);
                dataListado.DataSource = dt;
                con.Close();
                dataListado.Columns[1].Visible = false;
                dataListado.Columns[5].Visible = false;
                dataListado.Columns[6].Visible = false;
                dataListado.Columns[7].Visible = false;
                dataListado.Columns[8].Visible = false;

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

         


        }

        private void ICONO_Click(object sender, EventArgs e)
        {
            panelContenido.Visible = true;
            PANEL_ICONOS.Visible = true;
            panelDatos.Visible = false;
        }

        private void PictureBoxBart_Click(object sender, EventArgs e)
        {
            ICONO.Image = pictureBoxBart.Image; // adquirimos la imagen del pictureBox a pictureBox login
            lblNumeroIcono.Text = "1"; // el label lblNumeroIcono adquiere el nombre 1
            PANEL_ICONOS.Visible = false;
            panelDatos.Visible = true;
        }

      

        private void PictureBoxBobSponja_Click(object sender, EventArgs e)
        {
            ICONO.Image = pictureBoxBobSponja.Image; // adquirimos la imagen del pictureBox a pictureBox login
            lblNumeroIcono.Text = "2"; // el label lblNumeroIcono adquiere el nombre 2
            PANEL_ICONOS.Visible = false;
            panelDatos.Visible = true;
        }

        private void PictureBoxImoji_Click(object sender, EventArgs e)
        {
            ICONO.Image = pictureBoxImoji.Image; // adquirimos la imagen del pictureBox a pictureBox login
            lblNumeroIcono.Text = "3"; // el label lblNumeroIcono adquiere el nombre 3
            PANEL_ICONOS.Visible = false;
            panelDatos.Visible = true;
        }

        private void PictureBox6_Click(object sender, EventArgs e)
        {
            ICONO.Image = pictureBox6.Image; // adquirimos la imagen del pictureBox a pictureBox login
            lblNumeroIcono.Text = "4"; // el label lblNumeroIcono adquiere el nombre 4
            PANEL_ICONOS.Visible = false;
            panelDatos.Visible = true;
        }

        private void PictureBox7_Click(object sender, EventArgs e)
        {
            ICONO.Image = pictureBox7.Image; // adquirimos la imagen del pictureBox a pictureBox login
            lblNumeroIcono.Text = "5"; // el label lblNumeroIcono adquiere el nombre 5
            PANEL_ICONOS.Visible = false;
            panelDatos.Visible = true;
        }

        private void PictureBox5_Click(object sender, EventArgs e)
        {
            ICONO.Image = pictureBox5.Image; // adquirimos la imagen del pictureBox a pictureBox login
            lblNumeroIcono.Text = "6"; // el label lblNumeroIcono adquiere el nombre 6
            PANEL_ICONOS.Visible = false;
            panelDatos.Visible = true;
        }

        private void PictureBoxMas_Click(object sender, EventArgs e)
        {
            panelContenido.Visible = true;
            PANEL_ICONOS.Visible = false;
            panelDatos.Visible = true;
        }

        private void ButtonCerrar_Click(object sender, EventArgs e)
        {
            
        }

        private void LabelUsuarios_Click(object sender, EventArgs e)
        {

        }
    }
}
