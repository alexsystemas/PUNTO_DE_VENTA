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
using System.IO;
using System.Text.RegularExpressions;
using PUNTO_DE_VENTA.LOGIC;


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
        private void cargar_estado_de_iconos()
        {
            try
            {
                foreach (DataGridViewRow row in dataListado.Rows)
                {
                    try
                    {
                        string Icono = Convert.ToString(row.Cells["Nombre_de_Icono"].Value);

                        if (Icono == "1")
                        {
                            pictureBoxBart.Visible = false;
                        }
                        else if (Icono == "2")
                        {
                            pictureBoxBobSponja.Visible = false;
                        }
                        else if (Icono == "3")
                        {
                            pictureBoxImoji.Visible = false;
                        }
                        else if (Icono == "4")
                        {
                            pictureBox6.Visible = false;
                        }
                        else if (Icono == "5")
                        {
                            pictureBox7.Visible = false;
                        }
                        else if (Icono == "6")
                        {
                            pictureBox5.Visible = false;
                        }
                      
                       
                    }
                    catch (Exception ex)
                    {


                    }


                }
            }
            catch (Exception ex)
            {

            }
        }

        public bool validar_Mail(string sMail)
        {
            return Regex.IsMatch(sMail, @"^[_a-z0-9-]+(\.[_a-z0-9-]+)*@[a-z0-9-]+(\.[a-z0-9-]+)*(\.[a-z]{2,4})$");
        }
        private void ButtonGuardar_Click(object sender, EventArgs e)
        {
            if (validar_Mail(txtCorreo.Text) == false)
            {
                MessageBox.Show("Dirección de correo electronico no valida, el correo debe tener el formato: nombre@dominio.com, " + " por favor seleccione un correo valido", "Validación de correo electronico", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtCorreo.Focus();
                txtCorreo.SelectAll();
            }
            else
            {
                if (txtNombre.Text != "")

                {
                    if (txtRol.Text != "")
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
                        cmd.Parameters.AddWithValue("@Password",Bases.Encriptar( txtPassword.Text));
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
        
                    else
                    {
                        MessageBox.Show("Elija un Rol", "Registro", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    }

}
                else
                {
                    MessageBox.Show("Asegúrese de haber llenado todos los campos para poder continuar", "Registro", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }


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

            Bases.Multilinea(ref dataListado);




        }

        private void ICONO_Click(object sender, EventArgs e)
        {
            cargar_estado_de_iconos();
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
            ICONO.Image = Image.FromFile(@"C:\RESPALDO PUNTO DE VENTA\IMAGENES\agregar_icono2.png");
            txtNombre.Text = "";
            txtLogin.Text = "";
            txtPassword.Text = "";
            txtCorreo.Text = "";
            buttonGuardar.Visible = true;
            btnGuardarCambios.Visible = false;

        }

        private void ButtonCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void LabelUsuarios_Click(object sender, EventArgs e)
        {

        }

        private void DataListado_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            panelContenido.Visible = true;
            panelDatos.Visible = true;
            buttonGuardar.Visible = false;
            btnGuardarCambios.Visible = true;

            lblidUsuario.Text = dataListado.SelectedCells[1].Value.ToString(); // traemos el idusuario y lo agregamos a ala variable lblidUsuario
            txtNombre.Text = dataListado.SelectedCells[2].Value.ToString();
            txtLogin.Text = dataListado.SelectedCells[3].Value.ToString();
            txtPassword.Text = dataListado.SelectedCells[4].Value.ToString();

            ICONO.BackgroundImage = null;
            byte[] b = (Byte[])dataListado.SelectedCells[5].Value;
            MemoryStream ms = new MemoryStream(b);
            ICONO.Image = Image.FromStream(ms);
            ICONO.SizeMode = PictureBoxSizeMode.Zoom;

            lblNumeroIcono.Text = dataListado.SelectedCells[6].Value.ToString();
            txtCorreo.Text = dataListado.SelectedCells[7].Value.ToString();
            txtRol.Text = dataListado.SelectedCells[8].Value.ToString();




        }

        private void PictureBox4_Click(object sender, EventArgs e)
        {
            panelDatos.Visible = false;
            PANEL_ICONOS.Visible = false;
            panelContenido.Visible = false;
        }

        private void Btn_retorno_Click(object sender, EventArgs e)
        {
            PANEL_ICONOS.Visible = false;
            panelDatos.Visible = true;
        }

        private void BtnGuardarCambios_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtNombre.Text != "")
                {
                    SqlConnection con = new SqlConnection(); //creamos variable para conexion
                    con.ConnectionString = CONEXION.CONEXIONMAESTRA.conexion;// nos conectamos con la variable
                    con.Open(); // abrimos la conexion 
                    SqlCommand cmd = new SqlCommand();// creamos una variable cmd 
                    cmd = new SqlCommand("editar_usuario", con); //traemos nuetro procedimiento almacenado
                    cmd.CommandType = CommandType.StoredProcedure;//insertamos parametros
                    cmd.Parameters.AddWithValue("@idUsuario", lblidUsuario.Text); //insertamos el parametro nombre de a la BD.
                    cmd.Parameters.AddWithValue("@nombres", txtNombre.Text);
                    cmd.Parameters.AddWithValue("@login", txtLogin.Text);
                    cmd.Parameters.AddWithValue("@Password", txtPassword.Text);

                    cmd.Parameters.AddWithValue("@Correo", txtCorreo.Text);
                    cmd.Parameters.AddWithValue("@Rol", txtRol.Text);

                    System.IO.MemoryStream ms = new System.IO.MemoryStream(); //linea para procesar las imagenes y memorizar y crea la variable ms
                    ICONO.Image.Save(ms, ICONO.Image.RawFormat);// Guarda una imagen trasformada a un formato SQLSERVER en una variable ms

                    cmd.Parameters.AddWithValue("@Icono", ms.GetBuffer());// getbuuffer lo trsforma a binario  
                    cmd.Parameters.AddWithValue("@Nombre_de_Icono", lblNumeroIcono.Text);
                    //cmd.Parameters.AddWithValue("@Estado", "ACTIVO");
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

        private void DataListado_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == this.dataListado.Columns["Eli"].Index)
            {
                DialogResult result;
                result = MessageBox.Show("¿ Realmente desea eliminar este usuario?", "Eliminando registros", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (result == DialogResult.OK)
                {
                    SqlCommand cmd;
                    try
                    {
                        foreach (DataGridViewRow row in dataListado.SelectedRows)
                        {
                            int onekey = Convert.ToInt32(row.Cells["idUsuario"].Value);
                            string usuario = Convert.ToString(row.Cells["Login"].Value);
                            try
                            {
                                try
                                {


                                    SqlConnection con = new SqlConnection();
                                    con.ConnectionString = CONEXION.CONEXIONMAESTRA.conexion;
                                    con.Open();


                                    cmd = new SqlCommand("eliminar_usuario", con);
                                    cmd.CommandType = CommandType.StoredProcedure;

                                    cmd.Parameters.AddWithValue("@idUsuario", onekey);
                                    cmd.Parameters.AddWithValue("@login", usuario);
                                    cmd.ExecuteNonQuery();
                                    con.Close();


                                }
                                catch (Exception ex)
                                {
                                    MessageBox.Show(ex.Message);

                                }
                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show(ex.Message);
                            }
                        }
                        mostrar();

                    }
                    catch (Exception ex)
                    {

                    }
                }
            }
        }

        private void Cargar_imagen_Click(object sender, EventArgs e)
        {
            dlg.InitialDirectory = "";
            dlg.Filter = "Imagenes|*.jpg;*.png";
            dlg.FilterIndex = 2;
            dlg.Title = "Cargador de Imagenes ";
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                ICONO.BackgroundImage = null;
                ICONO.Image = new Bitmap(dlg.FileName);
                ICONO.SizeMode = PictureBoxSizeMode.Zoom;
                lblNumeroIcono.Text = Path.GetFileName(dlg.FileName);
                PANEL_ICONOS.Visible = false;
                panelDatos.Visible = true;
            }
        }
        private void buscar_usuario()
        {
            try
            {
                DataTable dt = new DataTable();
                SqlDataAdapter da;
                SqlConnection con = new SqlConnection();
                con.ConnectionString = CONEXION.CONEXIONMAESTRA.conexion;
                con.Open();

                da = new SqlDataAdapter("buscar_usuario", con);
                da.SelectCommand.CommandType = CommandType.StoredProcedure;
                da.SelectCommand.Parameters.AddWithValue("@letra", txtBuscar.Text);
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

            Bases.Multilinea(ref dataListado);

        }
        private void TxtBuscar_TextChanged(object sender, EventArgs e)
        {
            buscar_usuario();
        }

        public void Numeros(System.Windows.Forms.TextBox CajaTexto, System.Windows.Forms.KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsControl(e.KeyChar))
            {
                e.Handled = false;

            }
            else
            {
                e.Handled = true;

            }
        }

        private void TxtPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            Numeros(txtBuscar, e);
        }

        private void PanelDatos_Paint(object sender, PaintEventArgs e)
        {

        }

        private void BtnCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
