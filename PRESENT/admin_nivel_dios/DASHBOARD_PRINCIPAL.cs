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

namespace PUNTO_DE_VENTA.PRESENT.admin_nivel_dios
{
    public partial class DASHBOARD_PRINCIPAL : Form
    {
        public DASHBOARD_PRINCIPAL()
        {
            InitializeComponent();
        }
        private void Btn_Configuracion_Click(object sender, EventArgs e)
        {
            PRESENT.CONFIGURACION.PANEL_CONFIGURACIONES frm = new PRESENT.CONFIGURACION.PANEL_CONFIGURACIONES();
            frm.FormClosed += new FormClosedEventHandler(frm_FormClosed);
            Dispose();
            frm.ShowDialog();

        }

        private void frm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Dispose();
            admin_nivel_dios.DASHBOARD_PRINCIPAL frm= new admin_nivel_dios.DASHBOARD_PRINCIPAL();
            frm.ShowDialog();
        }

        private void ListarAPERTURAS_de_detalle_de_cierres_de_caja()
        {
            try
            {
                DataTable dt = new DataTable();
                SqlDataAdapter da;
                SqlConnection con = new SqlConnection();
                con.ConnectionString = CONEXION.CONEXIONMAESTRA.conexion;
                con.Open();

                da = new SqlDataAdapter("MOSTRAR_MOVIMIENTOS_DE_CAJA_POR_SERIAL", con);
                da.SelectCommand.CommandType = CommandType.StoredProcedure;
                da.SelectCommand.Parameters.AddWithValue("@serial", lblSerialPc.Text);
                da.Fill(dt);
                datalistado_detalle_cierre_de_caja.DataSource = dt;
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }


        }
        private void MenuStrip4_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void BtnVender_Click(object sender, EventArgs e)
        {
            

        }
        private void contar_aperturas_de_cierres_de_caja()
        {
            int x;

            x = datalistado_detalle_cierre_de_caja.Rows.Count;
            contadorCajas = (x);
        }
        private void iniciar_sesion_correcto()
        {
            MOSTRAR_id_de_admin();
            IDUSUARIO.Text = Convert.ToString( id_usuarios_admin);
            MOSTRAR_CAJA_POR_SERIAL();
            try
            {
                txtidcaja.Text = datalistado_caja.SelectedCells[1].Value.ToString();
                lblcaja.Text = datalistado_caja.SelectedCells[2].Value.ToString();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            ListarAPERTURAS_de_detalle_de_cierres_de_caja();
            contar_aperturas_de_cierres_de_caja();
            if (contadorCajas == 0 & lblROL.Text != "Solo Ventas(no esta autorizado para manejar dinero)")
            {
                aperturar_detalle_de_cierre_caja();
                lblaperturaDeCaja.Text = "Nuevo*****";
                inicio_de_caja();

            }
            else
            {
                if (lblROL.Text != "Solo Ventas(no esta autorizado para manejar dinero)")
                {
                    MOSTRAR_MOVIMIENTOS_DE_CAJA_POR_SERIAL_y_usuario();
                    contar_MOSTRAR_MOVIMIENTOS_DE_CAJA_POR_SERIAL_y_usuario();
                    try
                    {
                        lblusuario_queinicioCaja.Text = datalistado_detalle_cierre_de_caja.SelectedCells[1].Value.ToString();
                        lblnombredeCajero.Text = datalistado_detalle_cierre_de_caja.SelectedCells[2].Value.ToString();
                    }
                    catch
                    {

                    }
                    if (contador_Movimientos_de_caja == 0)

                    {

                        if (lblusuario_queinicioCaja.Text != "admin" & txtlogin.Text == "admin")
                        {
                            // MessageBox.Show("Continuaras Turno de *" + lblnombredeCajero.Text + " Todos los Registros seran con ese Usuario", "Caja Iniciada", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            lblpermisodeCaja.Text = "correcto";
                        }
                        if (lblusuario_queinicioCaja.Text == "admin" & txtlogin.Text == "admin")
                        {

                            lblpermisodeCaja.Text = "correcto";
                        }

                        else if (lblusuario_queinicioCaja.Text != txtlogin.Text)
                        {
                            MessageBox.Show("Para poder continuar con el Turno de *" + lblnombredeCajero.Text + "* ,Inicia sesion con el Usuario " + lblusuario_queinicioCaja.Text + " -ó-el Usuario *admin*", "Caja Iniciada", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            lblpermisodeCaja.Text = "vacio";

                        }
                        else if (lblusuario_queinicioCaja.Text == txtlogin.Text)
                        {
                            lblpermisodeCaja.Text = "correcto";
                        }
                    }
                    else
                    {
                        lblpermisodeCaja.Text = "correcto";
                    }
                    if (lblpermisodeCaja.Text == "correcto")
                    {
                        lblaperturaDeCaja.Text = "Aperturado";
                        inicio_de_caja();

                    }

                }
                else
                {
                    inicio_de_caja();
                }


            }
        }

        void inicio_de_caja()
        {
            if (lblApertura_De_caja.Text == "Nuevo*****")
            {
                this.Hide();
                CAJA.APERTURA_DE_CAJA frm = new CAJA.APERTURA_DE_CAJA();
                frm.ShowDialog();
                Dispose();
            }
            else
            {
                this.Hide();
                VENTAS_MENU_PRINCIPAL.VENTAS_MENU_PRINCIPALOK frm = new VENTAS_MENU_PRINCIPAL.VENTAS_MENU_PRINCIPALOK();
                frm.ShowDialog();
                Dispose();
            }

        }
        private void aperturar_detalle_de_cierre_caja()
        {
            try
            {


                SqlConnection con = new SqlConnection();
                con.ConnectionString = CONEXION.CONEXIONMAESTRA.conexion;
                con.Open();
                SqlCommand cmd = new SqlCommand();
                cmd = new SqlCommand("insertar_DETALLE_cierre_de_caja", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@fechaini", DateTime.Today);
                cmd.Parameters.AddWithValue("@fechafin", DateTime.Today);
                //cmd.Parameters.AddWithValue("@fecha", DateTime.Today);

                cmd.Parameters.AddWithValue("@fechacierre", DateTime.Today);
                cmd.Parameters.AddWithValue("@ingresos", "0.00");
                cmd.Parameters.AddWithValue("@egresos", "0.00");
                cmd.Parameters.AddWithValue("@saldo", "0.00");
                cmd.Parameters.AddWithValue("@idusuario", IDUSUARIO.Text);
                cmd.Parameters.AddWithValue("@totalcaluclado", "0.00");
                cmd.Parameters.AddWithValue("@totalreal", "0.00");

                cmd.Parameters.AddWithValue("@estado", "CAJA APERTURADA");
                cmd.Parameters.AddWithValue("@diferencia", "0.00");
                cmd.Parameters.AddWithValue("@id_caja", txtidcaja.Text);

                cmd.ExecuteNonQuery();
                con.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void MOSTRAR_MOVIMIENTOS_DE_CAJA_POR_SERIAL_y_usuario()
        {
            try
            {
                DataTable dt = new DataTable();
                SqlDataAdapter da;
                SqlConnection con = new SqlConnection();
                con.ConnectionString = CONEXION.CONEXIONMAESTRA.conexion;
                con.Open();

                da = new SqlDataAdapter("MOSTRAR_MOVIMIENTOS_DE_CAJA_POR_SERIAL_y_usuario", con);
                da.SelectCommand.CommandType = CommandType.StoredProcedure;
                da.SelectCommand.Parameters.AddWithValue("@serial", lblIDSERIAL.Text);
                da.SelectCommand.Parameters.AddWithValue("@idusuario", IDUSUARIO.Text);
                da.Fill(dt);
                datalistado_movimientos_validar.DataSource = dt;
                con.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }


        }
        int contador_Movimientos_de_caja;
        private void contar_MOSTRAR_MOVIMIENTOS_DE_CAJA_POR_SERIAL_y_usuario()
        {
            int x;

            x = datalistado_movimientos_validar.Rows.Count;
            contador_Movimientos_de_caja = (x);

        }
        private void MOSTRAR_CAJA_POR_SERIAL()
        {

            try
            {
                DataTable dt = new DataTable();
                SqlDataAdapter da;
                SqlConnection con = new SqlConnection();
                con.ConnectionString = CONEXION.CONEXIONMAESTRA.conexion;
                con.Open();

                da = new SqlDataAdapter("mostrar_cajas_por_Serial_de_DiscoDuro", con);
                da.SelectCommand.CommandType = CommandType.StoredProcedure;
                da.SelectCommand.Parameters.AddWithValue("@Serial", lblSerialPc.Text);
                da.Fill(dt);
                datalistado_caja.DataSource = dt;
                con.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }

        }
        int id_usuarios_admin;
        private void MOSTRAR_id_de_admin()
        {
            try
            {
                SqlConnection con = new SqlConnection();
                con.ConnectionString = CONEXION.CONEXIONMAESTRA.conexion;
                SqlCommand da = new SqlCommand("select idUsuario from USUARIO2 WHERE Login='admin'", con);


                con.Open();
                id_usuarios_admin = Convert.ToInt32(da.ExecuteScalar());
                con.Close();



            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }



        }

        private void DASHBOARD_PRINCIPAL_Load(object sender, EventArgs e)
        {
            ManagementObject MOS = new ManagementObject(@"Win32_PhysicalMedia='\\.\PHYSICALDRIVE0'");

            lblSerialPc.Text = MOS.Properties["SerialNumber"].Value.ToString();
            lblSerialPc.Text = lblSerialPc.Text.Trim();
        }
        int contadorCajas;

        private void Timer2_Tick(object sender, EventArgs e)
        {
        }

        private void Btn_Notificacion_Click(object sender, EventArgs e)
        {
            
        }

        private void Button3_Click(object sender, EventArgs e)
        {

        }

        private void BtnVender_Click_1(object sender, EventArgs e)
        {
            iniciar_sesion_correcto();
        }

   
    }
}
