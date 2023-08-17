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
using System.Text.RegularExpressions;
using System.IO;

namespace PUNTO_DE_VENTA.sevendePor.EMPRESA_CONFIGURACION
{
    public partial class EMPRESA_CONFIG : Form
    {
        public EMPRESA_CONFIG()
        {
            InitializeComponent();
        }
        string Vendes_con_impuestos;
        string tipo_de_busqueda;
        private void EMPRESA_CONFIG_Load(object sender, EventArgs e)
        {
            mostrar();
            Obtener_datos();
        }
        private void Obtener_datos()
        {
            txtEmpresa.Text = dataListado.SelectedCells[2].Value.ToString();
            ImagenEmpresa.BackgroundImage = null;
            byte[] b = (Byte[])dataListado.SelectedCells[1].Value;
            MemoryStream ms = new MemoryStream(b);
            ImagenEmpresa.Image = Image.FromStream(ms);

            txtPais.Text = dataListado.SelectedCells[13].Value.ToString();
            txtMoneda.Text = dataListado.SelectedCells[4].Value.ToString();
            Vendes_con_impuestos = dataListado.SelectedCells[10].Value.ToString();
            if (Vendes_con_impuestos == "SI")
            {
                Si.Checked = true;
                panelImpuesto.Visible = true;
               
            }
            if (Vendes_con_impuestos == "NO")
            {
                panelImpuesto.Visible = false;
                NO.Checked = true;
            }
            txtPorcentajeImpuesto.Text = dataListado.SelectedCells[6].Value.ToString();
            txtTipoImpuesto.Text = dataListado.SelectedCells[7].Value.ToString();
            tipo_de_busqueda = dataListado.SelectedCells[8].Value.ToString();
            if (tipo_de_busqueda == "LECTORA")
            {
               txtConLectora.Checked = true;
                txtConTeclado.Checked = false;
            }
            if (tipo_de_busqueda == "TECLADO")
            {
                txtConLectora.Checked = false;
                txtConTeclado.Checked = true;
            }
            txtRuta.Text = dataListado.SelectedCells[12].Value.ToString();
            txtCorreo.Text = dataListado.SelectedCells[11].Value.ToString();

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
                da = new SqlDataAdapter("mostrar_Empresa", con);
                da.Fill(dt);
                dataListado.DataSource = dt;
                con.Close();



            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private bool validar_mail(String sMail)
        {
            return Regex.IsMatch(sMail, @"^[_a-z0-9-]+(\.[_a-z0-9-]+)*@[a-z0-9-]+(\.[a-z0-9-]+)*(\.[a-z]{2,4})$");

        }

        private void BTN_SIGUIENTE_Y_GUARDAR_Click(object sender, EventArgs e)
        {
            if (validar_mail(txtCorreo.Text) == false)
            {
                MessageBox.Show("Dirección de correo electronico no valida, el correo debe tener el formato: nombre@dominio.com," + " por favor seleccione un correo valido", "Validación de correo electronico", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtCorreo.Focus();
                txtCorreo.SelectAll();
            }
            else
            {
                if (txtEmpresa.Text != "")
                {
                    try
                    {
                        if (NO.Checked == true)
                        {
                            Vendes_con_impuestos = "NO";
                        }
                        else
                        {
                            Vendes_con_impuestos = "SI";
                        }

                        SqlConnection con = new SqlConnection();
                        con.ConnectionString = CONEXION.CONEXIONMAESTRA.conexion;
                        con.Open();
                        SqlCommand cmd = new SqlCommand();
                        cmd = new SqlCommand("editar_Empresa", con);
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@Nombre_Empresa", txtEmpresa.Text);
                        cmd.Parameters.AddWithValue("@Impuesto", txtTipoImpuesto.Text);
                        cmd.Parameters.AddWithValue("@Porcentaje_impuesto", txtPorcentajeImpuesto.Text);
                        cmd.Parameters.AddWithValue("@Moneda", txtMoneda.Text);
                        cmd.Parameters.AddWithValue("@Trabajas_con_impuestos", Vendes_con_impuestos);

                        System.IO.MemoryStream ms = new System.IO.MemoryStream();
                        ImagenEmpresa.Image.Save(ms, ImagenEmpresa.Image.RawFormat);
                        cmd.Parameters.AddWithValue("@logo", ms.GetBuffer());
                        if (txtConLectora.Checked == true)
                        {
                            cmd.Parameters.AddWithValue("@Modo_de_busqueda", "LECTORA");
                        }
                        if (txtConTeclado.Checked == true)
                        {
                            cmd.Parameters.AddWithValue("@Modo_de_busqueda", "TECLADO");

                        }
                        cmd.Parameters.AddWithValue("@Carpeta_para_copias_de_seguridad", txtRuta.Text);
                        cmd.Parameters.AddWithValue("@Correo_para_envio_de_reportes", txtCorreo.Text);
                        cmd.ExecuteNonQuery();
                        con.Close();
                        MessageBox.Show("Cambios guardados", "Guardando Cambios", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
            }
        }

        private void Si_CheckedChanged(object sender, EventArgs e)
        {
            panelImpuesto.Visible = true;
        }

        private void NO_CheckedChanged(object sender, EventArgs e)
        {
            panelImpuesto.Visible = false;
        }

        private void TxtConLectora_CheckedChanged(object sender, EventArgs e)
        {
            if(txtConLectora.Checked==true)
            {
                txtConTeclado.Checked = false;
            }
            else
            {
                txtConTeclado.Checked = true;
            }
        }

        private void TxtConTeclado_CheckedChanged(object sender, EventArgs e)
        {
            if(txtConTeclado.Checked==true)
            {
                txtConLectora.Checked = false;
            }
            else
            {
                txtConLectora.Checked = true;
            }
        }

        private void TxtPais_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtMoneda.SelectedIndex = txtPais.SelectedIndex;

        }

        private void TxtMoneda_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtPais.SelectedIndex = txtMoneda.SelectedIndex;
        }

        private void LblEditarDialogo_Click(object sender, EventArgs e)
        {
            dlg.InitialDirectory = "";
            dlg.Filter = "Imagenes|*.jpg;*.png";
            dlg.FilterIndex = 2;
            dlg.Title = "cargador de Imagenes VEGA";
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                ImagenEmpresa.BackgroundImage = null;
                ImagenEmpresa.Image = new Bitmap(dlg.FileName);
                ImagenEmpresa.SizeMode = PictureBoxSizeMode.Zoom;
            }
        }

        private void LblRuta_Click(object sender, EventArgs e)
        {
            Obtener_ruta();   
        }
        private void Obtener_ruta()
        {
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {

                string ruta = folderBrowserDialog1.SelectedPath;
                if (ruta.Contains(@"C:\"))
                {
                    MessageBox.Show("Seleccione un disco diferente al C", "Ruta Invalida", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {
                    txtRuta.Text = folderBrowserDialog1.SelectedPath;
                }
            }
        }

        private void PictureBox4_Click(object sender, EventArgs e)
        {
            Obtener_ruta();
        }

       
    }
}
