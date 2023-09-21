using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using PUNTO_DE_VENTA.CONEXION;
using System.Windows.Forms;
using PUNTO_DE_VENTA.LOGIC;

namespace PUNTO_DE_VENTA.DATE
{
    
  public class Insertar_datos
    {
        int id_caja;
        public static bool insertar_Conceptos(string descripcion)
        {
            try
            {
                CONEXIONMAESTRA.abrir();
                SqlCommand cmd = new SqlCommand("insertar_Conceptos", CONEXIONMAESTRA.conectar);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Descripcion", descripcion);
                cmd.ExecuteNonQuery();
                CONEXIONMAESTRA.cerrar();
                return true;
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
                return false;
            }
        }

        public static bool  insertar_Gastos_varios(DateTime fecha, string Nro_comprobante,
            string tipo_comprobante, double importe, string descripcion, int id_Caja, int id_Concepto)
        {
            try
            {
                CONEXIONMAESTRA.abrir();
                SqlCommand cmd = new SqlCommand("insertar_Gastos_varios", CONEXIONMAESTRA.conectar);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Fecha", fecha);
                cmd.Parameters.AddWithValue("@Nro_comprobante", Nro_comprobante);
                cmd.Parameters.AddWithValue("@Tipo_comprobante", tipo_comprobante);
                cmd.Parameters.AddWithValue("@Importe", importe);
                cmd.Parameters.AddWithValue("@Descripcion", descripcion);
                cmd.Parameters.AddWithValue("@Id_caja", id_Caja);
                cmd.Parameters.AddWithValue("@Id_concepto", id_Concepto);
                cmd.ExecuteNonQuery();
                CONEXIONMAESTRA.cerrar();
                return true;
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.StackTrace);
                return false;
            }
        }

        public static bool insertar_Ingresos_varios(DateTime fecha, string Nro_comprobante,
            string tipo_comprobante, double importe, string descripcion, int id_Caja)
        {
            try
            {
                CONEXIONMAESTRA.abrir();
                SqlCommand cmd = new SqlCommand("insertar_Ingresos_varios", CONEXIONMAESTRA.conectar);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Fecha", fecha);
                cmd.Parameters.AddWithValue("@Nro_comprobante", Nro_comprobante);
                cmd.Parameters.AddWithValue("@Tipo_comprobante", tipo_comprobante);
                cmd.Parameters.AddWithValue("@Importe", importe);
                cmd.Parameters.AddWithValue("@Descripcion", descripcion);
                cmd.Parameters.AddWithValue("@Id_caja", id_Caja);
                cmd.ExecuteNonQuery();
                CONEXIONMAESTRA.cerrar();
                return true;
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.StackTrace);
                return false;
            }
        }

        public  bool insertar_CreditoPorPagar(LcreditosPorPagar parametros)
        {
            try
            {
                Obtener_datos.obtener_id_caja_PorSerial(ref id_caja);
                CONEXIONMAESTRA.abrir();
                SqlCommand cmd = new SqlCommand("insertar_CreditoPorPagar", CONEXIONMAESTRA.conectar);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Descripcion", parametros.Descripcion);
                cmd.Parameters.AddWithValue("@Fecha_registro", parametros.Fecha_registro);
                cmd.Parameters.AddWithValue("@Fecha_vencimiento", parametros.Fecha_vencimiento);
                cmd.Parameters.AddWithValue("@Total", parametros.Total);
                cmd.Parameters.AddWithValue("@Saldo", parametros.Saldo);
                cmd.Parameters.AddWithValue("@Estado", "DEBE");
                cmd.Parameters.AddWithValue("@Id_caja", id_caja);
                cmd.Parameters.AddWithValue("@Id_Proveedor", parametros.Id_proveedor);
                cmd.ExecuteNonQuery();
                return true;
              
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.StackTrace);
                return false;
            }
            finally
            {
                CONEXIONMAESTRA.cerrar();
            }
        }

        public bool insertar_CreditoPorCobrar(LcreditoPorCobrar parametros)
        {
            try
            {
                Obtener_datos.obtener_id_caja_PorSerial(ref id_caja);
                CONEXIONMAESTRA.abrir();
                SqlCommand cmd = new SqlCommand("insertar_CreditoPorCobrar", CONEXIONMAESTRA.conectar);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Descripcion", parametros.Descripcion);
                cmd.Parameters.AddWithValue("@Fecha_registro", parametros.Fecha_registro);
                cmd.Parameters.AddWithValue("@Fecha_vencimiento", parametros.Fecha_vencimiento);
                cmd.Parameters.AddWithValue("@Total", parametros.Total);
                cmd.Parameters.AddWithValue("@Saldo", parametros.Saldo);
                cmd.Parameters.AddWithValue("@Estado", "DEBE");
                cmd.Parameters.AddWithValue("@Id_caja", id_caja);
                cmd.Parameters.AddWithValue("@Id_cliente", parametros.Id_cliente);
                cmd.ExecuteNonQuery();
                return true;

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.StackTrace);
                return false;
            }
            finally
            {
                CONEXIONMAESTRA.cerrar();
            }
        }



        public bool insertar_Proveedores(LProveedores parametros)
        {
            try
            {
                Obtener_datos.obtener_id_caja_PorSerial(ref id_caja);
                CONEXIONMAESTRA.abrir();
                SqlCommand cmd = new SqlCommand("insertar_Proveedores", CONEXIONMAESTRA.conectar);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Nombre", parametros.Nombre);
                cmd.Parameters.AddWithValue("@Direccion", parametros.Direccion);
                cmd.Parameters.AddWithValue("@IdentificadorFiscal", parametros.IdentificadorFiscal);
                cmd.Parameters.AddWithValue("@Celular", parametros.Celular);
                cmd.Parameters.AddWithValue("@Estado", "ACTIVO");
                cmd.Parameters.AddWithValue("@Saldo", 0);
                cmd.ExecuteNonQuery();
                return true;

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
                return false;
            }
            finally
            {
                CONEXIONMAESTRA.cerrar();
            }
        }

        public bool insertar_Clientes(Lclientes parametros)
        {
            try
            {
                Obtener_datos.obtener_id_caja_PorSerial(ref id_caja);
                CONEXIONMAESTRA.abrir();
                SqlCommand cmd = new SqlCommand("insertar_Clientes", CONEXIONMAESTRA.conectar);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Nombre", parametros.Nombre);
                cmd.Parameters.AddWithValue("@Direccion", parametros.Direccion);
                cmd.Parameters.AddWithValue("@IdentificadorFiscal", parametros.IdentificadorFiscal);
                cmd.Parameters.AddWithValue("@Celular", parametros.Celular);
                cmd.Parameters.AddWithValue("@Estado", "ACTIVO");
                cmd.Parameters.AddWithValue("@Saldo", 0);
                cmd.ExecuteNonQuery();
                return true;

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
                return false;
            }
            finally
            {
                CONEXIONMAESTRA.cerrar();
            }
        }


    }
}
