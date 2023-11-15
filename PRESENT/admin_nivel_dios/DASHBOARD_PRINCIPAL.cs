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
using System.IO;

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
        string Base_De_datos = "BASE_PUNTO_VENTA";
        string Servidor = @".\SQLEXPRESS";
        string ruta;
        string ResultadoLicencia;
        string FechaFinal;
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
            validarLicencia();
            Bases.Obtener_serialPC(ref lblSerialPc);
            Obtener_datos.obtener_id_caja_PorSerial(ref idcajavariable);
            Obtener_datos.mostrar_inio_de_secion( ref idusuariovariable);
        }

        private void validarLicencia()
        {
            DLicencias funcion = new DLicencias();
            funcion.ValidarLicencias(ref ResultadoLicencia, ref FechaFinal);
            if (ResultadoLicencia == "?ACTIVO?")
            {
                lblestadoLicencia.Text = "Licencia de Prueba Activada hasta el: " + FechaFinal;
                btnLicencia.Visible = true;
            }
            if (ResultadoLicencia == "?ACTIVADO PRO?")
            {
                lblestadoLicencia.Text = "Licencia PROFESIONAL Activada hasta el: " + FechaFinal;
                btnLicencia.Visible = false;
            }
            if (ResultadoLicencia == "VENCIDA")

            {
                funcion.EditarMarcanVencidas();
                Dispose();
                LICENCIAS_MEMBRESIAS.Membresias frm = new LICENCIAS_MEMBRESIAS.Membresias();
                frm.ShowDialog();

            }



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

        private void BtnRestaurar_Click(object sender, EventArgs e)
        {
            RestaurarBdExpress();
        }
        private void RestaurarBdExpress()
        {
            dlg.InitialDirectory = "";
            dlg.Filter = "Backup " + Base_De_datos + "|*.bak";
            dlg.FilterIndex = 2;
            dlg.Title = "Cargador de Backup";
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                ruta = Path.GetFullPath(dlg.FileName);
                DialogResult pregunta = MessageBox.Show("Usted está a punto de restaurar la base de datos," + "asegurese de que el archivo .bak sea reciente, de" + "lo contrario podría perder información y no podrá" + "recuperarla, ¿desea continuar?", "Restauración de base de datos", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (pregunta == DialogResult.Yes)
                {
                    SqlConnection cnn = new SqlConnection("Server=" + Servidor + ";database=master; integrated security=yes");
                    try
                    {
                        cnn.Open();
                        string Proceso = "EXEC msdb.dbo.sp_delete_database_backuphistory @database_name = N'" + Base_De_datos + "' USE [master] ALTER DATABASE [" + Base_De_datos + "] SET SINGLE_USER WITH ROLLBACK IMMEDIATE DROP DATABASE [" + Base_De_datos + "] RESTORE DATABASE " + Base_De_datos + " FROM DISK = N'" + ruta + "' WITH FILE = 1, NOUNLOAD, REPLACE, STATS = 10";
                        SqlCommand BorraRestaura = new SqlCommand(Proceso, cnn);
                        BorraRestaura.ExecuteNonQuery();
                        MessageBox.Show("La base de datos ha sido restaurada satisfactoriamente! Vuelve a Iniciar El Aplicativo", "Restauración de base de datos", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Dispose();


                    }
                    catch (Exception)
                    {
                        RestaurarNoExpress();
                    }
                    finally
                    {
                        if (cnn.State == ConnectionState.Open)
                        {
                            cnn.Close();
                        }

                    }


                }
            }
        }

        private void RestaurarNoExpress()
        {
            Servidor = ".";
            SqlConnection cnn = new SqlConnection("Server=" + Servidor + ";database=master; integrated security=yes");
            try
            {
                cnn.Open();
                string Proceso = "EXEC msdb.dbo.sp_delete_database_backuphistory @database_name = N'" + Base_De_datos + "' USE [master] ALTER DATABASE [" + Base_De_datos + "] SET SINGLE_USER WITH ROLLBACK IMMEDIATE DROP DATABASE [" + Base_De_datos + "] RESTORE DATABASE " + Base_De_datos + " FROM DISK = N'" + ruta + "' WITH FILE = 1, NOUNLOAD, REPLACE, STATS = 10";
                SqlCommand BorraRestaura = new SqlCommand(Proceso, cnn);
                BorraRestaura.ExecuteNonQuery();
                MessageBox.Show("La base de datos ha sido restaurada satisfactoriamente! Vuelve a Iniciar El Aplicativo", "Restauración de base de datos", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Dispose();


            }
            catch (Exception)
            {

            }
            finally
            {
                if (cnn.State == ConnectionState.Open)
                {
                    cnn.Close();
                }

            }
        }

        private void BtnLicencia_Click(object sender, EventArgs e)
        {
            LICENCIAS_MEMBRESIAS.Membresias frm = new LICENCIAS_MEMBRESIAS.Membresias();
            frm.ShowDialog();
        }
    }
}
