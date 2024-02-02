using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PUNTO_DE_VENTA.LOGIC;
using PUNTO_DE_VENTA.CONEXION;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;
namespace PUNTO_DE_VENTA.DATE
{
    class Obtener_datos
    {
        private static string serialPC;
        private static int idcaja;
        public static void obtener_id_caja_PorSerial(ref int idcaja)
        {
            try
            {
                Bases.Obtener_serialPC(ref serialPC);
                CONEXIONMAESTRA.abrir();
                SqlCommand com = new SqlCommand("mostrar_cajas_por_Serial_de_DiscoDuro", CONEXIONMAESTRA.conectar);
                com.CommandType = CommandType.StoredProcedure;
                com.Parameters.AddWithValue("@Serial", serialPC);
                idcaja = Convert.ToInt32(com.ExecuteScalar());
                CONEXIONMAESTRA.cerrar();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.StackTrace);
            }


        }

        public static void mostrar_ventas_en_espera_con_fecha_y_monto(ref DataTable dt)
        {
            try
            {
                CONEXIONMAESTRA.abrir();
                SqlDataAdapter da = new SqlDataAdapter("mostrar_ventas_en_espera_con_fecha_y_monto", CONEXIONMAESTRA.conectar);
                da.Fill(dt);
                CONEXIONMAESTRA.cerrar();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.StackTrace);
            }



        }
        public static void mostrar_productos_agregados_a_ventas_en_espera(ref DataTable dt, int idventa)
        {
            try
            {
                CONEXIONMAESTRA.abrir();
                SqlDataAdapter da = new SqlDataAdapter("mostrar_productos_agregados_a_ventas_en_espera", CONEXIONMAESTRA.conectar);
                da.SelectCommand.CommandType = CommandType.StoredProcedure;
                da.SelectCommand.Parameters.AddWithValue("@idventa", idventa);
                da.Fill(dt);
                CONEXIONMAESTRA.cerrar();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.StackTrace);
            }


        }
        public static void buscar_conceptos(ref DataTable dt, string buscador)
        {
            try
            {
                CONEXIONMAESTRA.abrir();
                SqlDataAdapter da = new SqlDataAdapter("buscar_conceptos", CONEXIONMAESTRA.conectar);
                da.SelectCommand.CommandType = CommandType.StoredProcedure;
                da.SelectCommand.Parameters.AddWithValue("@letra", buscador);
                da.Fill(dt);
                CONEXIONMAESTRA.cerrar();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.StackTrace);
            }

        }

        public static void mostrar_gastos_por_turnos(int idcaja, DateTime fi, DateTime ff, ref DataTable dt)
        {
            try
            {
                CONEXIONMAESTRA.abrir();
                SqlDataAdapter da = new SqlDataAdapter("mostrar_gastos_por_turnos", CONEXIONMAESTRA.conectar);
                da.SelectCommand.CommandType = CommandType.StoredProcedure;
                da.SelectCommand.Parameters.AddWithValue("@idcaja", idcaja);
                da.SelectCommand.Parameters.AddWithValue("@fi", fi);
                da.SelectCommand.Parameters.AddWithValue("@ff", ff);
                da.Fill(dt);
                CONEXIONMAESTRA.cerrar();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.StackTrace);
            }

        }

        public static void mostrar_cierre_de_caja_pendiente(ref DataTable dt)
        {
            obtener_id_caja_PorSerial(ref idcaja);
            try
            {
                CONEXIONMAESTRA.abrir();
                SqlDataAdapter da = new SqlDataAdapter("mostrar_cierre_de_caja_pendiente", CONEXIONMAESTRA.conectar);
                da.SelectCommand.CommandType = CommandType.StoredProcedure;
                da.SelectCommand.Parameters.AddWithValue("@idcaja", idcaja);

                da.Fill(dt);
                CONEXIONMAESTRA.cerrar();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

        }



        public static void mostrar_ingresos_por_turnos(int idcaja, DateTime fi, DateTime ff, ref DataTable dt)
        {
            try
            {
                CONEXIONMAESTRA.abrir();
                SqlDataAdapter da = new SqlDataAdapter("mostrar_ingresos_por_turnos", CONEXIONMAESTRA.conectar);
                da.SelectCommand.CommandType = CommandType.StoredProcedure;
                da.SelectCommand.Parameters.AddWithValue("@idcaja", idcaja);
                da.SelectCommand.Parameters.AddWithValue("@fi", fi);
                da.SelectCommand.Parameters.AddWithValue("@ff", ff);
                da.Fill(dt);
                CONEXIONMAESTRA.cerrar();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.StackTrace);
            }

        }


        public static void mostrar_inio_de_secion(ref int idusuario)
        {
            Bases.Obtener_serialPC(ref serialPC);
            try
            {
                CONEXIONMAESTRA.abrir();
                SqlCommand cmd = new SqlCommand("mostrar_inicio_De_sesion", CONEXIONMAESTRA.conectar);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id_serial_pc", serialPC);
                idusuario = Convert.ToInt32(cmd.ExecuteScalar());
                CONEXIONMAESTRA.cerrar();

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.StackTrace);
            }
        }
        public static void mostrarUsuariosSesion(ref DataTable dt)
        {
            try
            {
                Bases.Obtener_serialPC(ref serialPC);
                CONEXIONMAESTRA.abrir();
                SqlDataAdapter da = new SqlDataAdapter("mostrar_inicio_De_sesion", CONEXIONMAESTRA.conectar);
                da.SelectCommand.CommandType = CommandType.StoredProcedure;
                da.SelectCommand.Parameters.AddWithValue("@id_serial_pc", serialPC);
                da.Fill(dt);
                CONEXIONMAESTRA.cerrar();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.StackTrace);
            }
        }
        public static void mostrar_ventas_en_efectivo_por_turno(int idcaja, DateTime fi, DateTime ff, ref Double monto)
        {
            try
            {
                CONEXIONMAESTRA.abrir();
                SqlCommand da = new SqlCommand("mostrar_ventas_en_efectivo_por_turno", CONEXIONMAESTRA.conectar);
                da.CommandType = CommandType.StoredProcedure;
                da.Parameters.AddWithValue("@idcaja", idcaja);
                da.Parameters.AddWithValue("@fi", fi);
                da.Parameters.AddWithValue("@ff", ff);
                monto = Convert.ToDouble(da.ExecuteScalar());
                CONEXIONMAESTRA.cerrar();
            }
            catch (Exception ex)
            {
                monto = 0;

            }
        }

        public static void mostrar_ventas_Tarjeta_por_turno(int idcaja, DateTime fi, DateTime ff, ref Double monto)
        {
            try
            {
                CONEXIONMAESTRA.abrir();
                SqlCommand da = new SqlCommand("mostrar_ventas_Tarjeta_por_turno", CONEXIONMAESTRA.conectar);
                da.CommandType = CommandType.StoredProcedure;
                da.Parameters.AddWithValue("@idcaja", idcaja);
                da.Parameters.AddWithValue("@fi", fi);
                da.Parameters.AddWithValue("@ff", ff);
                monto = Convert.ToDouble(da.ExecuteScalar());
                CONEXIONMAESTRA.cerrar();
            }
            catch (Exception ex)
            {
                monto = 0;

            }
        }

        public static void mostrar_ventas_creadito_por_turno(int idcaja, DateTime fi, DateTime ff, ref Double monto)
        {
            try
            {
                CONEXIONMAESTRA.abrir();
                SqlCommand da = new SqlCommand("mostrar_ventas_creadito_por_turno", CONEXIONMAESTRA.conectar);
                da.CommandType = CommandType.StoredProcedure;
                da.Parameters.AddWithValue("@idcaja", idcaja);
                da.Parameters.AddWithValue("@fi", fi);
                da.Parameters.AddWithValue("@ff", ff);
                monto = Convert.ToDouble(da.ExecuteScalar());
                CONEXIONMAESTRA.cerrar();
            }
            catch (Exception ex)
            {
                monto = 0;

            }
        }

        public static void sumar_ingresos_por_turno(int idcaja, DateTime fi, DateTime ff, ref double monto)
        {
            try
            {
                CONEXIONMAESTRA.abrir();
                SqlCommand da = new SqlCommand("sumar_ingresos_por_turno", CONEXIONMAESTRA.conectar);
                da.CommandType = CommandType.StoredProcedure;
                da.Parameters.AddWithValue("@idcaja", idcaja);
                da.Parameters.AddWithValue("@fi", fi);
                da.Parameters.AddWithValue("@ff", ff);
                monto = Convert.ToDouble(da.ExecuteScalar());
                CONEXIONMAESTRA.cerrar();
            }
            catch (Exception ex)
            {
                monto = 0;

            }

        }

        public static void sumar_gastos_por_turno(int idcaja, DateTime fi, DateTime ff, ref double monto)
        {
            try
            {
                CONEXIONMAESTRA.abrir();
                SqlCommand da = new SqlCommand("sumar_gastos_por_turno", CONEXIONMAESTRA.conectar);
                da.CommandType = CommandType.StoredProcedure;
                da.Parameters.AddWithValue("@idcaja", idcaja);
                da.Parameters.AddWithValue("@fi", fi);
                da.Parameters.AddWithValue("@ff", ff);
                monto = Convert.ToDouble(da.ExecuteScalar());
                CONEXIONMAESTRA.cerrar();
            }
            catch (Exception ex)
            {
                monto = 0;

            }

        }
        public static void sumar_CreditoPorCobrar(int idcaja, DateTime fi, DateTime ff, ref double monto)
        {
            try
            {
                CONEXIONMAESTRA.abrir();
                SqlCommand da = new SqlCommand("sumar_CreditoPorCobrar", CONEXIONMAESTRA.conectar);
                da.CommandType = CommandType.StoredProcedure;
                da.Parameters.AddWithValue("@idcaja", idcaja);
                da.Parameters.AddWithValue("@fi", fi);
                da.Parameters.AddWithValue("@ff", ff);
                monto = Convert.ToDouble(da.ExecuteScalar());
                CONEXIONMAESTRA.cerrar();
            }
            catch (Exception)
            {

                monto = 0;
            }
        }
        public static void sumar_CreditoPorPagar(int idcaja, DateTime fi, DateTime ff, ref double monto)
        {
            try
            {
                CONEXIONMAESTRA.abrir();
                SqlCommand da = new SqlCommand("sumar_CreditoPorPagar", CONEXIONMAESTRA.conectar);
                da.CommandType = CommandType.StoredProcedure;
                da.Parameters.AddWithValue("@idcaja", idcaja);
                da.Parameters.AddWithValue("@fi", fi);
                da.Parameters.AddWithValue("@ff", ff);
                monto = Convert.ToDouble(da.ExecuteScalar());
                CONEXIONMAESTRA.cerrar();
            }
            catch (Exception)
            {

                monto = 0;
            }
        }
        public static void buscar_Proveedores(ref DataTable dt, string buscador)
        {
            try
            {
                CONEXIONMAESTRA.abrir();
                SqlDataAdapter da = new SqlDataAdapter("buscar_Proveedores", CONEXIONMAESTRA.conectar);
                da.SelectCommand.CommandType = CommandType.StoredProcedure;
                da.SelectCommand.Parameters.AddWithValue("@letra", buscador);
                da.Fill(dt);
                CONEXIONMAESTRA.cerrar();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }



        public static void sumar_creaditoPorPagar(int idcaja, DateTime fi, DateTime ff, ref double monto)
        {
            try
            {
                CONEXIONMAESTRA.abrir();
                SqlCommand da = new SqlCommand("sumar_CreditoPorPagar", CONEXIONMAESTRA.conectar);
                da.CommandType = CommandType.StoredProcedure;
                da.Parameters.AddWithValue("@idcaja", idcaja);
                da.Parameters.AddWithValue("@fi", fi);
                da.Parameters.AddWithValue("@ff", ff);
                monto = Convert.ToDouble(da.ExecuteScalar());
                CONEXIONMAESTRA.cerrar();
            }
            catch (Exception)
            {

                monto = 0;
            }
        }

        public static void sumar_creaditoPorCobrar(int idcaja, DateTime fi, DateTime ff, ref double monto)
        {
            try
            {
                CONEXIONMAESTRA.abrir();
                SqlCommand da = new SqlCommand("sumar_CreditoPorCobrar", CONEXIONMAESTRA.conectar);
                da.CommandType = CommandType.StoredProcedure;
                da.Parameters.AddWithValue("@idcaja", idcaja);
                da.Parameters.AddWithValue("@fi", fi);
                da.Parameters.AddWithValue("@ff", ff);
                monto = Convert.ToDouble(da.ExecuteScalar());
                CONEXIONMAESTRA.cerrar();
            }
            catch (Exception)
            {

                monto = 0;
            }
        }

        public static void mostrar_cajas(ref DataTable dt)
        {
            try
            {
                Bases.Obtener_serialPC(ref serialPC);
                CONEXIONMAESTRA.abrir();
                SqlDataAdapter da = new SqlDataAdapter("mostrar_cajas_por_Serial_de_DiscoDuro", CONEXIONMAESTRA.conectar);
                da.SelectCommand.CommandType = CommandType.StoredProcedure;
                da.SelectCommand.Parameters.AddWithValue("@Serial", serialPC);
                da.Fill(dt);
                CONEXIONMAESTRA.cerrar();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.StackTrace);
            }
        }

        public static void mostrar_empresa(ref DataTable dt)
        {
            try
            {
                CONEXIONMAESTRA.abrir();
                SqlDataAdapter da = new SqlDataAdapter("select * from EMPRESA", CONEXIONMAESTRA.conectar);
                da.Fill(dt);
                CONEXIONMAESTRA.cerrar();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.StackTrace);
            }
        }

        public static void mostrarCorreoBase(ref DataTable dt)
        {
            try
            {
                CONEXIONMAESTRA.abrir();
                SqlDataAdapter da = new SqlDataAdapter("Select * from CorreoBase", CONEXIONMAESTRA.conectar);
                da.Fill(dt);
                CONEXIONMAESTRA.cerrar();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.StackTrace);
            }
        }

        //clientes

        public static void mostrar_Clientes(ref DataTable dt)
        {
            try
            {
                CONEXIONMAESTRA.abrir();
                SqlDataAdapter da = new SqlDataAdapter("mostrar_clientes", CONEXIONMAESTRA.conectar);
                da.Fill(dt);
                CONEXIONMAESTRA.cerrar();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.StackTrace);
            }
        }
        public static void buscar_Clientes(ref DataTable dt, string buscador)
        {
            try
            {
                CONEXIONMAESTRA.abrir();
                SqlDataAdapter da = new SqlDataAdapter("buscar_clientes", CONEXIONMAESTRA.conectar);
                da.SelectCommand.CommandType = CommandType.StoredProcedure;
                da.SelectCommand.Parameters.AddWithValue("@letra", buscador);
                da.Fill(dt);
                CONEXIONMAESTRA.cerrar();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.StackTrace);
            }
        }

        public static void mostrarEstadosCuentaCliente(ref DataTable dt, int idcliente)
        {
            try
            {
                CONEXIONMAESTRA.abrir();
                SqlDataAdapter da = new SqlDataAdapter("mostrarEstadosCuentaCliente", CONEXIONMAESTRA.conectar);
                da.SelectCommand.CommandType = CommandType.StoredProcedure;
                da.SelectCommand.Parameters.AddWithValue("@idcliente", idcliente);
                da.Fill(dt);
                CONEXIONMAESTRA.cerrar();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.StackTrace);

            }
        }

        public static void ReporteCantidadClientes(ref int Cantidad)
        {
            try
            {
                CONEXIONMAESTRA.abrir();
                SqlCommand da = new SqlCommand("select count(idclientev) from clientes", CONEXIONMAESTRA.conectar);
                Cantidad= Convert.ToInt32(da.ExecuteScalar());
                CONEXIONMAESTRA.cerrar();
            }
            catch (Exception)
            {

                Cantidad = 0;
            }
        }
        ///

        //controlCobros
        public static void mostrar_ControlCobros(ref DataTable dt)
        {
            try
            {
                CONEXIONMAESTRA.abrir();
                SqlDataAdapter da = new SqlDataAdapter("mostrar_ControlCobros", CONEXIONMAESTRA.conectar);
                da.Fill(dt);
                CONEXIONMAESTRA.cerrar();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.StackTrace);

            }
        }

        public static void ReportePorcobrar(ref double Monto )
         {
            try
            {
                CONEXIONMAESTRA.abrir();
                SqlCommand da= new SqlCommand("ReportePorCobrar", CONEXIONMAESTRA.conectar);
                Monto = Convert.ToDouble (da.ExecuteScalar());
                CONEXIONMAESTRA.cerrar();
            }
            catch (Exception)
            {

                Monto = 0;
            }
         }
        //


        // Proveedores
        public static void ReportePorPagar(ref double Monto)
        {
            try
            {
                CONEXIONMAESTRA.abrir();
                SqlCommand da = new SqlCommand("ReportePorPagar", CONEXIONMAESTRA.conectar);
                Monto = Convert.ToDouble(da.ExecuteScalar());
                CONEXIONMAESTRA.cerrar();
            }
            catch (Exception)
            {

                Monto = 0;
            }
        }

        public static void mostrar_Proveedores(ref DataTable dt)
        {
            try
            {
                CONEXIONMAESTRA.abrir();
                SqlDataAdapter da = new SqlDataAdapter("mostrar_Proveedores", CONEXIONMAESTRA.conectar);
                da.Fill(dt);
                CONEXIONMAESTRA.cerrar();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        //

        //Ventas
        public static void mostrarVentasGrafica(ref DataTable dt)
        {
            try
            {
                CONEXIONMAESTRA.abrir();
                SqlDataAdapter da = new SqlDataAdapter("mostrarVentasGrafica", CONEXIONMAESTRA.conectar);
                da.Fill(dt);
                CONEXIONMAESTRA.cerrar();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.StackTrace);
            }
        }

        public static void mostrarVentasGraficaFechas(ref DataTable dt, DateTime fi, DateTime ff)
        {
            try
            {
                CONEXIONMAESTRA.abrir();
                SqlDataAdapter da = new SqlDataAdapter("mostrarVentasGraficaFechas", CONEXIONMAESTRA.conectar);
                da.SelectCommand.CommandType = CommandType.StoredProcedure;
                da.SelectCommand.Parameters.AddWithValue("@fi", fi);
                da.SelectCommand.Parameters.AddWithValue("@ff", ff);

                da.Fill(dt);
                CONEXIONMAESTRA.cerrar();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.StackTrace);
            }
        }
        //
        //Detalle Ventas
        public static void ReporteGanancias(ref double Monto)
        {
            try
            {
                CONEXIONMAESTRA.abrir();
                SqlCommand da = new SqlCommand("ReporteGanacias", CONEXIONMAESTRA.conectar);
                Monto = Convert.ToDouble(da.ExecuteScalar());
                CONEXIONMAESTRA.cerrar();
            }
            catch (Exception)
            {

                Monto = 0;
            }
        }
        public static void ReporteTotalVentas(ref double Monto)
        {
            try
            {
                CONEXIONMAESTRA.abrir();
                SqlCommand da = new SqlCommand("ReporteTotalVentas", CONEXIONMAESTRA.conectar);
                Monto = Convert.ToDouble(da.ExecuteScalar());
                CONEXIONMAESTRA.cerrar();
            }
            catch (Exception)
            {

                Monto = 0;
            }
        }

        public static void ReporteTotalVentasFechas(ref double Monto, DateTime fi, DateTime ff)
        {
            try
            {
                CONEXIONMAESTRA.abrir();
                SqlCommand da = new SqlCommand("ReporteTotalVentasFechas", CONEXIONMAESTRA.conectar);
                da.CommandType = CommandType.StoredProcedure;
                da.Parameters.AddWithValue("@fi", fi);
                da.Parameters.AddWithValue("@ff", ff);
                Monto = Convert.ToDouble(da.ExecuteScalar());
                CONEXIONMAESTRA.cerrar();
            }
            catch (Exception ex)
            {
                Monto = 0;
            }
        }

        public static void ReporteGananciasFecha(ref double Monto, DateTime fi, DateTime ff)
        {
            try
            {
                CONEXIONMAESTRA.abrir();
                SqlCommand da = new SqlCommand("ReporteGananciasFecha", CONEXIONMAESTRA.conectar);
                da.CommandType = CommandType.StoredProcedure;
                da.Parameters.AddWithValue("@fi", fi);
                da.Parameters.AddWithValue("@ff", ff);
                Monto = Convert.ToDouble(da.ExecuteScalar());
                CONEXIONMAESTRA.cerrar();
            }
            catch (Exception ex)
            {
                Monto = 0;
            }
        }
        //
        //Productos 
        public static void ReporteProductoBajoMinimo(ref int Monto)
        {
            try
            {
                CONEXIONMAESTRA.abrir();
                SqlCommand da = new SqlCommand("ReporteProductoBajoMinimo", CONEXIONMAESTRA.conectar);
                Monto = Convert.ToInt32(da.ExecuteScalar());
                CONEXIONMAESTRA.cerrar();
            }
            catch (Exception)
            {

                Monto = 0;
            }
        }

        public static void ReporteCantProductos(ref int Cantidad)
        {
            try
            {
                CONEXIONMAESTRA.abrir();
                SqlCommand da = new SqlCommand("select count(Id_Producto1) from Producto1", CONEXIONMAESTRA.conectar);
                Cantidad = Convert.ToInt32(da.ExecuteScalar());
                CONEXIONMAESTRA.cerrar();
            }
            catch (Exception)
            {

                Cantidad = 0;
            }
        }

        public static void mostrarPmasVendidos(ref DataTable dt)
        {
            try
            {
                CONEXIONMAESTRA.abrir();
                SqlDataAdapter da = new SqlDataAdapter("mostrarPmasVendidos", CONEXIONMAESTRA.conectar);
                da.Fill(dt);
                CONEXIONMAESTRA.cerrar();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.StackTrace);
            }
        }
        //

        //Empresa
        public static void MostrarMoneda(ref string moneda)
        {
            try
            {
                CONEXIONMAESTRA.abrir();
                SqlCommand da = new SqlCommand("select Moneda from EMPRESA", CONEXIONMAESTRA.conectar);
                moneda =Convert.ToString( da.ExecuteScalar());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.StackTrace);
            }
        }
        //

        //Gastos
        public static void ReporteGastosAniosCombo(ref DataTable dt)
        {
            try
            {
                CONEXIONMAESTRA.abrir();
                SqlDataAdapter da = new SqlDataAdapter("ReporteGastosAniosCombo", CONEXIONMAESTRA.conectar);
                da.Fill(dt);
                CONEXIONMAESTRA.cerrar();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.StackTrace);
            }
        }

        public static void ReporteGastosMesCombo(ref DataTable dt, int anio)
        {
            try
            {
                CONEXIONMAESTRA.abrir();
                SqlDataAdapter da = new SqlDataAdapter("ReporteGastosMesCombo", CONEXIONMAESTRA.conectar);
                da.SelectCommand.CommandType = CommandType.StoredProcedure;
                da.SelectCommand.Parameters.AddWithValue("@anio", anio);
                da.Fill(dt);
                CONEXIONMAESTRA.cerrar();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.StackTrace);
            }
        }

        public static void ReporteGastosAnio(ref DataTable dt, int año)
        {
            try
            {
                CONEXIONMAESTRA.abrir();
                SqlDataAdapter da = new SqlDataAdapter("ReporteGastosAnioGrafica", CONEXIONMAESTRA.conectar);
                da.SelectCommand.CommandType = CommandType.StoredProcedure;
                da.SelectCommand.Parameters.AddWithValue("@anio", año);
                da.Fill(dt);
                CONEXIONMAESTRA.cerrar();


            }
            catch (Exception ex )
            {

                MessageBox.Show(ex.StackTrace);
            }
        }

        public static void ReporteGastosAnioMesGrafica(ref DataTable dt, int año, string mes)
        {
            try
            {
                CONEXIONMAESTRA.abrir();
                SqlDataAdapter da = new SqlDataAdapter("ReporteGastosAnioMesGrafica", CONEXIONMAESTRA.conectar);
                da.SelectCommand.CommandType = CommandType.StoredProcedure;
                da.SelectCommand.Parameters.AddWithValue("@anio", año);
                da.SelectCommand.Parameters.AddWithValue("@mes", mes);
                da.Fill(dt);
                CONEXIONMAESTRA.cerrar();


            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.StackTrace);
            }
        }
        //caja
        public static void mostrarPuertos(ref DataTable dt)
        {
            try
            {
                Obtener_datos.obtener_id_caja_PorSerial(ref idcaja);
                CONEXIONMAESTRA.abrir();
                SqlDataAdapter da = new SqlDataAdapter("mostrarPuertos", CONEXIONMAESTRA.conectar);
                da.SelectCommand.CommandType = CommandType.StoredProcedure;
                da.SelectCommand.Parameters.AddWithValue("@idcaja", idcaja);
                da.Fill(dt);
                CONEXIONMAESTRA.cerrar();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.StackTrace);
            }
           
            
        }
       
        }

    }





