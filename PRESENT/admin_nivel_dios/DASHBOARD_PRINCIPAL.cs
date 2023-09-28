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
using PUNTO_DE_VENTA.LOGIC;
using PUNTO_DE_VENTA.DATE;

namespace PUNTO_DE_VENTA.PRESENT.admin_nivel_dios
{
    public partial class DASHBOARD_PRINCIPAL : Form
    {
        public DASHBOARD_PRINCIPAL()
        {
            InitializeComponent();
        }
        int contadorCajas;
        int contador_Movimientos_de_caja;
        string lblaperturaDeCaja;
        string lblSerialPc;
        int idcajavariable;
        int idusuariovariable;
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
            admin_nivel_dios.DASHBOARD_PRINCIPAL frm = new admin_nivel_dios.DASHBOARD_PRINCIPAL();
            frm.ShowDialog();
        }
        private void DASHBOARD_PRINCIPAL_Load(object sender, EventArgs e)
        {
            Bases.Obtener_serialPC(ref lblSerialPc);
            Obtener_datos.obtener_id_caja_PorSerial(ref idcajavariable);
            Obtener_datos.mostrar_inio_de_secion( ref idusuariovariable);
        }


        private void BtnVender_Click(object sender, EventArgs e)
        {
            validar_aperturas_de_caja();

        }
        private void ListarCierres_de_caja()
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
                da.SelectCommand.Parameters.AddWithValue("@serial", lblSerialPc);
                da.Fill(dt);
                datalistado_detalle_cierre_de_caja.DataSource = dt;
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }


        }
        private void contar_cierres_de_caja() // creamos un metodo para realizar un conteo
        {
            int x;

            x = datalistado_detalle_cierre_de_caja.Rows.Count;
            contadorCajas = (x);
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
                cmd.Parameters.AddWithValue("@fechaini", DateTime.Now);
                cmd.Parameters.AddWithValue("@fechafin", DateTime.Now);
                cmd.Parameters.AddWithValue("@fechacierre", DateTime.Now);
                cmd.Parameters.AddWithValue("@ingresos", "0.00");
                cmd.Parameters.AddWithValue("@egresos", "0.00");
                cmd.Parameters.AddWithValue("@saldo", "0.00");
                cmd.Parameters.AddWithValue("@idusuario", idusuariovariable);
                cmd.Parameters.AddWithValue("@totalcaluclado", "0.00");
                cmd.Parameters.AddWithValue("@totalreal", "0.00");

                cmd.Parameters.AddWithValue("@estado", "CAJA APERTURADA");
                cmd.Parameters.AddWithValue("@diferencia", "0.00");
                cmd.Parameters.AddWithValue("@id_caja", idcajavariable);

                cmd.ExecuteNonQuery();
                con.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void mostrar_movimientos_de_caja_por_serial_y_usuario()
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
                da.SelectCommand.Parameters.AddWithValue("@serial", lblSerialPc);
                da.SelectCommand.Parameters.AddWithValue("@idusuario", idusuariovariable);
                da.Fill(dt);
                datalistado_movimientos_validar.DataSource = dt;
                con.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }

        }
        private void contar_movimientos_de_caja_por_usuario()
        {
            int x;

            x = datalistado_movimientos_validar.Rows.Count;
            contador_Movimientos_de_caja = (x);

        }
        private void obtener_usuario_que_aperturo_caja()
        {
            try
            {
                lblusuario_queinicioCaja.Text = datalistado_detalle_cierre_de_caja.SelectedCells[1].Value.ToString();
                lblnombredeCajero.Text = datalistado_detalle_cierre_de_caja.SelectedCells[2].Value.ToString();
            }
            catch
            {

            }
        }
        private void validar_aperturas_de_caja()
        {
            ListarCierres_de_caja();
            contar_cierres_de_caja();
            if (contadorCajas == 0)
            {
                aperturar_detalle_de_cierre_caja();
                lblaperturaDeCaja = "Nuevo*****";
                ingresar_a_ventas();

            }
            else
            {
                mostrar_movimientos_de_caja_por_serial_y_usuario();
                contar_movimientos_de_caja_por_usuario();

                if (contador_Movimientos_de_caja == 0)
                {
                    obtener_usuario_que_aperturo_caja();
                    MessageBox.Show("Continuar con el Turno de *" + lblnombredeCajero.Text + "* ,Todos los registros seran con ese Usuario ","Caja Iniciada", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                    lblaperturaDeCaja = "Aperturado";
                    ingresar_a_ventas();
            }
        }

        private void ingresar_a_ventas()
        {
            if (lblaperturaDeCaja == "Nuevo*****" )
            {
                Dispose();
                CAJA.APERTURA_DE_CAJA frmCaja = new CAJA.APERTURA_DE_CAJA();
                frmCaja.ShowDialog();
            }
            else if (lblaperturaDeCaja == "Aperturado" )
            {
                Dispose();
                VENTAS_MENU_PRINCIPAL.VENTAS_MENU_PRINCIPALOK frmVentas = new VENTAS_MENU_PRINCIPAL.VENTAS_MENU_PRINCIPALOK();
                frmVentas.ShowDialog();

            }
         }

        private void LblCopiaSeguridad_Click(object sender, EventArgs e)
        {
            PRESENT.COPIAS_BD.COPIA_DE_SEGURIADAD frm = new PRESENT.COPIAS_BD.COPIA_DE_SEGURIADAD();
            frm.ShowDialog();
        }

        private void PckSeguridad_Click(object sender, EventArgs e)
        {
            PRESENT.COPIAS_BD.COPIA_DE_SEGURIADAD frm = new PRESENT.COPIAS_BD.COPIA_DE_SEGURIADAD();
            frm.ShowDialog();
        }
    }
}
