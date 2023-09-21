using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using PUNTO_DE_VENTA.CONEXION;
using System.Windows.Forms;
using PUNTO_DE_VENTA.LOGIC;

namespace PUNTO_DE_VENTA.DATE
{
    class Editar_datos
    {
        
        public static void cambio_de_caja(int idcaja, int idventa)
        {
            CONEXIONMAESTRA.abrir();
            SqlCommand cmd = new SqlCommand("cambio_de_Caja", CONEXIONMAESTRA.conectar);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@idcaja", idcaja);
            cmd.Parameters.AddWithValue("@idventa", idventa);
            cmd.ExecuteNonQuery();
            CONEXIONMAESTRA.cerrar();
        }
        public static void ingresar_nombre_a_venta_en_espera(int idventa, string nombre)
        {
            try
            {
                CONEXIONMAESTRA.abrir();
                SqlCommand cmd = new SqlCommand("ingresar_nombre_a_venta_en_espera", CONEXIONMAESTRA.conectar);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@idventa", idventa);
                cmd.Parameters.AddWithValue("@nombre", nombre);
                cmd.ExecuteNonQuery();
                CONEXIONMAESTRA.cerrar();
            }
            catch (Exception ex )
            {

                MessageBox.Show(ex.Message);
            }
        }

        public static bool editar_Conceptos(int Idconcepto, string descripcion)
        {
            try
            {
                CONEXIONMAESTRA.abrir();
                SqlCommand cmd = new SqlCommand("editar_Conceptos", CONEXIONMAESTRA.conectar);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Id_concepto", Idconcepto);
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

        public static bool editar_dinero_caja_inicial(int Idcaja, double saldo)
        {
            try
            {
                CONEXIONMAESTRA.abrir();
                SqlCommand cmd = new SqlCommand("editar_dinero_caja_inicial", CONEXIONMAESTRA.conectar);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Id_caja", Idcaja);
                cmd.Parameters.AddWithValue("@saldo", saldo);
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

        public bool editar_Proveedores(LProveedores parametros)
        {
            try
            {
                CONEXIONMAESTRA.abrir();
                SqlCommand cmd = new SqlCommand("editar_Proveedores", CONEXIONMAESTRA.conectar);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@IdProveedor", parametros.IdProveedor);
                cmd.Parameters.AddWithValue("@Nombre", parametros.Nombre);
                cmd.Parameters.AddWithValue("@Direccion", parametros.Direccion);
                cmd.Parameters.AddWithValue("@IdentificadorFiscal", parametros.IdentificadorFiscal);
                cmd.Parameters.AddWithValue("@Celular", parametros.Celular);
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

        public bool editar_Clientes(Lclientes parametros)
        {
            try
            {
                CONEXIONMAESTRA.abrir();
                SqlCommand cmd = new SqlCommand("editar_Clientes", CONEXIONMAESTRA.conectar);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Idcliente", parametros.IdCliente);
                cmd.Parameters.AddWithValue("@Nombre", parametros.Nombre);
                cmd.Parameters.AddWithValue("@Direccion", parametros.Direccion);
                cmd.Parameters.AddWithValue("@IdentificadorFiscal", parametros.IdentificadorFiscal);
                cmd.Parameters.AddWithValue("@Celular", parametros.Celular);
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

        public bool restaurar_Proveedores(LProveedores parametros)
        {
            try
            {
                CONEXIONMAESTRA.abrir();
                SqlCommand cmd = new SqlCommand("restaurar_Proveedores", CONEXIONMAESTRA.conectar);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@IdProveedor", parametros.IdProveedor);
                
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
        public bool restaurar_Clientes(Lclientes parametros)
        {
            try
            {
                CONEXIONMAESTRA.abrir();
                SqlCommand cmd = new SqlCommand("restaurar_Clientes", CONEXIONMAESTRA.conectar);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Idcliente", parametros.IdCliente);

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


    }
}
